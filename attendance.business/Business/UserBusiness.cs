using attendance.objects.Contracts.Business;
using attendance.objects.Contracts.Commands.User;
using attendance.objects.Models;
using attendance.objects.Request;
using System.Collections.Generic;

namespace attendance.business.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IFindUserCommand _findUserCommand;
        private readonly IGetUserCommand _getUserCommand;
        private readonly ISaveUserCommand _saveUserCommand;
        private readonly IDeleteUserCommand _deleteUserCommand;

        public UserBusiness(IFindUserCommand findUserCommand,
            IGetUserCommand getUserCommand,
            ISaveUserCommand saveUserCommand,
            IDeleteUserCommand deleteUserCommand)
        {
            _findUserCommand = findUserCommand;
            _getUserCommand = getUserCommand;
            _saveUserCommand = saveUserCommand;
            _deleteUserCommand = deleteUserCommand;
        }

        public bool Delete(int id)
        {
            return _deleteUserCommand.Excecute(id);
        }

        public IEnumerable<UserModel> Find(FindUserRequest request)
        {
            return _findUserCommand.Excecute(request);
        }

        public UserModel Get(int id)
        {
            return _getUserCommand.Excecute(id);
        }

        public UserModel Save(UserModel model)
        {
            return _saveUserCommand.Excecute(model);
        }
    }
}
