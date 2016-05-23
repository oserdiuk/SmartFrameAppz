using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.Threading.Tasks;
using SmartFrame.Services.DataContracts;
using System.Drawing;

namespace SmartFrame.Services.ServiceContracts
{
    [ServiceContract]
    public interface IImageService
    {
        [OperationContract]
        List<ImageContract> GetMyImages(string username);

        [OperationContract]
        bool UploadImage(byte[] imageBytes, int moodId, string userName);
    }
}
