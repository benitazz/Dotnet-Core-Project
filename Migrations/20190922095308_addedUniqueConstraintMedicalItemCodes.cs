using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedUniqueConstraintMedicalItemCodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 186, DateTimeKind.Local).AddTicks(7274), new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(663), new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(683), new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(686), new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(690), new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(694), new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(694), new DateTime(2019, 9, 22, 11, 53, 6, 188, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6183), new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6222), new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6225), new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6229), new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6229), new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6233), new DateTime(2019, 9, 22, 11, 53, 6, 191, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5131), new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5208), new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5216), new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5220), new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5220), new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5235), new DateTime(2019, 9, 22, 11, 53, 6, 225, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(448), new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(502), new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(506), new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(506), new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(510), new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(510), new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(513), new DateTime(2019, 9, 22, 11, 53, 6, 253, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8629), new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8668), new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8668), new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8671), new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8675), new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8675), new DateTime(2019, 9, 22, 11, 53, 6, 248, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 194, DateTimeKind.Local).AddTicks(5052), new DateTime(2019, 9, 22, 11, 53, 6, 194, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 194, DateTimeKind.Local).AddTicks(5079), new DateTime(2019, 9, 22, 11, 53, 6, 194, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 198, DateTimeKind.Local).AddTicks(9788), new DateTime(2019, 9, 22, 11, 53, 6, 198, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 11, 53, 6, 199, DateTimeKind.Local).AddTicks(1036), new DateTime(2019, 9, 22, 11, 53, 6, 199, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItems_Code",
                table: "MedicalItems",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MedicalItems_Code",
                table: "MedicalItems");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 558, DateTimeKind.Local).AddTicks(8350), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5014), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5041), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5049), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5057), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5061), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5068), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6526), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6695), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6719), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6746), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6784), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6807), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(629), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(718), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(722), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(726), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(730), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(737), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9080), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9165), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9169), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9176), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9176), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9180), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9184), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1492), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1573), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1577), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1581), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1585), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1588), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1464), new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1530), new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(6966), new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(9923), new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(9931) });
        }
    }
}
