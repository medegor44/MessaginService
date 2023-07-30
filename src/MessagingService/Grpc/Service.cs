using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MessagingService.Proto;
using MessaginService.Domain.Dialogs.Services;
using MessaginService.Domain.Messages.Services;

namespace MessagingService.Grpc;

public class Service : Proto.MessagingService.MessagingServiceBase
{
    private readonly ISendMessageService _sendMessageService;
    private readonly IListDialogService _listDialogService;

    public Service(ISendMessageService sendMessageService, IListDialogService listDialogService)
    {
        _sendMessageService = sendMessageService;
        _listDialogService = listDialogService;
    }
    
    public override async Task<Empty> Send(SendRequest request, ServerCallContext context)
    {
        var correlationId = context.RequestHeaders.GetValue("X-Correlation-Id") ?? Guid.NewGuid().ToString();
        
        await _sendMessageService.SendAsync(new(request.From, request.To, request.Text), context.CancellationToken);

        context.ResponseTrailers.Add("X-Correlation-Id", correlationId);
        
        return new();
    }

    public override async Task<ListDialogResponse> ListDialog(ListDialogRequest request, ServerCallContext context)
    {
        var dialog = await _listDialogService.ListAsync(request.From, request.To, context.CancellationToken);

        return new ListDialogResponse()
        {
            Messages =
            {
                dialog.Messages.Select(m => new Message()
                {
                    From = m.From,
                    To = m.To,
                    Text = m.Text
                })
            }
        };
    }
}