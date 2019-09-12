using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedUnitPriceAndTBUCTypeIdInTBUC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActualAmount",
                table: "TariffBaseUnitCosts",
                newName: "UnitPrice");

            migrationBuilder.AddColumn<int>(
                name: "TariffBaseUnitCostTypeId",
                table: "TariffBaseUnitCosts",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_TariffBaseUnitCosts_TariffBaseUnitCostTypeId",
                table: "TariffBaseUnitCosts",
                column: "TariffBaseUnitCostTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TariffBaseUnitCosts_TariffBaseUnitCostTypes_TariffBaseUnitCostTypeId",
                table: "TariffBaseUnitCosts",
                column: "TariffBaseUnitCostTypeId",
                principalTable: "TariffBaseUnitCostTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TariffBaseUnitCosts_TariffBaseUnitCostTypes_TariffBaseUnitCostTypeId",
                table: "TariffBaseUnitCosts");

            migrationBuilder.DropIndex(
                name: "IX_TariffBaseUnitCosts_TariffBaseUnitCostTypeId",
                table: "TariffBaseUnitCosts");

            migrationBuilder.DropColumn(
                name: "TariffBaseUnitCostTypeId",
                table: "TariffBaseUnitCosts");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "TariffBaseUnitCosts",
                newName: "ActualAmount");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 680, DateTimeKind.Local).AddTicks(2463), new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8497), new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8540), new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8551), new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8590), new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8613), new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8636), new DateTime(2019, 8, 31, 2, 36, 21, 684, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6397), new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6455), new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6463), new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6470), new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6474), new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6482), new DateTime(2019, 8, 31, 2, 36, 21, 694, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9641), new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9722), new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9730), new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9734), new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9738), new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9742), new DateTime(2019, 8, 31, 2, 36, 21, 746, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(3938), new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4011), new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4015), new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4019), new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4023), new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4027), new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4031), new DateTime(2019, 8, 31, 2, 36, 21, 808, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7483), new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7575), new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7579), new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7583), new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7587), new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7591), new DateTime(2019, 8, 31, 2, 36, 21, 799, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(8499), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9761), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9781), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9788), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9792), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9796), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9800), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9804), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9808), new DateTime(2019, 8, 31, 2, 36, 21, 784, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 710, DateTimeKind.Local).AddTicks(8970), new DateTime(2019, 8, 31, 2, 36, 21, 710, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 710, DateTimeKind.Local).AddTicks(9036), new DateTime(2019, 8, 31, 2, 36, 21, 710, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 720, DateTimeKind.Local).AddTicks(6408), new DateTime(2019, 8, 31, 2, 36, 21, 720, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 31, 2, 36, 21, 720, DateTimeKind.Local).AddTicks(8121), new DateTime(2019, 8, 31, 2, 36, 21, 720, DateTimeKind.Local).AddTicks(8125) });
        }
    }
}
