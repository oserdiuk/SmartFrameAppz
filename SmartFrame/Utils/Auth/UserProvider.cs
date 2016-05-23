using System.Security.Principal;
using SmartFrame.AuthorizationServiceReference;
using SmartFrame.Utils.Auth.Interfaces;

namespace SmartFrame.Utils.Auth
{
    public class UserProvider : System.Security.Principal.IPrincipal
    {
        private IUserIdentity identity { get; set; }

        #region IPrincipal Members

        public IIdentity Identity
        {
            get
            {
                return identity;
            }
        }

        public bool IsInRole(string role)
        {
            return true;
        }

        #endregion


        public UserProvider(UserContract user)
        {
            identity = new UserIdentity { User = user };
        }


        public override string ToString()
        {
            return identity.Name;
        }
    }
}
