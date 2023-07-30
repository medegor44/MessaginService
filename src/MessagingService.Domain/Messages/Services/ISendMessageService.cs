namespace MessaginService.Domain.Messages.Services;

public interface ISendMessageService
{
    Task SendAsync(Message message, CancellationToken cancellationToken);
}