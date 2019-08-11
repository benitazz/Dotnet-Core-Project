using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedNappiCodesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 920, DateTimeKind.Local).AddTicks(4822), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8700), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8719), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8723), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8730), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8734), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8738), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4281), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4320), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4324), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4327), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4331), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4335), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5129), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5175), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5179), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5183), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5183), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5187), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 10, 1, "100055", 10, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 9, 3, "100047", 9, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 8, 2, "100040", 8, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 7, 1, "100039", 7, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 6, 1, "100032", 6, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 5, 1, "100024", 5, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 4, 1, "100016", 4, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 3, 1, "100008", 3, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 2, 1, "100001", 2, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 1, 1, "Unknown", 1, null });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7238), new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7284), new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7288), new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3007), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3042), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3050), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3050), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3054), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3057), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(8578), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9717), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9736), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9740), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9744), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9748), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9752), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9756), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9760), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5271), new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5305), new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 932, DateTimeKind.Local).AddTicks(9580), new DateTime(2019, 8, 11, 17, 15, 10, 932, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 933, DateTimeKind.Local).AddTicks(850), new DateTime(2019, 8, 11, 17, 15, 10, 933, DateTimeKind.Local).AddTicks(854) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NappiCodeTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 410, DateTimeKind.Local).AddTicks(7442), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1566), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1582), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1585), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1593), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1593), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1597), new DateTime(2019, 8, 11, 16, 58, 39, 412, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7445), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7476), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7480), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7483), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7487), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7487), new DateTime(2019, 8, 11, 16, 58, 39, 415, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9593), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9639), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9643), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9647), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651), new DateTime(2019, 8, 11, 16, 58, 39, 433, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3139), new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3166), new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3170), new DateTime(2019, 8, 11, 16, 58, 39, 455, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3940), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3986), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025), new DateTime(2019, 8, 11, 16, 58, 39, 452, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(6553), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7211), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7222), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7230), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7230), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7234), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7238), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242), new DateTime(2019, 8, 11, 16, 58, 39, 448, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7356), new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7394), new DateTime(2019, 8, 11, 16, 58, 39, 418, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(6697), new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(7959), new DateTime(2019, 8, 11, 16, 58, 39, 423, DateTimeKind.Local).AddTicks(7963) });
        }
    }
}
