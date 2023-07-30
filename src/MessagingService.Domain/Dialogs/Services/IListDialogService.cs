namespace MessaginService.Domain.Dialogs.Services;

public interface IListDialogService
{
    public Task<Dialog> ListAsync(long from, long to, CancellationToken cancellationToken);
}