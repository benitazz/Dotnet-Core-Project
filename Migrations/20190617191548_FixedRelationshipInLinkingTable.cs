using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class FixedRelationshipInLinkingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PractitionerPractitionerTypes_PractitionerTypes_PractitionerTypeId",
                table: "PractitionerPractitionerTypes");

            migrationBuilder.DropColumn(
                name: "PractionerTypeId",
                table: "PractitionerPractitionerTypes");

            migrationBuilder.AlterColumn<int>(
                name: "PractitionerTypeId",
                table: "PractitionerPractitionerTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 226, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_PractitionerPractitionerTypes_PractitionerTypes_PractitionerTypeId",
                table: "PractitionerPractitionerTypes",
                column: "PractitionerTypeId",
                principalTable: "PractitionerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PractitionerPractitionerTypes_PractitionerTypes_PractitionerTypeId",
                table: "PractitionerPractitionerTypes");

            migrationBuilder.AlterColumn<int>(
                name: "PractitionerTypeId",
                table: "PractitionerPractitionerTypes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PractionerTypeId",
                table: "PractitionerPractitionerTypes",
                nullable: false,
                defaultValue: 0);

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
