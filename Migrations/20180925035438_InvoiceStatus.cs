using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class InvoiceStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 174, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "InvoiceStatuses",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), "Pending", "Pending", "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), "Approved", "Approved", "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                    { 3, "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), "Payment rejected", "Rejected", "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                    { 4, "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), "Invoice submitted to the fund", "Submitted", "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                    { 5, "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), "Invoice paid", "Paid", "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                    { 6, "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), "Invoice Overdue", "Overdue", "Administrator", new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) }
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

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) });
        }
    }
}
