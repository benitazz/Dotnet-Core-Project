using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedDateTimeToVat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "VatTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "VatTypes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 581, DateTimeKind.Local).AddTicks(1708), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6251), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6270), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6539), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6547), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6551), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6555), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7402), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7475), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7483), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7575), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7591), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7595), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7806), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7876), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7879), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7883), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7887), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7891), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5731), new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5781), new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5785), new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8078), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8155), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8159), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8163), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8167), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8171), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(4385), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5070), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5082), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5086), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5086), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5090), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5093), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5095), new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5157), new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(4371), new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(4391), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 31, 23, 59, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate", "ValidFrom" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(5657), new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(5661), new DateTime(2018, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "VatTypes");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "VatTypes");

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
    }
}
