using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;

namespace attendance.business.Commands.User
{
    public class GetUserCommand : IGetUserCommand
    {
        private readonly IUserRepository _userRepository;

        public GetUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserModel Excecute(int id)
        {
            return _userRepository.Get(id);
        }
    }
}
