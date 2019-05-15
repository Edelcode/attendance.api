using attendance.objects.Contracts.Business;
using attendance.objects.Models;
using attendance.objects.Request;
using Microsoft.AspNetCore.Mvc;

namespace attendance.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<FindUserRequest, UserModel>
    {
        public UserController(IUserBusiness userBusiness) : base(userBusiness)
        {
        }
    }
}
