using System.Security.Principal;
using SmartFrame.Services.DataContracts;
using SmartFrame.Services.IPrincipal.Interfaces;

namespace SmartFrame.Services.IPrincipal
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
