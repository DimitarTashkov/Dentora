using Microsoft.Extensions.DependencyInjection;
using Dentora.Services;
using Dentora.Services.Interfaces;

namespace Dentora.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDentoraServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserService>(new UserService());
            services.AddSingleton<ITreatmentService>(new TreatmentService());
            services.AddSingleton<IAppointmentService>(new AppointmentService());
            services.AddSingleton<IInventoryService>(new InventoryService());
            services.AddSingleton<IReviewService>(new ReviewService());

            return services;
        }
    }
}
