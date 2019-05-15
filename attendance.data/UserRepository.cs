using attendance.data.DbContext;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;
using attendance.objects.Request;

namespace attendance.data
{
    public class UserRepository : BaseRepository<FindUserRequest, UserModel>, IUserRepository
    {
        #region PRIVATE FIELDS

        private const string FindUserSpName = "attendance.GetUsers";
        private const string GetUserSpName = "attendance.GetUser";
        private const string SaveUserSpName = "attendance.SaveUser";
        private const string DeleteUserSpName = "attendance.DeleteUser";

        #endregion

        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        protected override void InitRepository()
        {
            FindSpName = FindUserSpName;
            GetSpName = GetUserSpName;
            SaveSpName = SaveUserSpName;
            DeleteSpName = DeleteUserSpName;
        }
    }
}
