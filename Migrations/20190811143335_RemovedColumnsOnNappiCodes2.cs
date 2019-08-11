using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class RemovedColumnsOnNappiCodes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturerCode",
                table: "NappiCodeTypes");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "NappiCodeTypes");

            migrationBuilder.DropColumn(
                name: "ProductPackSize",
                table: "NappiCodeTypes");

            migrationBuilder.DropColumn(
                name: "ProductStrength",
                table: "NappiCodeTypes");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "NappiCodeTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 713, DateTimeKind.Local).AddTicks(7030), new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2471), new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2486), new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2494), new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2498), new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2501), new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2505), new DateTime(2019, 8, 11, 16, 33, 34, 715, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(563), new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(609), new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(613), new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(621), new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(625), new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(629), new DateTime(2019, 8, 11, 16, 33, 34, 719, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "Unknown", "Unknown", "UNKNOWN", "UNKNOWN" });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "AMW", "AMW", "AMW", "AMW" });

            migrationBuilder.InsertData(
                table: "ManufactureTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 3, "MGP", "MGP", "MGP", "MGP" });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9763), new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9805), new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9809), new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9813), new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9813), new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9817), new DateTime(2019, 8, 11, 16, 33, 34, 736, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 758, DateTimeKind.Local).AddTicks(8613), new DateTime(2019, 8, 11, 16, 33, 34, 758, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 758, DateTimeKind.Local).AddTicks(8648), new DateTime(2019, 8, 11, 16, 33, 34, 758, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 758, DateTimeKind.Local).AddTicks(8652), new DateTime(2019, 8, 11, 16, 33, 34, 758, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8413), new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8448), new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8451), new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8455), new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8455), new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8459), new DateTime(2019, 8, 11, 16, 33, 34, 755, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PackSize",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(8154), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9151), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9182), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9209), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9209), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9213), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9216), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9220), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9224), new DateTime(2019, 8, 11, 16, 33, 34, 751, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 722, DateTimeKind.Local).AddTicks(3754), new DateTime(2019, 8, 11, 16, 33, 34, 722, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 722, DateTimeKind.Local).AddTicks(3793), new DateTime(2019, 8, 11, 16, 33, 34, 722, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 727, DateTimeKind.Local).AddTicks(1105), new DateTime(2019, 8, 11, 16, 33, 34, 727, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 33, 34, 727, DateTimeKind.Local).AddTicks(2537), new DateTime(2019, 8, 11, 16, 33, 34, 727, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManufactureTypeId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_NappiCodeTypes_ProductId",
                table: "NappiCodeTypes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_NappiCodeTypes_Products_ProductId",
                table: "NappiCodeTypes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NappiCodeTypes_Products_ProductId",
                table: "NappiCodeTypes");

            migrationBuilder.DropIndex(
                name: "IX_NappiCodeTypes_ProductId",
                table: "NappiCodeTypes");

            migrationBuilder.DeleteData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "NappiCodeTypes");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerCode",
                table: "NappiCodeTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "NappiCodeTypes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductPackSize",
                table: "NappiCodeTypes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductStrength",
                table: "NappiCodeTypes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 324, DateTimeKind.Local).AddTicks(2883), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5898), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5944), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5952), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5956), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5964), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5971), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9180), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9219), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9223), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9226), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9230), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9234), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "AMW", "AMW", "AMW", "AMW" });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "MGP", "MGP", "MGP", "MGP" });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5248), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5298), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5302), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5309), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1087), new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1121), new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1125), new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9489), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9531), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9539), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9539), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PackSize",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(4517), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5153), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5164), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5168), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5172), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5172), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5176), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(142), new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(177), new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(1489), new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(2755), new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(2763) });
        }
    }
}
