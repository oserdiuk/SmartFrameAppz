using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using SmartFrame.DAL;
using SmartFrame.DAL.Interfaces;
using SmartFrame.Domain;
using SmartFrame.Services.DataContracts;
using SmartFrame.Services.ServiceContracts;

namespace SmartFrame.Services.Services
{
    public class AuthService : IAuthService
    {
        private IUnitOfWork unitOfWork;

        public AuthService()
        {
            Mapper.CreateMap<User, UserContract>().ReverseMap();
            unitOfWork = new UnitOfWork();
        }

        public UserContract CreateUser(UserContract model)
        {
            User user = Mapper.Map<User>(model);
            user.Salt = GenerateSalt(DateTime.UtcNow.Hour);
            user.PasswordHash = GetHash(model.Password, user.Salt);

            var createdUser = Mapper.Map<UserContract>(unitOfWork.UserRepository.Create(user));
            unitOfWork.Save();
            return createdUser;
        }

        private string GenerateSalt(int size)
        {
            RandomNumberGenerator rng = new RNGCryptoServiceProvider();
            var buffer = new byte[size];
            rng.GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }

        private string GetHash(string value, string salt)
        {
            byte[] saltedValue = Encoding.UTF8.GetBytes(value + salt);
            var bytess = new SHA256Managed().ComputeHash(saltedValue);
            return Convert.ToBase64String(bytess);
        }

        public UserContract GetByUserName(string name)
        {
            return Mapper.Map<UserContract>(unitOfWork.UserRepository.Get(u => u.UserName == name).First());
        }

        public UserContract GetMany(Expression<Func<User, bool>> where)
        {
            return Mapper.Map<UserContract>(unitOfWork.UserRepository.Get(where).FirstOrDefault());
        }

        public UserContract Login(string userName, string password)
        {
            User user = unitOfWork.UserRepository.Get(u => u.UserName == userName).First();
            if (user != null)
            {
                var hash = GetHash(password, user.Salt);
                if (hash == user.PasswordHash)
                {
                    return Mapper.Map<UserContract>(user);
                }
            }
            return null;
        }

        public List<UserContract> Get()
        {
            return Mapper.Map<List<UserContract>>(unitOfWork.UserRepository.Get());
        }
    }
}
