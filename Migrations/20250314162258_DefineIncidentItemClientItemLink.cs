using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IncidentBook.Migrations
{
    /// <inheritdoc />
    public partial class DefineIncidentItemClientItemLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_Client",
                table: "TodoItems",
                column: "Client");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_ClientItems_Client",
                table: "TodoItems",
                column: "Client",
                principalTable: "ClientItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_ClientItems_Client",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_Client",
                table: "TodoItems");
        }
    }
}
