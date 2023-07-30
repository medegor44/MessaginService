using System.Data.SqlServerCe;
using FluentMigrator;

namespace SocialNetwork.Migrations.Migrations;

[Migration(1)]
public class Dialogs : Migration 
{
    public override void Up()
    {
        Create.Table("Dialogs")
            .WithColumn("From").AsInt64()
            .WithColumn("To").AsInt64()
            .WithColumn("CreateDate").AsDateTimeOffset()
            .WithColumn("Text").AsString();
    }

    public override void Down()
    {
        Delete.Table("Dialogs");
    }
}