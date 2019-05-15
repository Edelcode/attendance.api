using attendance.objects.Models;

namespace attendance.objects.Contracts.Commands.User
{
    public interface IGetUserCommand : IBaseCommand<int, UserModel>
    {
    }
}
