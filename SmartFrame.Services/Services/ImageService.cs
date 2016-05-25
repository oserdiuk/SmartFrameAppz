using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
        private string defaultImageFolder = "/Images/";

        public ImageService()
        {
            Mapper.CreateMap<User, UserContract>().ReverseMap();
            Mapper.CreateMap<ImageContract, Image>().ReverseMap();
            Mapper.CreateMap<ImageDataContract, Image>().ReverseMap();
        }

        private string RelativeFilePath(string folder, string fileName, string extension = ".jpeg")
        {
            var absoluteFolderPath = AppDomain.CurrentDomain.BaseDirectory + defaultImageFolder;
            System.IO.Directory.CreateDirectory(absoluteFolderPath); //creates if not exist

            return string.Format("{0}{1}{2}",
                    absoluteFolderPath,
                    fileName,
                    extension);
        }

        public bool UploadImage(byte[] imageBytes, int moodId, string userName)
        {
            try
            {
                Guid imageNameGuid = Guid.NewGuid();
                var imagePath = this.RelativeFilePath(defaultImageFolder, imageNameGuid.ToString());
                using (var stream = new FileStream(imagePath, FileMode.OpenOrCreate))
                {
                    stream.Write(imageBytes, 0, imageBytes.Length);
                }
                AuthService authService = new AuthService();
                var currentUser = authService.GetByUserName(userName);
                Domain.Image imageModel = new Domain.Image()
                {
                    Name = imageNameGuid.ToString(),
                    MoodId = 1,
                    Owner = Mapper.Map<User>(currentUser)
                };
                unitOfWork.ImageRepository.Create(imageModel);
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                return false;
            }
        }

        public List<ImageContract> GetMyImages(string username)
        {
            var userImages = unitOfWork.ImageRepository.Get()
                                                       .Where(i => i.Owner.UserName == username).ToList();
            var imagesBytes = new List<ImageContract>();
            List<byte[]> imageByteArray = new List<byte[]>();
            for (int i = 0; i < userImages.Count(); i++)
            {
                imageByteArray.Add(File.ReadAllBytes(this.RelativeFilePath(defaultImageFolder, userImages.ElementAt(i).Name)));
            }
            Mapper.CreateMap<ImageContract, Image>();
            Mapper.CreateMap<Domain.Image, ImageContract>();
            Mapper.CreateMap<ImageDataContract, Domain.Image>();
            Mapper.CreateMap<Image, ImageDataContract>();
            Mapper.CreateMap<UserContract, User>();
            Mapper.CreateMap<User, UserContract>();
            for (int i = 0; i < imageByteArray.Count; i++)
            {
                imagesBytes.Add(new ImageContract()
                {
                    Owner = Mapper.Map<UserContract>(userImages.ElementAt(i).Owner),
                    ImageName = userImages.ElementAt(i).Name,
                    ImageBytes = imageByteArray[i]
                });
            }

            return imagesBytes;
        }
    }
}
