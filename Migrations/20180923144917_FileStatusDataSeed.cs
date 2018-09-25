using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class FileStatusDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FileStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Successfully uploaded the file", "Uploaded" },
                    { 2, "The manager rejected the file", "Rejected" },
                    { 3, "Ready to submit to the Fund", "Approved" },
                    { 4, "File successfully submitted to the Fund", "Submitted" },
                    { 5, "Not all invoices were paid", "Partially Paid" },
                    { 6, "All invoices were successfully paid", "Paid" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
