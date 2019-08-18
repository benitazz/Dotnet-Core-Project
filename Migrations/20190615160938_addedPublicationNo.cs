using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedPublicationNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicationNo",
                table: "Publications",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PublicationNo", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local), "11111", new DateTime(2019, 6, 15, 18, 9, 37, 467, DateTimeKind.Local) });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicationNo",
                table: "Publications");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 175, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 180, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 200, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 191, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 191, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 55, 26, 191, DateTimeKind.Local), new DateTime(2019, 6, 15, 17, 55, 26, 191, DateTimeKind.Local) });
        }
    }
}
