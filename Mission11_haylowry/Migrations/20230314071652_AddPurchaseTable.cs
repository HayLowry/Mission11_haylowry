using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission11_haylowry.Migrations
{
    public partial class AddPurchaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Purchases",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Purchases");
        }
    }
}
