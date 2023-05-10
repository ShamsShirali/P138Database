using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P138Database.Migrations
{
    public partial class CreatedModelTable_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Model_MarkaId",
                table: "Model",
                column: "MarkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Markas_MarkaId",
                table: "Model",
                column: "MarkaId",
                principalTable: "Markas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Markas_MarkaId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_MarkaId",
                table: "Model");
        }
    }
}
