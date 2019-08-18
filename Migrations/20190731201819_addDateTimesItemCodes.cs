using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addDateTimesItemCodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ValiFrom",
                table: "MedicalItemPublications",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "MedicalItemPublications",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 793, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValiFrom",
                table: "MedicalItemPublications");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "MedicalItemPublications");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 169, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 211, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 211, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 211, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 208, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 178, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 178, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 182, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 12, 12, 182, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 12, 12, 182, DateTimeKind.Local) });
        }
    }
}
