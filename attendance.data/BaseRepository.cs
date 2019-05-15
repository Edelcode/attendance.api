using attendance.data.DbContext;
using attendance.objects.Contracts.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.data
{
    public abstract class BaseRepository<TRequest, TModel>: IBaseRepository<TRequest, TModel>
    {
        protected AppDbContext DbContext { get; set; }
       
        protected string FindSpName { get; set; }
        protected string GetSpName { get; set; }
        protected string SaveSpName { get; set; }
        protected string DeleteSpName { get; set; }

        protected abstract void InitRepository();

        public BaseRepository(AppDbContext appDbContext)
        {
            DbContext = appDbContext;

            InitRepository();
        }

        public async Task<bool> Delete(int id)
        {
            var parameters = new { id };
            var result = await DbContext.Execute(DeleteSpName, parameters);
            return result > 0;
        }

        public async Task<IEnumerable<TModel>> Find(TRequest request)
        {
            return await DbContext.Query<TModel>(FindSpName, request);
        }

        public async Task<TModel> Get(int id)
        {
            var parameters = new { id };
            var results = await DbContext.Query<TModel>(GetSpName, parameters);

            return results.FirstOrDefault();
        }

        public async Task<TModel> Save(TModel model)
        {
            var results = await DbContext.Query<TModel>(SaveSpName, model);

            return results.FirstOrDefault();
        }
    }
}
