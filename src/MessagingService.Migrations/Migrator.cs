﻿using System.Data.Common;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Migrations.Migrations;

namespace MessaginService.Migrations;

public static class Migrator
{
    public static IServiceCollection AddMigration(this IServiceCollection collection, IConfiguration configuration)
    {
        return collection
            .AddFluentMigratorCore()
            .ConfigureRunner(builder => builder
                .WithGlobalConnectionString(provider => provider.GetRequiredService<DbConnectionStringBuilder>().ToString())
                .AddPostgres()
                .ScanIn(typeof(Dialogs).Assembly).For.Migrations())
            .AddLogging(x => x.AddFluentMigratorConsole());
    }

    public static void UpdateDatabase(this IServiceProvider serviceProvider) =>
        serviceProvider
            .GetRequiredService<IMigrationRunner>()
            .MigrateUp();
}