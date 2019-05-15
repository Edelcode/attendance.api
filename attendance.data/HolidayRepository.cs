using attendance.data.DbContext;
using attendance.objects.Contracts.Data;
using attendance.objects.Models;
using attendance.objects.Request;
using System;

namespace attendance.data
{
    public class HolidayRepository : BaseRepository<FindHolidayRequest, HolidayModel>, IHolidayRepository
    {
        private const string FindHolidaySpName = "attendance.GetHolidays";
        private const string GetHolidaySpName = "attendance.GetHoliday";
        private const string SaveHolidaySpName = "attendance.SaveHoliday";
        private const string DeleteHolidaySpName = "attendance.DeleteHoliday";

        public HolidayRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        protected override void InitRepository()
        {
            FindSpName = FindHolidaySpName;
            GetSpName = GetHolidaySpName;
            SaveSpName = SaveHolidaySpName;
            DeleteSpName = DeleteHolidaySpName;
        }
    }
}
