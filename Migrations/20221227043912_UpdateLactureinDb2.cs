using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoTutorial.Repository.Migrations
{
    public partial class UpdateLactureinDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Lactures",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Lactures_ApplicationUserId",
                table: "Lactures",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lactures_AspNetUsers_ApplicationUserId",
                table: "Lactures",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lactures_AspNetUsers_ApplicationUserId",
                table: "Lactures");

            migrationBuilder.DropIndex(
                name: "IX_Lactures_ApplicationUserId",
                table: "Lactures");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Lactures");
        }
    }
}
