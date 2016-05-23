using System.Security.Principal;
using System.Web;
using SmartFrame.AuthorizationServiceReference;

namespace SmartFrame.Utils.Auth
{
    public interface IAuthentication
    {
        HttpContext HttpContext { get; set; }

        UserContract Login(string login, string password);

        void LogOut();

        IPrincipal CurrentUser { get; }

        UserContract CreateUser(UserContract user);
    }
}
