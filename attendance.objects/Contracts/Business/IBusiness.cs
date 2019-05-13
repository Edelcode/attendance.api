using System.Collections.Generic;

namespace attendance.objects.Contracts.Business
{
    public interface IBusiness<TInput, TOutput>
    {
        IEnumerable<TOutput> Find(TInput request);
        TOutput Get(int id);
        TOutput Save(TOutput model);
        bool Delete(int id);
    }
}
