using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedManufactureData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 307, DateTimeKind.Local).AddTicks(6125), new DateTime(2019, 8, 11, 14, 51, 12, 308, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(607), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(634), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(642), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(646), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(650), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(657), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1467), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1510), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1510), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1513), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1517), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1521), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.InsertData(
                table: "ManufactureTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 2, "MGP", "MGP", "MGP", "MGP" });

            migrationBuilder.InsertData(
                table: "ManufactureTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 1, "AMW", "AMW", "AMW", "AMW" });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(812), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(858), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(862), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(866), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(866), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(870), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2412), new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2454), new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2454), new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7449), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7604), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7608), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7611), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7615), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7619), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(1976), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2831), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2850), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2858), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2862), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2866), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2869), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2873), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2877), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2018), new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2057), new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(3484), new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(4746), new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(4750) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 863, DateTimeKind.Local).AddTicks(1667), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8837), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8856), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8860), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8864), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8867), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8871), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7189), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7254), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7266), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7274), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7281), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7285), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4570), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4616), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4620), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4624), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4628), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4631), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(946), new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(973), new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(977), new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1439), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1482), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1486), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1493), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(291), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(949), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(964), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(968), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(968), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(972), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(976), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(976), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(980), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6132), new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6167), new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(1908), new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(3170), new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(3174) });
        }
    }
}
