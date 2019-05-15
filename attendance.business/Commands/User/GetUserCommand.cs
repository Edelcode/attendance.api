using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;
using System.Threading.Tasks;

namespace attendance.business.Commands.User
{
    public class GetUserCommand : IGetUserCommand
    {
        private readonly IUserRepository _userRepository;

        public GetUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserModel> Excecute(int id)
        {
            return await _userRepository.Get(id);
        }
    }
}
