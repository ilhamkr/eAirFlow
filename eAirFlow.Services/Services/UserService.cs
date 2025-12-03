using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using eAirFlow.Model.Messages;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

using UserModel = eAirFlow.Model.Models.User;
using DbUser = eAirFlow.Services.Database.User;
using DbEmailConfirmation = eAirFlow.Services.Database.EmailConfirmation;
using DbUserRole = eAirFlow.Services.Database.UserRole;
using eAirFlow.Services.RabbitMQ;

namespace eAirFlow.Services.Services
{
    public class UserService
        : BaseCRUDService<UserModel, UserSearchObjects, DbUser, UserInsertRequest, UserUpdateRequest>,
          IUserService
    {
        private readonly _210019Context _context;
        private readonly IRabbitMQService _rabbitMq;

        public UserService(_210019Context context, IMapper mapper, IRabbitMQService rabbitMq)
            : base(context, mapper)
        {
            _context = context;
            _rabbitMq = rabbitMq;
        }
        public override IQueryable<DbUser> AddFilter(UserSearchObjects searchObject, IQueryable<DbUser> query)
        {
            query = base.AddFilter(searchObject, query);

            if (!string.IsNullOrWhiteSpace(searchObject?.NameGTE))
                query = query.Where(x => x.Name.StartsWith(searchObject.NameGTE));

            if (!string.IsNullOrWhiteSpace(searchObject?.SurnameGTE))
                query = query.Where(x => x.Surname.StartsWith(searchObject.SurnameGTE));

            if (!string.IsNullOrWhiteSpace(searchObject?.Email))
                query = query.Where(x => x.Email == searchObject.Email);

            query = query
                .Include(x => x.UserRoles).ThenInclude(ur => ur.Role)
                .Include(x => x.Employee).ThenInclude(e => e.Position)
                .Include(x => x.Employee).ThenInclude(e => e.Airport);

            return query;
        }

        public override void BeforeInsert(UserInsertRequest request, DbUser entity)
        {
            if (_context.Users.Any(x => x.Email == request.Email))
                throw new Exception("Email already exists.");

            if (request.Passsword != request.PasswordConfirmation)
                throw new Exception("Password and confirmation must match!");

            var salt = GenerateSalt();
            entity.PasswordSalt = salt;
            entity.PasswordHash = GenerateHash(salt, request.Passsword);
            entity.CreatedAt = DateTime.Now;

            base.BeforeInsert(request, entity);
        }

        public async Task<UserModel> RegisterAsync(UserInsertRequest request)
        {
            var entity = await base.InsertAsync(request);

            var token = Guid.NewGuid().ToString("N");

            var confirmation = new DbEmailConfirmation
            {
                UserId = entity.UserId,
                Token = token,
                CreatedAt = DateTime.Now,
                IsConfirmed = false
            };

            _context.EmailConfirmations.Add(confirmation);
            await _context.SaveChangesAsync();

            await _rabbitMq.SendEmail(new Email
            {
                EmailTo = entity.Email!,
                ReceiverName = entity.Name ?? "User",
                Subject = "Confirm your eAirFlow email",
                Message = $@"
                    <h2>Welcome to eAirFlow!</h2>
                    <p>Please confirm your email:</p>
                    <a href='https://localhost:7239/User/confirm/{token}'>
                        Confirm Email
                    </a>
                "
            });

            _context.UserRoles.Add(new DbUserRole
            {
                UserId = entity.UserId,
                RoleId = request.RoleId
            });

            await _context.SaveChangesAsync();

            return entity;
        }

        public override void BeforeUpdate(UserUpdateRequest request, DbUser entity)
        {
            if (request.Password != null)
            {
                if (request.Password != request.PasswordConfirmation)
                    throw new Exception("Password must match confirmation");

                var salt = GenerateSalt();
                entity.PasswordSalt = salt;
                entity.PasswordHash = GenerateHash(salt, request.Password);
            }

            base.BeforeUpdate(request, entity);
        }

        public UserModel Login(string email, string password)
        {
            var entity = _context.Users
            .Include(x => x.UserRoles).ThenInclude(ur => ur.Role).Include(x => x.Employee).ThenInclude(e => e.Position).FirstOrDefault(x => x.Email == email);

            if (entity == null) return null;

            var hash = GenerateHash(entity.PasswordSalt, password);
            if (hash != entity.PasswordHash) return null;

            var model = _mapper.Map<UserModel>(entity);
            model.EmployeeId = entity.Employee?.EmployeeId;
            return model;

        }

        public async Task<DbUser?> GetDbUser(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
        }

        public async Task SaveDbChanges()
        {
            await _context.SaveChangesAsync();
        }

        private string GenerateSalt()
        {
            var bytes = new byte[16];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        private string GenerateHash(string salt, string password)
        {
            using var sha = SHA256.Create();
            var combined = salt + password;
            var bytes = Encoding.UTF8.GetBytes(combined);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return false;

            var roles = _context.UserRoles.Where(x => x.UserId == id);
            _context.UserRoles.RemoveRange(roles);

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();
            return true;
        }

    }
}
