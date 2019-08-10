using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class CleanMedicalItemPublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_MedicalItemDescriptions_MedicalItemDescriptionId",
                table: "MedicalItemPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_SectionTypes_SectionTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemPublications_MedicalItemDescriptionId",
                table: "MedicalItemPublications");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemPublications_SectionTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropColumn(
                name: "SectionTypeId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionTypeId",
                table: "MedicalItemPublications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 922, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 924, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 927, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 956, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 956, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 956, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 956, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 956, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 956, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 953, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 949, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 949, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 950, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 929, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 929, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 929, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 929, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 933, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 933, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 46, 28, 933, DateTimeKind.Local), new DateTime(2019, 7, 28, 20, 46, 28, 933, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublications_MedicalItemDescriptionId",
                table: "MedicalItemPublications",
                column: "MedicalItemDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublications_SectionTypeId",
                table: "MedicalItemPublications",
                column: "SectionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_MedicalItemDescriptions_MedicalItemDescriptionId",
                table: "MedicalItemPublications",
                column: "MedicalItemDescriptionId",
                principalTable: "MedicalItemDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_SectionTypes_SectionTypeId",
                table: "MedicalItemPublications",
                column: "SectionTypeId",
                principalTable: "SectionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
