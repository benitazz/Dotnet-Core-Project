using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedPractitionerType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 154, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 174, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 188, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 188, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 188, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 188, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 188, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 188, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 185, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 182, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 161, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 161, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 161, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 161, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 165, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 165, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 6, 51, 165, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 6, 51, 165, DateTimeKind.Local) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
