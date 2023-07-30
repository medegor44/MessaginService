using MessaginService.Domain.Dialogs.ValueObjects;

namespace MessaginService.Domain.Dialogs;

public interface IDialogsRepository
{
    Task<Dialog> GetAsync(DialogKey key, CancellationToken cancellationToken);
}