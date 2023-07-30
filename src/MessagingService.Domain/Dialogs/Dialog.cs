using MessaginService.Domain.Common;
using MessaginService.Domain.Dialogs.ValueObjects;

namespace MessaginService.Domain.Dialogs;

public class Dialog : Entity<DialogKey>
{
    public IReadOnlyCollection<Message> Messages { get; }

    public Dialog(long from, long to, IReadOnlyCollection<Message> messages)
    {
        Messages = messages;
        Id = new(from, to);
    }
}