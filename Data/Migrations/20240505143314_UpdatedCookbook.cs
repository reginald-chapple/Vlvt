using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vlvt.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCookbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cookbooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cookbooks");
        }
    }
}
