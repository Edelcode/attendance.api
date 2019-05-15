using System.Collections.Generic;
using System.Threading.Tasks;

namespace attendance.objects.Contracts.Data
{
    public interface IBaseRepository<TRequest, TModel>
    {
        Task<IEnumerable<TModel>> Find(TRequest request);
        Task<TModel> Get(int id);
        Task<TModel> Save(TModel model);
        Task<bool> Delete(int id);
    }
}
