using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedDosageTypeIdToNappiCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DosageFrom",
                table: "NappiCodeTypes");

            migrationBuilder.AddColumn<int>(
                name: "DosageTypeId",
                table: "NappiCodeTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 410, DateTimeKind.Local).AddTicks(7442), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1566), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1582), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1585), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1593), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1593), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1597), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7445), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7476), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7480), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7483), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7487), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7487), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9593), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9639), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9643), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9647), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3139), new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3166), new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3170), new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3940), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3986), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(6553), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7211), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7222), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7230), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7230), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7234), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7238), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7356), new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7394), new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(6697), new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(7959), new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.CreateIndex(
                name: "IX_NappiCodeTypes_DosageTypeId",
                table: "NappiCodeTypes",
                column: "DosageTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_NappiCodeTypes_DosageTypes_DosageTypeId",
                table: "NappiCodeTypes",
                column: "DosageTypeId",
                principalTable: "DosageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NappiCodeTypes_DosageTypes_DosageTypeId",
                table: "NappiCodeTypes");

            migrationBuilder.DropIndex(
                name: "IX_NappiCodeTypes_DosageTypeId",
                table: "NappiCodeTypes");

            migrationBuilder.DropColumn(
                name: "DosageTypeId",
                table: "NappiCodeTypes");

            migrationBuilder.AddColumn<string>(
                name: "DosageFrom",
                table: "NappiCodeTypes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 646, DateTimeKind.Local).AddTicks(7042), new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(620), new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(639), new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(643), new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(647), new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(647), new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(650), new DateTime(2019, 8, 11, 16, 55, 35, 648, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8712), new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8758), new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8762), new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8770), new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8773), new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8777), new DateTime(2019, 8, 11, 16, 55, 35, 651, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5151), new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5201), new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5205), new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5205), new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5209), new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5209), new DateTime(2019, 8, 11, 16, 55, 35, 672, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 695, DateTimeKind.Local).AddTicks(2006), new DateTime(2019, 8, 11, 16, 55, 35, 695, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 695, DateTimeKind.Local).AddTicks(2049), new DateTime(2019, 8, 11, 16, 55, 35, 695, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 695, DateTimeKind.Local).AddTicks(2052), new DateTime(2019, 8, 11, 16, 55, 35, 695, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8918), new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8976), new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8980), new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8984), new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8984), new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8987), new DateTime(2019, 8, 11, 16, 55, 35, 691, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2008), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2662), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2674), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2678), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2682), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2685), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2689), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2689), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2693), new DateTime(2019, 8, 11, 16, 55, 35, 688, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 655, DateTimeKind.Local).AddTicks(8082), new DateTime(2019, 8, 11, 16, 55, 35, 655, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 655, DateTimeKind.Local).AddTicks(8136), new DateTime(2019, 8, 11, 16, 55, 35, 655, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 661, DateTimeKind.Local).AddTicks(7932), new DateTime(2019, 8, 11, 16, 55, 35, 661, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 55, 35, 661, DateTimeKind.Local).AddTicks(9191), new DateTime(2019, 8, 11, 16, 55, 35, 661, DateTimeKind.Local).AddTicks(9195) });
        }
    }
}
