using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RemovedValidFrom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "ValidTo",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "Publications",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "Publications",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 325, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 326, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local) });
        }
    }
}
