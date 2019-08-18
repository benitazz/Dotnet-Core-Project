using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class dateTime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "InvoiceStatuses",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InvoiceStatuses",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "FileStatuses",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FileStatuses",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.InsertData(
                table: "FileStatuses",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), "Successfully uploaded the file", "Uploaded", "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) },
                    { 2, "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), "The manager rejected the file", "Rejected", "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) },
                    { 3, "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), "Ready to submit to the Fund", "Approved", "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) },
                    { 4, "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), "File successfully submitted to the Fund", "Submitted", "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) },
                    { 5, "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), "Not all invoices were paid", "Partially Paid", "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) },
                    { 6, "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), "All invoices were successfully paid", "Paid", "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) },
                    { 7, "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc), "File Overdue", "Overdue", "Administrator", new DateTime(2018, 9, 25, 3, 50, 45, 621, DateTimeKind.Utc) }
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

            migrationBuilder.DeleteData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "InvoiceStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InvoiceStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "FileStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FileStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");
        }
    }
}
