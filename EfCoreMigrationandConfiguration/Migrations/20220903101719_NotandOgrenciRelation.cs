using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrationandConfiguration.Migrations
{
    public partial class NotandOgrenciRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgrenciNo",
                table: "Not",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Not_OgrenciNo",
                table: "Not",
                column: "OgrenciNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Not_Ogrenci_OgrenciNo",
                table: "Not",
                column: "OgrenciNo",
                principalTable: "Ogrenci",
                principalColumn: "No",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Not_Ogrenci_OgrenciNo",
                table: "Not");

            migrationBuilder.DropIndex(
                name: "IX_Not_OgrenciNo",
                table: "Not");

            migrationBuilder.DropColumn(
                name: "OgrenciNo",
                table: "Not");
        }
    }
}
