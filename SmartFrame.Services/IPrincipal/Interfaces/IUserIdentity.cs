using System.Security.Principal;
using SmartFrame.Services.DataContracts;

namespace SmartFrame.Services.IPrincipal.Interfaces
{
    public interface IUserIdentity : IIdentity
    {
        UserContract User { get; set; }

    }
}
