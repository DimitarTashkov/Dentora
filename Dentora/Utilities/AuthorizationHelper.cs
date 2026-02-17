using Dentora.Services.Interfaces;
using System.Threading.Tasks;

namespace Dentora.Utilities
{
    public class AuthorizationHelper
    {
        private static bool isAuthorized;
        public static async Task<bool> InitializeAuthorizationStatusAsync(IUserService userService)
        {
            bool _isAuthorized;
            var loggedInUser = userService.GetLoggedInUserAsync();
            if (loggedInUser != null)
            {
                _isAuthorized = await userService.IsUserAdminAsync(loggedInUser.Id);
            }
            else
            {
                _isAuthorized = false;
            }
            isAuthorized = _isAuthorized;
            return _isAuthorized;
        }
        public static bool IsAuthorized()
        {
            return isAuthorized;
        }
    }
}
