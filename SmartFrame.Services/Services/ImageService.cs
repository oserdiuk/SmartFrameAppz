using System;
using System.CodeDom;
using System.Collections.Generic;
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
        IUnitOfWork unitOfWork = new UnitOfWork();

        public ImageService()
        {
            Mapper.CreateMap<User, UserContract>().ReverseMap();
        }

        public bool UploadImage(byte[] imageBytes, int moodId, string userName)
        {
            try
            {
                var stream = new MemoryStream(imageBytes);
                Image img = Image.FromStream(stream);
                Guid imageName = new Guid();
                img.Save(string.Format("Images/{0}.jpeg", imageName));
                AuthService authService = new AuthService();
                var currentUser = authService.GetByUserName(userName);
                Domain.Image imageModel = new Domain.Image()
                {
                    Name = imageName.ToString(),
                    MoodId = moodId,
                    Owner = Mapper.Map<User>(currentUser)
                };
                unitOfWork.ImageRepository.Create(imageModel);
                unitOfWork.Save();
                return true;
            }
        }
    

        List<ImageContract> GetMyImages(string username)
        {
            throw new NotImplementedException();
        }
    }
}
