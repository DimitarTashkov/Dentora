using Microsoft.Extensions.DependencyInjection;
using Dentora.Extensions;
using Dentora.Forms;
using Dentora.Services.Interfaces;

namespace Dentora
{
    internal static class Program
    {
        public static ApplicationContext AppContext;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddDentoraServices();
            var serviceProvider = services.BuildServiceProvider();

            ServiceLocator.Initialize(serviceProvider);

            var userService = ServiceLocator.GetService<IUserService>();

            AppContext = new ApplicationContext(new Login(userService));
            Application.Run(AppContext);
        }

        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            AppContext.MainForm = newForm;
            newForm.Show();
            oldMainForm?.Close();
        }
    }
}