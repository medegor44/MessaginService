using System.Data.Common;
using MessagingService.DataAccess.Repositories;
using MessaginService.Domain.Dialogs;
using MessaginService.Domain.Messages;
using MessaginService.Domain.Messages.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace MessagingService.DataAccess;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPostgres(this IServiceCollection services) =>
        services.AddScoped<NpgsqlDataSource>(provider =>
            new NpgsqlDataSourceBuilder(provider.GetRequiredService<DbConnectionStringBuilder>().ToString())
                .UseLoggerFactory(provider.GetRequiredService<ILoggerFactory>())
                .EnableParameterLogging()
                .Build());

    public static IServiceCollection AddRepositories(this IServiceCollection services) =>
        services
            .AddScoped<IMessageRepository, MessagesRepository>()
            .AddScoped<IDialogsRepository, DialogsRepository>();
}