using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedDosageTypeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DosageTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 1, "ZZZ", "ZZZ", "ZZZ", "ZZZ" });

            migrationBuilder.InsertData(
                table: "DosageTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 3, "PLA", "PLA", "PLA", "PLA" });

            migrationBuilder.InsertData(
                table: "DosageTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 2, "GAU", "GAU", "GAU", "GAU" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DosageTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DosageTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DosageTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 334, DateTimeKind.Local).AddTicks(6561), new DateTime(2019, 8, 11, 16, 51, 13, 335, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(565), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(585), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(592), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(596), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(600), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(604), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1776), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1830), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1838), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1842), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1849), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1857), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8909), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8971), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8974), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8978), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8982), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8986), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3855), new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3905), new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3909), new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6220), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6266), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6270), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6274), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6274), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6277), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(1936), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2791), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2810), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2814), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2818), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2822), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2825), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2825), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2829), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3712), new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3747), new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 347, DateTimeKind.Local).AddTicks(8949), new DateTime(2019, 8, 11, 16, 51, 13, 347, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 348, DateTimeKind.Local).AddTicks(185), new DateTime(2019, 8, 11, 16, 51, 13, 348, DateTimeKind.Local).AddTicks(189) });
        }
    }
}
