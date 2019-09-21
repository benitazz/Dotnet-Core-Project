using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedTheModifiersMedicalItemCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 906, DateTimeKind.Local).AddTicks(4327), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7617), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7647), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7655), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7663), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7667), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7674), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6108), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6170), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6174), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6182), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6189), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6193), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9287), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9364), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9368), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9376), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9376), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9380), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 55, "0165", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 54, "0160", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 53, "0097", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 52, "0096", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 51, "0095", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 50, "0092", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 49, "0091", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 47, "0086", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 46, "0085", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 45, "0084", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 44, "0083", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 43, "0082", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 42, "0081", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 48, "0090", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 56, "5104", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 66, "6109", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 58, "6101", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 72, "6305", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 71, "6303", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 70, "6302", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 69, "6301", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 68, "6300", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 67, "6110", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 57, "6100", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 41, "0080", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 64, "6107", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 63, "6106", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 62, "6105", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 61, "6104", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 60, "6103", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 59, "6102", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 65, "6108", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 40, "0079", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 39, "0078", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 11, "0014", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 17, "0047", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 16, "0046", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 15, "0019", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 14, "0018", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 12, "0015", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 38, "0077", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 10, "0013", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 18, "0048", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 9, "0011", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 7, "0009", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 6, "0008", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 5, "0007", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 4, "0006", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 3, "0005", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 2, "0004", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 1, "0002", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 8, "0010", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 19, "0049", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 13, "0017", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 21, "0051", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 37, "0075", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 36, "0074", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 20, "0050", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 34, "0072", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 33, "0070", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 32, "0069", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 31, "0067", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 30, "0066", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 35, "0073", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 28, "0064", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 27, "0063", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 26, "0061", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 29, "0065", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 25, "0058", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 24, "0057", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 23, "0055", 4, null });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Code", "MedicalItemTypeId", "NappiCodeId" },
                values: new object[] { 22, "0053", 4, null });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5412), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5516), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5524), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5528), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5528), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5536), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5539), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4625), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4691), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4698), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4702), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4706), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4710), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7412), new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7470), new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 944, DateTimeKind.Local).AddTicks(4580), new DateTime(2019, 9, 19, 4, 34, 54, 944, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 945, DateTimeKind.Local).AddTicks(1921), new DateTime(2019, 9, 19, 4, 34, 54, 945, DateTimeKind.Local).AddTicks(1929) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 72);

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
    }
}
