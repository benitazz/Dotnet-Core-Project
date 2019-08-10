using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedQuantityMedicalItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "MedicalItemPublications",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 799, DateTimeKind.Local).AddTicks(808), new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3466), new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3481), new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3485), new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3489), new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3493), new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3497), new DateTime(2019, 8, 10, 12, 37, 56, 800, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8012), new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8051), new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8054), new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8054), new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8093), new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8097), new DateTime(2019, 8, 10, 12, 37, 56, 803, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6763), new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6802), new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6806), new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6810), new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6810), new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6813), new DateTime(2019, 8, 10, 12, 37, 56, 819, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 836, DateTimeKind.Local).AddTicks(3332), new DateTime(2019, 8, 10, 12, 37, 56, 836, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 836, DateTimeKind.Local).AddTicks(3363), new DateTime(2019, 8, 10, 12, 37, 56, 836, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 836, DateTimeKind.Local).AddTicks(3367), new DateTime(2019, 8, 10, 12, 37, 56, 836, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4348), new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4379), new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4383), new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4387), new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4387), new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4391), new DateTime(2019, 8, 10, 12, 37, 56, 833, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(810), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1457), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1469), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1473), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1476), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1476), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1480), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1480), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1484), new DateTime(2019, 8, 10, 12, 37, 56, 830, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 806, DateTimeKind.Local).AddTicks(8566), new DateTime(2019, 8, 10, 12, 37, 56, 806, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 806, DateTimeKind.Local).AddTicks(8601), new DateTime(2019, 8, 10, 12, 37, 56, 806, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 810, DateTimeKind.Local).AddTicks(9746), new DateTime(2019, 8, 10, 12, 37, 56, 810, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 37, 56, 810, DateTimeKind.Local).AddTicks(9788), new DateTime(2019, 8, 10, 12, 37, 56, 810, DateTimeKind.Local).AddTicks(9788) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "MedicalItemPublications");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 676, DateTimeKind.Local).AddTicks(4933), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8976), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8996), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9000), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9003), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9007), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9011), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5344), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5386), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5390), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5394), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5397), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5397), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5485), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5531), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5535), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5542), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2753), new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2792), new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2796), new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9369), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9411), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9415), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9423), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6353), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6965), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6977), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6981), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6989), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6989), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6992), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(318), new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(357), new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(465), new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(500), new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(500) });
        }
    }
}
