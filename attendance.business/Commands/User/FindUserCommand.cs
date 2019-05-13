using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;
using attendance.objects.Request;
using System.Collections.Generic;

namespace attendance.business.Commands.User
{
    public class FindUserCommand : IFindUserCommand
    {
        private readonly IUserRepository _userRepository;

        public FindUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserModel> Excecute(FindUserRequest request)
        {
            return _userRepository.Find(request);
        }
    }
}
