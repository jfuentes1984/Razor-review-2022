using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Razor_review_2022.Migrations
{
    public partial class schoolRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "School");
        }
    }
}
