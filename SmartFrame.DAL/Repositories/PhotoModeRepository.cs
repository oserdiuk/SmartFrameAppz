using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartFrame.DAL.Interfaces.Repositories;
using SmartFrame.Domain;

namespace SmartFrame.DAL.Repositories
{
    public class PhotoModeRepository : RepositoryBase<PhotoMode>, IPhotoModeRepository
    {
        public PhotoModeRepository(SmartFrameDbContext dbContext)
            :base(dbContext)
        {
            
        }
    }
}