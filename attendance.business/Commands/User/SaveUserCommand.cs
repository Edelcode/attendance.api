using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;
using System.Threading.Tasks;

namespace attendance.business.Commands.User
{
    public class SaveUserCommand : ISaveUserCommand
    {
        private readonly IUserRepository _userRepository;

        public SaveUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserModel> Excecute(UserModel model)
        {
            return await _userRepository.Save(model);
        }
    }
}
