using System;
using System.Collections.Generic;
using System.Text;

namespace attendance.data
{
    public abstract class BaseRepository<TInput, TOutput>
    {
        public abstract IEnumerable<TOutput> Find(TInput request);
        public abstract TOutput Get(int id);
        public abstract TOutput Save(TOutput model);
        public abstract bool Delete(int id);
    }
}
