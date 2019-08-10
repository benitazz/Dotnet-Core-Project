using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class modifyItemDescription2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_PublicationTypes_PublicationTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemPublications_PublicationTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemId",
                table: "MedicalItemDescriptions");

            migrationBuilder.DropColumn(
                name: "PublicationTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.AddColumn<int>(
                name: "PublicationTypeId",
                table: "MedicalItemDescriptions",
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
                name: "IX_MedicalItemDescriptions_PublicationTypeId",
                table: "MedicalItemDescriptions",
                column: "PublicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemId_PublicationTypeId",
                table: "MedicalItemDescriptions",
                columns: new[] { "MedicalItemId", "PublicationTypeId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemDescriptions_PublicationTypes_PublicationTypeId",
                table: "MedicalItemDescriptions",
                column: "PublicationTypeId",
                principalTable: "PublicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemDescriptions_PublicationTypes_PublicationTypeId",
                table: "MedicalItemDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemDescriptions_PublicationTypeId",
                table: "MedicalItemDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemId_PublicationTypeId",
                table: "MedicalItemDescriptions");

            migrationBuilder.DropColumn(
                name: "PublicationTypeId",
                table: "MedicalItemDescriptions");

            migrationBuilder.AddColumn<int>(
                name: "PublicationTypeId",
                table: "MedicalItemPublications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 311, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublications_PublicationTypeId",
                table: "MedicalItemPublications",
                column: "PublicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemId",
                table: "MedicalItemDescriptions",
                column: "MedicalItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_PublicationTypes_PublicationTypeId",
                table: "MedicalItemPublications",
                column: "PublicationTypeId",
                principalTable: "PublicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
