using attendance.objects.Contracts.Business;
using attendance.objects.Contracts.Commands.User;
using attendance.objects.Models;
using attendance.objects.Request;

namespace attendance.business.Business
{
    public class UserBusiness : BaseBusiness<FindUserRequest, UserModel>, IUserBusiness
    {
        public UserBusiness(IFindUserCommand findCommand,
            IGetUserCommand getCommand,
            ISaveUserCommand saveCommand,
            IDeleteUserCommand deleteCommand) 
            : base(findCommand, getCommand, saveCommand, deleteCommand)
        {
        }
    }
}
