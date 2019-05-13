using attendance.objects.Models;

namespace attendance.objects.Contracts.Commands
{
    public interface ISaveUserCommand: ICommand<UserModel, UserModel>
    {
    }
}
