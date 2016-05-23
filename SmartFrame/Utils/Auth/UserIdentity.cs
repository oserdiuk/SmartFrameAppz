using SmartFrame.AuthorizationServiceReference;
using SmartFrame.Utils.Auth.Interfaces;

namespace SmartFrame.Utils.Auth
{
    public class UserIdentity : IUserIdentity
    {
        public UserContract User { get; set; }

        public string AuthenticationType
        {
            get
            {
                return typeof(UserContract).ToString();
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return User != null;
            }
        }

        public string Name
        {
            get
            {
                if (User != null)
                {
                    return User.UserName;
                }
                return "Guest";
            }
        }
    }
}
