using attendance.objects.Contracts.Business;
using attendance.objects.Contracts.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace attendance.business.Business
{
    public class BaseBusiness<TRequest, TModel> : IBaseBusiness<TRequest, TModel>
    {
        private readonly IBaseCommand<TRequest, IEnumerable<TModel>> _findCommand;
        private readonly IBaseCommand<int, TModel> _getCommand;
        private readonly IBaseCommand<TModel, TModel> _saveCommand;
        private readonly IBaseCommand<int, bool> _deleteCommand;

        public BaseBusiness(IBaseCommand<TRequest, IEnumerable<TModel>> findCommand,
            IBaseCommand<int, TModel> getCommand,
            IBaseCommand<TModel, TModel> saveCommand,
            IBaseCommand<int, bool> deleteCommand)
        {
            _findCommand = findCommand;
            _getCommand = getCommand;
            _saveCommand = saveCommand;
            _deleteCommand = deleteCommand;
        }

        public async Task<bool> Delete(int id)
        {
            return await _deleteCommand.Excecute(id);
        }

        public async Task<IEnumerable<TModel>> Find(TRequest request)
        {
            return await _findCommand.Excecute(request);
        }

        public async Task<TModel> Get(int id)
        {
            return await _getCommand.Excecute(id);
        }

        public async Task<TModel> Save(TModel model)
        {
            return await _saveCommand.Excecute(model);
        }
    }
}
