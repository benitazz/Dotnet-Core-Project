using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedDefaultValueForQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "MedicalItemPublications",
                nullable: false,
                defaultValue: 1.0,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 889, DateTimeKind.Local).AddTicks(8004), new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(974), new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(993), new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(997), new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(1001), new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(1005), new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(1008), new DateTime(2019, 9, 19, 3, 36, 16, 891, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5763), new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5794), new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5798), new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5802), new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5805), new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5805), new DateTime(2019, 9, 19, 3, 36, 16, 894, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3107), new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3157), new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3161), new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3164), new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3164), new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3168), new DateTime(2019, 9, 19, 3, 36, 16, 911, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8058), new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8085), new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8089), new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8089), new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8092), new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8096), new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8096), new DateTime(2019, 9, 19, 3, 36, 16, 935, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4805), new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4851), new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4855), new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4859), new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4859), new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4863), new DateTime(2019, 9, 19, 3, 36, 16, 932, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 897, DateTimeKind.Local).AddTicks(2349), new DateTime(2019, 9, 19, 3, 36, 16, 897, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 897, DateTimeKind.Local).AddTicks(2372), new DateTime(2019, 9, 19, 3, 36, 16, 897, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 901, DateTimeKind.Local).AddTicks(2200), new DateTime(2019, 9, 19, 3, 36, 16, 901, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 3, 36, 16, 901, DateTimeKind.Local).AddTicks(3475), new DateTime(2019, 9, 19, 3, 36, 16, 901, DateTimeKind.Local).AddTicks(3482) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "MedicalItemPublications",
                nullable: false,
                oldClrType: typeof(double),
                oldDefaultValue: 1.0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 172, DateTimeKind.Local).AddTicks(7610), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5887), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5918), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5922), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5934), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5941), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5945), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2473), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2519), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2523), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2527), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2531), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2534), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6190), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6248), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6252), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6255), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1593), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1655), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1659), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1663), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1666), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1666), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1670), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5195), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5233), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5237), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5241), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1769), new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1800), new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(6065), new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(7959), new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(7966) });
        }
    }
}
