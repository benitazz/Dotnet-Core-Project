using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class UpdatePractionerMedicalReportToAllowNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsMedReportRequired",
                table: "Practitioners",
                nullable: true,
                oldClrType: typeof(bool));

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

            migrationBuilder.CreateIndex(
                name: "IX_Practitioners_Name",
                table: "Practitioners",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Practitioners_Name",
                table: "Practitioners");

            migrationBuilder.AlterColumn<bool>(
                name: "IsMedReportRequired",
                table: "Practitioners",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 365, DateTimeKind.Local).AddTicks(8906), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2691), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2706), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2710), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2714), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2718), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2721), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2719), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2769), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2777), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2781), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2784), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2792), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2469), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2535), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2539), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2539), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2543), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2546), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4579), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4610), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4614), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4618), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4618), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4622), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4625), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9375), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9409), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9413), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9413), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9417), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9421), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(7468), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8484), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8503), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8515), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8518), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8522), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8526), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8534), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8534), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5233), new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5279), new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(6349), new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(7608), new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(7616) });
        }
    }
}
