using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedGroupTypeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PractitionerGroupTypeId",
                table: "Practitioners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 165, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 166, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 170, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 211, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 211, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 211, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 207, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 194, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 203, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 172, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 172, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 172, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 172, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 178, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 31, 15, 178, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 31, 15, 178, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Practitioners_PractitionerGroupTypeId",
                table: "Practitioners",
                column: "PractitionerGroupTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Practitioners_PractitionerGroupTypes_PractitionerGroupTypeId",
                table: "Practitioners",
                column: "PractitionerGroupTypeId",
                principalTable: "PractitionerGroupTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Practitioners_PractitionerGroupTypes_PractitionerGroupTypeId",
                table: "Practitioners");

            migrationBuilder.DropIndex(
                name: "IX_Practitioners_PractitionerGroupTypeId",
                table: "Practitioners");

            migrationBuilder.DropColumn(
                name: "PractitionerGroupTypeId",
                table: "Practitioners");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 383, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 385, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 389, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 402, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 417, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 417, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 417, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 417, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 417, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 417, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 414, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 411, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 392, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 392, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 392, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 392, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 395, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 395, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 28, 9, 395, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 28, 9, 395, DateTimeKind.Local) });
        }
    }
}
