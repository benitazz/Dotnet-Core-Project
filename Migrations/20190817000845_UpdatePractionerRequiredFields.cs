using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class UpdatePractionerRequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PracticeCode",
                table: "Practitioners",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NRPLPracticeCode",
                table: "Practitioners",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 138, DateTimeKind.Local).AddTicks(6636), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(752), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(771), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(775), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(779), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(783), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(787), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9523), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9566), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9569), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9573), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9577), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9693), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5153), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5199), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5203), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5203), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5207), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5211), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1252), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1283), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1283), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1286), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1294), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8538), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8569), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8572), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8572), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8576), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8580), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(3505), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4341), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4352), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4356), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4360), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4360), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4364), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6440), new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6467), new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(337), new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(1704), new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(1707) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PracticeCode",
                table: "Practitioners",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NRPLPracticeCode",
                table: "Practitioners",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 499, DateTimeKind.Local).AddTicks(9602), new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3603), new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3618), new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3626), new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3630), new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3630), new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3634), new DateTime(2019, 8, 17, 2, 3, 18, 501, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7711), new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7742), new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7745), new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7749), new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7749), new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7753), new DateTime(2019, 8, 17, 2, 3, 18, 504, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1035), new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1127), new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1146), new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1150), new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1154), new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1158), new DateTime(2019, 8, 17, 2, 3, 18, 524, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3807), new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3842), new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3846), new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3849), new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3849), new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3853), new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3853), new DateTime(2019, 8, 17, 2, 3, 18, 545, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8725), new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8763), new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8767), new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8767), new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8771), new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8775), new DateTime(2019, 8, 17, 2, 3, 18, 541, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(8782), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9502), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9517), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9521), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9521), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9525), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9525), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9529), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9533), new DateTime(2019, 8, 17, 2, 3, 18, 537, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 508, DateTimeKind.Local).AddTicks(5033), new DateTime(2019, 8, 17, 2, 3, 18, 508, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 508, DateTimeKind.Local).AddTicks(5075), new DateTime(2019, 8, 17, 2, 3, 18, 508, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 512, DateTimeKind.Local).AddTicks(7474), new DateTime(2019, 8, 17, 2, 3, 18, 512, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 3, 18, 512, DateTimeKind.Local).AddTicks(8926), new DateTime(2019, 8, 17, 2, 3, 18, 512, DateTimeKind.Local).AddTicks(8929) });
        }
    }
}
