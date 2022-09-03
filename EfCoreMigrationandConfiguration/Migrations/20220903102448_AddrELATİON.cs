using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrationandConfiguration.Migrations
{
    public partial class AddrELATİON : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Not_Ogrenci_OgrNo",
                table: "Not");

            migrationBuilder.RenameColumn(
                name: "OgrNo",
                table: "Not",
                newName: "OgrenciId");

            migrationBuilder.RenameIndex(
                name: "IX_Not_OgrNo",
                table: "Not",
                newName: "IX_Not_OgrenciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Not_Ogrenci_OgrenciId",
                table: "Not",
                column: "OgrenciId",
                principalTable: "Ogrenci",
                principalColumn: "No",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Not_Ogrenci_OgrenciId",
                table: "Not");

            migrationBuilder.RenameColumn(
                name: "OgrenciId",
                table: "Not",
                newName: "OgrNo");

            migrationBuilder.RenameIndex(
                name: "IX_Not_OgrenciId",
                table: "Not",
                newName: "IX_Not_OgrNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Not_Ogrenci_OgrNo",
                table: "Not",
                column: "OgrNo",
                principalTable: "Ogrenci",
                principalColumn: "No",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
