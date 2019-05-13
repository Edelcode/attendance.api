﻿using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;

namespace attendance.business.Commands.User
{
    public class DeleteUserCommand : IDeleteUserCommand
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Excecute(int id)
        {
            return _userRepository.Delete(id);
        }
    }
}