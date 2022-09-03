using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrationandConfiguration.Migrations
{
    public partial class OgrenciTelColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelNo",
                table: "Ogrenci",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelNo",
                table: "Ogrenci");
        }
    }
}
