using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrationandConfiguration.Migrations
{
    public partial class NotTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Vize",
                table: "Not",
                type: "decimal(38,17)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Final",
                table: "Not",
                type: "decimal(38,17)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Vize",
                table: "Not",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,17)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Final",
                table: "Not",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,17)",
                oldNullable: true);
        }
    }
}
