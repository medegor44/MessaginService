namespace MessaginService.Domain.Messages.Services;

public class SendMessageService : ISendMessageService
{
    private readonly IMessageRepository _messageRepository;

    public SendMessageService(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }
    
    public Task SendAsync(Message message, CancellationToken cancellationToken) =>
        _messageRepository.CreateAsync(message, cancellationToken);
}