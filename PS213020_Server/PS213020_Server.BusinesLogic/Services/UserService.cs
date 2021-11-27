using PS213020_Server.BusinesLogic.Core.Interfaces;
using PS213020_Server.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS213020_Server.BusinesLogic.Services
{
    public class UserService : IUserService
    {
        public Task<UserInformationBlo> Auth(int phoneNumberPrefix, int phoneNumber, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int phoneNumberPrefix, int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Registration(int phoneNumberPrefix, int phoneNumber, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(int phoneNumberPrefix, int phoneNumber, string password, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
