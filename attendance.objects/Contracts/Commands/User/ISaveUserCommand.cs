﻿using attendance.objects.Models;

namespace attendance.objects.Contracts.Commands.User
{
    public interface ISaveUserCommand: IBaseCommand<UserModel, UserModel>
    {
    }
}
