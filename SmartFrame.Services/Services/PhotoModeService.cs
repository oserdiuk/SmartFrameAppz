using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmartFrame.DAL;
using SmartFrame.Domain;
using SmartFrame.Services.DataContracts;
using SmartFrame.Services.ServiceContracts;

namespace SmartFrame.Services.Services
{
    public class PhotoModeService : IPhotoModeService
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public PhotoModeService()
        {
            Mapper.CreateMap<PhotoMode, PhotoModeContract>().ReverseMap();
        }

        public List<PhotoModeContract> GetAll()
        {
            var modes = unitOfWork.PhotoModeRepository.Get();
            return Mapper.Map<List<PhotoModeContract>>(modes);
        }
    }
}
