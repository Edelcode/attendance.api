﻿using attendance.objects.Models;
using attendance.objects.Request;

namespace attendance.objects.Contracts.Data
{
    public interface IHolidayRepository: IBaseRepository<FindHolidayRequest, HolidayModel>
    {
    }
}
