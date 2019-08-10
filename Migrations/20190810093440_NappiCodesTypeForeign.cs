using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class NappiCodesTypeForeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NappiCodeTypeId",
                table: "MedicalItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 931, DateTimeKind.Local).AddTicks(2092), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9697), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9727), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9731), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9739), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9747), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9750), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7401), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7439), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7443), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7443), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7447), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7451), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7804), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7850), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7850), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7854), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7857), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7857), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(993), new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1028), new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1032), new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3459), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3502), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3509), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3509), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3513), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3517), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(2375), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3237), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3256), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3264), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3268), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3272), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3276), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3279), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3279), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2936), new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2967), new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4053), new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4096), new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItems_NappiCodeTypeId",
                table: "MedicalItems",
                column: "NappiCodeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_NappiCodeTypes_NappiCodeTypeId",
                table: "MedicalItems",
                column: "NappiCodeTypeId",
                principalTable: "NappiCodeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_NappiCodeTypes_NappiCodeTypeId",
                table: "MedicalItems");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItems_NappiCodeTypeId",
                table: "MedicalItems");

            migrationBuilder.DropColumn(
                name: "NappiCodeTypeId",
                table: "MedicalItems");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 489, DateTimeKind.Local).AddTicks(889), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5226), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5245), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5249), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5256), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5256), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5264), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4745), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4780), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4784), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4784), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4788), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4792), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9063), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9113), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9120), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9124), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9282), new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9305), new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9309), new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4024), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4063), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4067), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4070), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4070), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4074), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(6459), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7099), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7110), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7114), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7118), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7118), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7122), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7125), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7125), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9449), new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9472), new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2561), new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2618), new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2622) });
        }
    }
}
