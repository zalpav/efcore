using Microsoft.EntityFrameworkCore.Migrations;

namespace BankIS.MVC_WebApp.Migrations
{
    public partial class add_index : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Clients_LastName",
                table: "Clients",
                column: "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clients_LastName",
                table: "Clients");
        }
    }
}
