﻿using System.Collections.Generic;

namespace attendance.objects.Contracts.Data
{
    public interface IRepository<TInput, TOutput>
    {
        IEnumerable<TOutput> Find(TInput request);
        TOutput Get(int id);
        TOutput Save(TOutput model);
        bool Delete(int id);
    }
}
