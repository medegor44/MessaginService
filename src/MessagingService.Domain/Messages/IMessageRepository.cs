namespace MessaginService.Domain.Messages;

public interface IMessageRepository
{
    Task CreateAsync(Message message, CancellationToken cancellationToken);
}