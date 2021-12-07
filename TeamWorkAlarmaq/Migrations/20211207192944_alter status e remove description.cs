using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamWorkAlarmaq.Migrations
{
    public partial class alterstatuseremovedescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Todos");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Todos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
