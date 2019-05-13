using System;
using System.Collections.Generic;
using System.Text;

namespace attendance.objects.Contracts.Data
{
    public interface IRepository<TInput, TOutput>
    {
        List<TOutput> Find(TInput request);
        TOutput Find(int id);
        TOutput Save(TOutput model);
        bool Delete(int id);
    }
}
