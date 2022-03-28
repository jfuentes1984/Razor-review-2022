using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Razor_review_2022.Migrations
{
    public partial class schoolVerifyPass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "School",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "School");
        }
    }
}
