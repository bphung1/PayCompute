using Microsoft.EntityFrameworkCore.Migrations;

namespace PayCompute.Persistence.Migrations
{
    public partial class updatingmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TaxYears",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NiNo",
                table: "PaymentRecords",
                newName: "SSN");

            migrationBuilder.RenameColumn(
                name: "NIC",
                table: "PaymentRecords",
                newName: "SocialSecurity");

            migrationBuilder.RenameColumn(
                name: "NationalInsuranceNo",
                table: "Employees",
                newName: "SocialSecurity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TaxYears",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SocialSecurity",
                table: "PaymentRecords",
                newName: "NIC");

            migrationBuilder.RenameColumn(
                name: "SSN",
                table: "PaymentRecords",
                newName: "NiNo");

            migrationBuilder.RenameColumn(
                name: "SocialSecurity",
                table: "Employees",
                newName: "NationalInsuranceNo");
        }
    }
}
