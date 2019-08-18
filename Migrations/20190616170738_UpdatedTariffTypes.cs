using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class UpdatedTariffTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 37, 998, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local), "Coid Tariffs", "Coida", "COIDTARIFFS", "COIDA", new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local), "None Coid Tariffs", "NoneCoid", "NONECOIDTARIFFS", "NONECOID", new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 608, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Chiropractor Tariffs", "Chiropractor", "CHIROPRACTORTARIFFS", "CHIROPRACTOR", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Radiologists Tariffs", "Radiologist", "RADIOLOGISTSTARIFFS", "RADIOLOGIST", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TariffTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "Name", "NormalizedDescription", "NormalizedName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 9, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Wound Care Tariffs", false, "Wound Care", "WOUNDCARETARIFFS", "WOUNDCARE", "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) },
                    { 8, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Social Worker Tariffs", false, "Social Worker", "SOCIALWORKERTARIFFS", "SOCIALWORKER", "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) },
                    { 6, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "General Practioner Tariffs", false, "General Practioner", "GENERALPRACTIONERTARIFFS", "GENERALPRACTIONER", "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) },
                    { 5, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Private Ambulance Tariffs", false, "Private Ambulance", "PRIVATEAMBULANCETARIFFS", "PRIVATEAMBULANCE", "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) },
                    { 4, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Physiotherapist tariffs", false, "Physiotherapist", "PHYSIOTHERAPISTTARIFFS", "PHYSIOTHERAPIST", "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) },
                    { 3, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Dentists tarrifs", false, "Dentist", "DENTISTSTARRIFS", "DENTIST", "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) },
                    { 7, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), "Renal Care Tariffs", false, "Renal Care", "RENALCARETARIFFS", "RENALCARE", "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) }
                });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local) });
        }
    }
}
