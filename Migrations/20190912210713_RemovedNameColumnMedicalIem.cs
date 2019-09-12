using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RemovedNameColumnMedicalIem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MedicalItemPublications");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "MedicalItems",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalItemPublications",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "MedicalItems",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalItemPublications",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MedicalItemPublications",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 635, DateTimeKind.Local).AddTicks(1256), new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7761), new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7796), new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7799), new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7876), new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7888), new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7896), new DateTime(2019, 8, 31, 3, 15, 20, 637, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7252), new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7329), new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7340), new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7344), new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7352), new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7360), new DateTime(2019, 8, 31, 3, 15, 20, 645, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2030), new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2115), new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2119), new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2126), new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2126), new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2134), new DateTime(2019, 8, 31, 3, 15, 20, 693, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7018), new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7095), new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7099), new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7103), new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7107), new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7111), new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7114), new DateTime(2019, 8, 31, 3, 15, 20, 756, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9096), new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9166), new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9169), new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9173), new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9177), new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9181), new DateTime(2019, 8, 31, 3, 15, 20, 744, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(887), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2269), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2296), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2304), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2308), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2312), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2315), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2319), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2323), new DateTime(2019, 8, 31, 3, 15, 20, 734, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 651, DateTimeKind.Local).AddTicks(9050), new DateTime(2019, 8, 31, 3, 15, 20, 651, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 651, DateTimeKind.Local).AddTicks(9108), new DateTime(2019, 8, 31, 3, 15, 20, 651, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 662, DateTimeKind.Local).AddTicks(3224), new DateTime(2019, 8, 31, 3, 15, 20, 662, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 3, 15, 20, 662, DateTimeKind.Local).AddTicks(6089), new DateTime(2019, 8, 31, 3, 15, 20, 662, DateTimeKind.Local).AddTicks(6096) });
        }
    }
}
