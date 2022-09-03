using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrationandConfiguration.Migrations
{
    public partial class AddRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgrNo",
                table: "Not",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Not_OgrNo",
                table: "Not",
                column: "OgrNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Not_Ogrenci_OgrNo",
                table: "Not",
                column: "OgrNo",
                principalTable: "Ogrenci",
                principalColumn: "No",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Not_Ogrenci_OgrNo",
                table: "Not");

            migrationBuilder.DropIndex(
                name: "IX_Not_OgrNo",
                table: "Not");

            migrationBuilder.DropColumn(
                name: "OgrNo",
                table: "Not");
        }
    }
}
