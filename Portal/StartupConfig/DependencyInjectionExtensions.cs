using Common.Library.DataAccess;
using CTC.Library;
using Portal.Data;
using TTracker.Library.Data;

namespace Portal.StartupConfig;


public static class DependencyInjectionExtensions
{
    public static void AddStandardServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
    }
    public static void AddCustomServices(this WebApplicationBuilder builder)
    {
        // DataAccess
        builder.Services.AddSingleton<IDataAccess, SqlDataAccess>();
        
        // Course Time Calculator DI
        builder.Services.AddTransient<WeatherForecastService>();
        builder.Services.AddTransient<ICourseTimeCalculator, CourseTimeCalculator>();

        // Match tracker DI
        builder.Services.AddTransient<IUserData, UserData>();
        builder.Services.AddTransient<ITeamData, TeamData>();
        builder.Services.AddTransient<IPrizeData, PrizeData>();
    }
}