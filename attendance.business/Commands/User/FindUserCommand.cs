using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;
using attendance.objects.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace attendance.business.Commands.User
{
    public class FindUserCommand : IFindUserCommand
    {
        private readonly IUserRepository _userRepository;

        public FindUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserModel>> Excecute(FindUserRequest request)
        {
            return await _userRepository.Find(request);
        }
    }
}
