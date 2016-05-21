using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartFrame.DAL.Interfaces.Repositories;
using SmartFrame.Domain;

namespace SmartFrame.DAL.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(SmartFrameDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}