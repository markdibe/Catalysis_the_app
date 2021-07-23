using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalysis_the_app.DAL.Migrations
{
    public partial class update__course__model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CoursePrice",
                table: "courses",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "courses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoursePrice",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "courses");
        }
    }
}
