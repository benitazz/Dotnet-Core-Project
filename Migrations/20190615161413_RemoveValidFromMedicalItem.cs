using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RemoveValidFromMedicalItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_Publications_PublicationId",
                table: "MedicalItems");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItems_PublicationId",
                table: "MedicalItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MedicalItems");

            migrationBuilder.DropColumn(
                name: "PublicationId",
                table: "MedicalItems");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "MedicalItems");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "MedicalItems");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 702, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MedicalItems",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublicationId",
                table: "MedicalItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "MedicalItems",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "MedicalItems",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 446, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 451, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 456, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 460, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 460, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 9, 37, 460, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItems_PublicationId",
                table: "MedicalItems",
                column: "PublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_Publications_PublicationId",
                table: "MedicalItems",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
