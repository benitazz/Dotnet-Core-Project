using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 9, 1, "Magna bloc adhes applic (60tapes)-892", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 1, 1, "Unknown", 1, 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 8, 1, "Magna bloc skin prep towels(16)-9605", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 7, 1, "Magna bloc wrist bands (2)-8830", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 6, 1, "Magna bloc personal discs (3)-8798", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 5, 1, "Magna bloc knee band-8833", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 4, 1, "Magna bloc head band-8838", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 3, 1, "Magna bloc elbow band-8839", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 2, 1, "Magna bloc back belt-8837", 1, 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ManufactureTypeId", "Name", "PackSize", "Strength" },
                values: new object[] { 10, 2, "Terranetic pillow mat", 1, null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 783, DateTimeKind.Local).AddTicks(5932), new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9980), new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9999), new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(3), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(7), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(11), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(14), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(36), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(94), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(102), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(109), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(117), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(121), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5555), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5609), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5613), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5617), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5617), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5621), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(818), new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(879), new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(883), new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6582), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6629), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6633), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6636), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6636), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6640), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(1945), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2957), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2977), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2984), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2988), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2992), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2996), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2996), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(3000), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(165), new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(215), new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(3937), new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(5223), new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(5230) });
        }
    }
}
