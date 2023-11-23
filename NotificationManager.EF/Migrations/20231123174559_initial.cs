using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotificationManager.EF.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TitleEN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    TextEN = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ProductInclude = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProductExclude = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ModuleInclude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModuleExclude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
