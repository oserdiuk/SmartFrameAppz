using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using SmartFrame.Services.DataContracts;

namespace SmartFrame.Services.ServiceContracts
{
    [ServiceContract]
    public interface IPhotoModeService
    {
        [OperationContract]
        List<PhotoModeContract> GetAll();
    }
}
