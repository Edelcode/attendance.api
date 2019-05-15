using attendance.objects.Models;
using attendance.objects.Request;
using System.Collections.Generic;

namespace attendance.objects.Contracts.Commands.User
{
    public interface IFindUserCommand : IBaseCommand<FindUserRequest, IEnumerable<UserModel>>
    {
    }
}
