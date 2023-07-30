namespace MessaginService.Domain.Dialogs.Services;

public class ListDialogService : IListDialogService
{
    private readonly IDialogsRepository _dialogsRepository;

    public ListDialogService(IDialogsRepository dialogsRepository)
    {
        _dialogsRepository = dialogsRepository;
    }

    public Task<Dialog> ListAsync(long from, long to, CancellationToken cancellationToken) =>
        _dialogsRepository.GetAsync(new(from, to), cancellationToken);
}