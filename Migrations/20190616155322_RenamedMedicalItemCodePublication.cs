using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class RenamedMedicalItemCodePublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 154, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 232, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local) });
        }
    }
}
