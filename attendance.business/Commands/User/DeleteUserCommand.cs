using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using System.Threading.Tasks;

namespace attendance.business.Commands.User
{
    public class DeleteUserCommand : IDeleteUserCommand
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Excecute(int id)
        {
            return await _userRepository.Delete(id);
        }
    }
}
