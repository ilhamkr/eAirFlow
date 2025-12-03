using eAirFlow.Model;
using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = eAirFlow.Model.Models.User;

namespace eAirFlow.Services.Interfaces
{
    public interface IUserService : ICRUDService<User, UserSearchObjects, UserInsertRequest, UserUpdateRequest>
    {
        Model.Models.User Login (string username, string password);
        Task<eAirFlow.Services.Database.User?> GetDbUser(int id);
        Task SaveDbChanges();
        Task<User> RegisterAsync(UserInsertRequest request);
        Task<bool> DeleteUserAsync(int id);
    }
}
