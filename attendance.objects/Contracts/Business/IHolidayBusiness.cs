using attendance.objects.Models;
using attendance.objects.Request;

namespace attendance.objects.Contracts.Business
{
    public interface IHolidayBusiness: IBaseBusiness<FindHolidayRequest, HolidayModel>
    {
    }
}
