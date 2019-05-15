using System.Threading.Tasks;

namespace attendance.objects.Contracts.Commands
{
    public interface IBaseCommand<TInput, TOutput>
    {
        Task<TOutput> Excecute(TInput input);
    }
}
