using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addForeignPublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MedicalItemDescriptionId",
                table: "MedicalItemPublicationPeriods",
                newName: "MedicalItemPublicationId");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 112, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublicationPeriods_MedicalItemPublicationId",
                table: "MedicalItemPublicationPeriods",
                column: "MedicalItemPublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublicationPeriods_MedicalItemPublications_MedicalItemPublicationId",
                table: "MedicalItemPublicationPeriods",
                column: "MedicalItemPublicationId",
                principalTable: "MedicalItemPublications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublicationPeriods_MedicalItemPublications_MedicalItemPublicationId",
                table: "MedicalItemPublicationPeriods");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemPublicationPeriods_MedicalItemPublicationId",
                table: "MedicalItemPublicationPeriods");

            migrationBuilder.RenameColumn(
                name: "MedicalItemPublicationId",
                table: "MedicalItemPublicationPeriods",
                newName: "MedicalItemDescriptionId");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 261, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local) });
        }
    }
}
