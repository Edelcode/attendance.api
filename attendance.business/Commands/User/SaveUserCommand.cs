using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;

namespace attendance.business.Commands.User
{
    public class SaveUserCommand : ISaveUserCommand
    {
        private readonly IUserRepository _userRepository;

        public SaveUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserModel Excecute(UserModel model)
        {
            return _userRepository.Save(model);
        }
    }
}
