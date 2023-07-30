using MessagingService.DataAccess;
using MessagingService.Grpc;
using MessaginService.Domain.Dialogs.Services;
using MessaginService.Domain.Messages.Services;
using MessaginService.Migrations;
using MessaginService.Postgres;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddConnectionStringBuilder();

builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();

if (args.Contains("migrate"))
{
    builder.Services
        .AddMigration(builder.Configuration);
    builder.Build()
        .Services
        .UpdateDatabase();
    return;
}

builder.Services
    .AddPostgres()
    .AddRepositories()
    .AddScoped<ISendMessageService, SendMessageService>()
    .AddScoped<IListDialogService, ListDialogService>();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapGrpcReflectionService();
}
app.MapGrpcService<Service>();

app.Run();
