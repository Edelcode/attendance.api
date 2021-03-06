﻿using attendance.objects.Models;
using attendance.objects.Request;

namespace attendance.objects.Contracts.Data
{
    public interface IUserRepository : IBaseRepository<FindUserRequest, UserModel>
    {
    }
}
