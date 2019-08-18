using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class renamedTableToPublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 81, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 698, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local) });
        }
    }
}
