using System;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using SmartFrame.AuthorizationServiceReference;

namespace SmartFrame.Utils.Auth
{
    public class UserAuthentication : IAuthentication
    {
        private readonly string _cookieName = "__AUTH_COOKIE";

        public HttpContext HttpContext { get; set; }

        #region IAuthentication Members

        public UserContract Login(string userName, string password)
        {
            UserContract retUser = AuthService.Login(userName, password);
            if (retUser != null)
            {
                CreateCookie(userName, true);
            }
            return retUser;
        }

        private void CreateCookie(string userName, bool isPersistent = false)
        {
            var ticket = new FormsAuthenticationTicket(
                  1,
                  userName,
                  DateTime.Now,
                  DateTime.Now.Add(FormsAuthentication.Timeout),
                  isPersistent,
                  string.Empty,
                  FormsAuthentication.FormsCookiePath);
            var encTicket = FormsAuthentication.Encrypt(ticket);
            var authCookie = new HttpCookie(_cookieName)
            {
                Value = encTicket,
                Expires = DateTime.Now.Add(FormsAuthentication.Timeout)
            };
            HttpContext.Response.Cookies.Set(authCookie);
        }

        public void LogOut()
        {
            var httpCookie = HttpContext.Response.Cookies[_cookieName];
            if (httpCookie != null)
            {
                httpCookie.Value = string.Empty;
            }
        }

        public UserContract CreateUser(UserContract user)
        {
            AuthServiceClient client = new AuthServiceClient();
            var createdUser = client.CreateUser(user);
            client.Close();
            if (createdUser != null)
            {
                CreateCookie(createdUser.UserName, true);
                return createdUser;
            }
            return null;
        }

        private IPrincipal _currentUser;

        public IPrincipal CurrentUser
        {
            get
            {
                if (_currentUser == null)
                {
                    try
                    {
                        HttpCookie authCookie = HttpContext.Request.Cookies.Get(_cookieName);
                        if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                        {
                            var ticket = FormsAuthentication.Decrypt(authCookie.Value);
                            AuthServiceClient client = new AuthServiceClient();
                            _currentUser = new UserProvider(client.GetByUserName(ticket.Name));
                            client.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                return _currentUser;
            }
        }
        #endregion
    }
}