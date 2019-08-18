using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class UpdatePractionerGroupType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 697, DateTimeKind.Local).AddTicks(2621), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5375), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5391), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5395), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5398), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5402), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5406), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4010), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4052), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4056), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4060), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4064), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4067), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7034), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7080), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7084), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7088), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8199), new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8222), new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8226), new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1414), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1452), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1456), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1456), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1460), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1464), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2287), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2879), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2891), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2899), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2902), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2926), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2926), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4876), new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4914), new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(6421), new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(8004), new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(8007) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 742, DateTimeKind.Local).AddTicks(9193), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8217), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8248), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8260), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8268), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8275), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8279), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7363), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7409), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7413), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7417), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7421), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7425), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3627), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3677), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3681), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3681), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3685), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3688), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8120), new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8170), new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8170), new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9473), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9538), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9546), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9550), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9550), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9554), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(2556), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3460), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3480), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3491), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3495), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3499), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3499), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3503), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3506), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6072), new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6114), new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(6376), new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(8077), new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(8081) });
        }
    }
}
