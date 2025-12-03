using eAirFlow.Services.FlightStateMachine;
using eAirFlow.Services.CheckInStateMachine;
using eAirFlow.Services.Database;
using eAirFlow.Services.FlightStateMachine;
using eAirFlow.Services.Interfaces;
using eAirFlow.Services.LuggageStateMachine;
using eAirFlow.Services.ReservationStateMachine;
using eAirFlow.Services.Services;
using eAirFlow.WebAPI;
using Mapster;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Security.Cryptography;
using System.Text;
using eAirFlow.Services.Database;
using Microsoft.EntityFrameworkCore;
using eAirFlow.Services.RabbitMQ;
using eAirFlow.WebAPI.Settings;
using eAirFlow.Services.Mapping;
using static eAirFlow.Services.Services.UserService;
using eAirFlow.Services.Exceptions;
using eAirFlow.Services.Recommender;


var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5239", "https://localhost:7239");


builder.Services.Configure<PayPalSettings>(
    builder.Configuration.GetSection("PayPal")
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme, Id = "basicAuth"}
            },
            new string[]{}
    } });

});
var connectionString = builder.Configuration.GetConnectionString("eAirFlowConnection");
builder.Services.AddDbContext<_210019Context>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddMapster();
MappingConfig.RegisterMappings();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAirlineService, AirlineService>();
builder.Services.AddScoped<IAirplaneService, AirplaneService>();
builder.Services.AddScoped<ICheckInService, CheckInService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IFlightReviewService, FlightReviewService>();
builder.Services.AddScoped<ILuggageService, LuggageService>();
builder.Services.AddScoped<ILuggageReportService, LuggageReportService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IPositionService, PositionService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<ISeatService, SeatService>();
builder.Services.AddScoped<ISeatClassService, SeatClassService>();
builder.Services.AddScoped<IUserRoleService, UserRoleService>();
builder.Services.AddScoped<IReservationStateMachine, ReservationStateMachine>();
builder.Services.AddScoped<IAirportService, AirportService>();
builder.Services.AddScoped<IMealTypeService, MealTypeService>();
builder.Services.AddScoped<IFlightRecommenderService, FlightRecommenderService>();

builder.Services.AddScoped<BaseFlightState>();
builder.Services.AddScoped<BoardingFlightState>();
builder.Services.AddScoped<ScheduledFlightState>();
builder.Services.AddScoped<DelayedFlightState>();
builder.Services.AddScoped<CancelledFlightState>();
builder.Services.AddScoped<CompletedFlightState>();

builder.Services.AddScoped<BaseReservationState>();
builder.Services.AddScoped<InitialReservationState>();
builder.Services.AddScoped<ConfirmedReservationState>();
builder.Services.AddScoped<CancelledReservationState>();
builder.Services.AddScoped<CompletedReservationState>();

builder.Services.AddScoped<BaseCheckInState>();
builder.Services.AddScoped<CancelledCheckInState>();
builder.Services.AddScoped<CompletedCheckInState>();
builder.Services.AddScoped<PendingCheckInState>();

builder.Services.AddScoped<BaseLuggageState>();
builder.Services.AddScoped<MissingLuggageState>();
builder.Services.AddScoped<FoundLuggageState>();
builder.Services.AddScoped<PickedUpLuggageState>();
builder.Services.AddScoped<LostLuggageState>();


builder.Services.AddScoped<IRabbitMQService, RabbitMQService>();

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var app = builder.Build();

app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (UserException ex)
    {
        context.Response.StatusCode = ex.StatusCode;
        await context.Response.WriteAsync(ex.Message);
    }
});


app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<_210019Context>();

    //dataContext.Database.Migrate();
}

app.Run();
