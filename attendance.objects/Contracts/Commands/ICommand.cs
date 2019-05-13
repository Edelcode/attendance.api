namespace attendance.objects.Contracts.Commands
{
    public interface ICommand<TInput, TOutput>
    {
        TOutput Excecute(TInput input);
    }
}
