using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class seedInvoiceStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InvoiceStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Pending", "Pending" },
                    { 2, "Approved", "Approved" },
                    { 3, "Payment rejected", "Rejected" },
                    { 4, "Invoice submitted to the fund", "Submitted" },
                    { 5, "Invoice paid", "Paid" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
