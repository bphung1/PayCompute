using Microsoft.EntityFrameworkCore.Migrations;

namespace PayCompute.Persistence.Migrations
{
    public partial class updatingmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NeyPayment",
                table: "PaymentRecords",
                newName: "NetPayment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NetPayment",
                table: "PaymentRecords",
                newName: "NeyPayment");
        }
    }
}
