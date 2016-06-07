using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using SmartFrame.DAL;
using SmartFrame.DAL.Interfaces;
using SmartFrame.Domain;
using SmartFrame.Services.DataContracts;
using SmartFrame.Services.ServiceContracts;
using Image = System.Drawing.Image;

namespace SmartFrame.Services.Services
{
    public class ImageService : IImageService
    {
        private IUnitOfWork unitOfWork = new UnitOfWork();
        private string defaultImageFolder = "../../../Images/";

        private const string cloudinaryApiKey = "439665995966528";
        private const string cloudinarySecretKey = "gw30kfx_HIgSVbBsOiNGE9WTEuY";
        private const string cloudinaryCloudName = "doljywzkx";

        public ImageService()
        {
            Mapper.CreateMap<User, UserContract>().ReverseMap();
            Mapper.CreateMap<ImageContract, Image>().ReverseMap();
            Mapper.CreateMap<ImageDataContract, Image>().ReverseMap();
        }

        private string RelativeFilePath(string folder, string fileName)
        {
            var absoluteFolderPath = AppDomain.CurrentDomain.BaseDirectory + defaultImageFolder;
            System.IO.Directory.CreateDirectory(absoluteFolderPath); //creates if not exist

            return string.Format("{0}{1}",
                    absoluteFolderPath,
                    fileName);
        }

        private string UniqueImageName(string extension = ".jpeg")
        {
            return string.Format("{0}{1}",
                    Guid.NewGuid().ToString(),
                    extension);
        }

        private Cloudinary configuredImageService()
        {
            Account account = new Account(
                cloudinaryCloudName,
                cloudinaryApiKey,
                cloudinarySecretKey);

            Cloudinary cloudinary = new Cloudinary(account);
            return cloudinary;
        }

        public bool UploadImage(byte[] imageBytes, int moodId, string userName)
        {
            try
            {
                string imageFileName = UniqueImageName();
                var cloudinary = configuredImageService();
                using (var stream = new MemoryStream(imageBytes))
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(imageFileName, stream),
                        
                    };

                    var uploadResult = cloudinary.Upload(uploadParams);
                    
                    AuthService authService = new AuthService();
                    var currentUser = authService.GetByUserName(userName);
                    Domain.Image imageModel = new Domain.Image()
                    {
                        Name = uploadResult.Uri.OriginalString,
                        MoodId = 1,
                        Owner = Mapper.Map<User>(currentUser)
                    };
                    unitOfWork.ImageRepository.Create(imageModel);
                    unitOfWork.Save();
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                return false;
            }
        }

        public ImageContract GetMyImages(string username)
        {

            var path = System.Web.Hosting.HostingEnvironment.MapPath("Images");
            path = HostingEnvironment.MapPath("~/Images/");
            if (path == null)
            {
                var uriPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Images\\";
                path = new Uri(uriPath).LocalPath;
            }

            var userImages = unitOfWork.ImageRepository.Get()
                                                       .Where(i => i.Owner.UserName == username).ToList();
            var images = new ImageContract();
            images.ImageNames = userImages.Select(i => i.Name).ToList();
            images.ImagesPath = path;

            Mapper.CreateMap<ImageContract, Image>();
            Mapper.CreateMap<Domain.Image, ImageContract>();
            Mapper.CreateMap<ImageDataContract, Domain.Image>();
            Mapper.CreateMap<Image, ImageDataContract>();
            Mapper.CreateMap<UserContract, User>();
            Mapper.CreateMap<User, UserContract>();
            //images.Owner = Mapper.Map<UserContract>(userImages.FirstOrDefault()?.Owner);

            return images;
        }
    }
}
