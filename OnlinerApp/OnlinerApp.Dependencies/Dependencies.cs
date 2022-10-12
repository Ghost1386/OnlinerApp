using Microsoft.Extensions.DependencyInjection;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.BusinessLogic.Services;

namespace OnlinerApp.Dependencies;

public static class Dependencies
{
    public static void AddIService(this IServiceCollection services)
    {
        services.AddTransient<IAuthService, AuthService>();
        
        services.AddTransient<IUserService, UserService>();
        
        services.AddTransient<IComputerService, ComputerService>();
        services.AddTransient<IFridgeService, FridgeService>();
        services.AddTransient<IHobService, HobService>();
        services.AddTransient<IMicrowaveService, MicrowaveService>();
        services.AddTransient<IMotorbikeService, MotorbikeService>();
        services.AddTransient<INotebookService, NotebookService>();
        services.AddTransient<ITelephoneService, TelephoneService>();
        services.AddTransient<ITelevisionService, TelevisionService>();
        services.AddTransient<IVacuumCleanerService, VacuumCleanerService>();
        services.AddTransient<IWasherService, WasherService>();
        
        services.AddTransient<ISortService, SortService>();
    }
}