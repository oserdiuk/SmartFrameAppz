using System.Security.Principal;
using SmartFrame.AuthorizationServiceReference;

namespace SmartFrame.Utils.Auth.Interfaces
{
    public interface IUserIdentity : IIdentity
    {
        UserContract User { get; set; }

    }
}
