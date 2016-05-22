using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ServiceModel;
using SmartFrame.Domain;
using SmartFrame.Services.DataContracts;

namespace SmartFrame.Services.ServiceContracts
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        UserContract CreateUser(UserContract model);

        [OperationContract]
        UserContract Login(string userName, string password);

        [OperationContract]
        UserContract GetByUserName(string name);

        [OperationContract]
        List<UserContract> Get();
    }
}
