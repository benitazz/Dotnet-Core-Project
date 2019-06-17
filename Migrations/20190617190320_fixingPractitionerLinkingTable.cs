using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class fixingPractitionerLinkingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PractitionerPractitionerTypes_PractitionerTypes_PractitionerTypeId",
                table: "PractitionerPractitionerTypes");

            migrationBuilder.DropIndex(
                name: "IX_PractitionerPractitionerTypes_PractitionerTypeId",
                table: "PractitionerPractitionerTypes");

            migrationBuilder.DropColumn(
                name: "PractionerTypeId",
                table: "PractitionerPractitionerTypes");

            migrationBuilder.DropColumn(
                name: "PractitionerTypeId",
                table: "PractitionerPractitionerTypes");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 554, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 591, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 591, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 591, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 591, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 591, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 591, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 588, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 584, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 561, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 561, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 567, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 567, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 3, 19, 567, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 3, 19, 567, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PractionerTypeId",
                table: "PractitionerPractitionerTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PractitionerTypeId",
                table: "PractitionerPractitionerTypes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 637, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 642, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 655, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 670, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 670, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 670, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 670, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 670, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 670, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 667, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 664, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 645, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 645, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 645, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 645, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 649, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 649, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 53, 56, 649, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 53, 56, 649, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_PractitionerPractitionerTypes_PractitionerTypeId",
                table: "PractitionerPractitionerTypes",
                column: "PractitionerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PractitionerPractitionerTypes_PractitionerTypes_PractitionerTypeId",
                table: "PractitionerPractitionerTypes",
                column: "PractitionerTypeId",
                principalTable: "PractitionerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
