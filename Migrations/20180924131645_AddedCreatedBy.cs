using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedCreatedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "InvoiceStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "InvoiceStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "FileStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "FileStatuses",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GetDate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "InvoiceStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "InvoiceStatuses");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "InvoiceStatuses");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "InvoiceStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FileStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "FileStatuses");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "FileStatuses");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "FileStatuses");

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
    }
}
