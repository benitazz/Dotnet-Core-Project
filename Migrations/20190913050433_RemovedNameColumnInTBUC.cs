using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RemovedNameColumnInTBUC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TariffBaseUnitCosts");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TariffBaseUnitCosts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDescription",
                table: "TariffBaseUnitCosts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 143, DateTimeKind.Local).AddTicks(4188), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7116), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7135), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7139), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7143), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7147), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7150), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4687), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4718), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4722), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4726), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4730), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4734), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1007), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1057), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1061), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1061), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1065), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1069), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9319), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9358), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9362), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9369), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9396), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1804), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1839), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1843), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1850), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3012), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3628), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3639), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3643), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3647), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3655), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3655), new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1643), new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1666), new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(3789), new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(5113), new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(5117) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalizedDescription",
                table: "TariffBaseUnitCosts");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TariffBaseUnitCosts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TariffBaseUnitCosts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 961, DateTimeKind.Local).AddTicks(2461), new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9334), new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9364), new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9372), new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9380), new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9388), new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9395), new DateTime(2019, 9, 12, 23, 7, 11, 962, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1259), new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1313), new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1317), new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1321), new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1321), new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1325), new DateTime(2019, 9, 12, 23, 7, 11, 969, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6105), new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6352), new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6364), new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6371), new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6375), new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6379), new DateTime(2019, 9, 12, 23, 7, 11, 998, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9866), new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9908), new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9912), new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9912), new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9916), new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9920), new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9920), new DateTime(2019, 9, 12, 23, 7, 12, 38, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(3930), new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4038), new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4045), new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4065), new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4080), new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4088), new DateTime(2019, 9, 12, 23, 7, 12, 32, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(902), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1895), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1976), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1984), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1988), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1988), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1991), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1995), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1999), new DateTime(2019, 9, 12, 23, 7, 12, 25, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 974, DateTimeKind.Local).AddTicks(2394), new DateTime(2019, 9, 12, 23, 7, 11, 974, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 974, DateTimeKind.Local).AddTicks(2459), new DateTime(2019, 9, 12, 23, 7, 11, 974, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 980, DateTimeKind.Local).AddTicks(3869), new DateTime(2019, 9, 12, 23, 7, 11, 980, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 12, 23, 7, 11, 980, DateTimeKind.Local).AddTicks(8172), new DateTime(2019, 9, 12, 23, 7, 11, 980, DateTimeKind.Local).AddTicks(8180) });
        }
    }
}
