using attendance.objects.Models;

namespace attendance.objects.Contracts.Commands.User
{
    public interface IGetUserCommand : ICommand<int, UserModel>
    {
    }
}
