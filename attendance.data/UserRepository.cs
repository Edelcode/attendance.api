using attendance.objects.Contracts.Data;
using attendance.objects.Models;
using attendance.objects.Request;
using System;
using System.Collections.Generic;

namespace attendance.data
{
    public class UserRepository : IUserRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> Find(FindUserRequest request)
        {
            throw new NotImplementedException();
        }

        public UserModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel Save(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
