using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedFKToTariffForPractionerType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PractitionerTypeId",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 122, DateTimeKind.Local).AddTicks(2853), new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(1998), new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2025), new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2033), new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2037), new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2044), new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2048), new DateTime(2019, 8, 10, 14, 13, 10, 124, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5157), new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5191), new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5195), new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5199), new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5203), new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5207), new DateTime(2019, 8, 10, 14, 13, 10, 128, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9103), new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9153), new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9157), new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9161), new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9165), new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9165), new DateTime(2019, 8, 10, 14, 13, 10, 146, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 161, DateTimeKind.Local).AddTicks(8230), new DateTime(2019, 8, 10, 14, 13, 10, 161, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 161, DateTimeKind.Local).AddTicks(8264), new DateTime(2019, 8, 10, 14, 13, 10, 161, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 161, DateTimeKind.Local).AddTicks(8268), new DateTime(2019, 8, 10, 14, 13, 10, 161, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8241), new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8276), new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8280), new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8283), new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8283), new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8287), new DateTime(2019, 8, 10, 14, 13, 10, 158, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4237), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4888), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4899), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4903), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4907), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4907), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4911), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4915), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4915), new DateTime(2019, 8, 10, 14, 13, 10, 155, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 131, DateTimeKind.Local).AddTicks(2269), new DateTime(2019, 8, 10, 14, 13, 10, 131, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 131, DateTimeKind.Local).AddTicks(2303), new DateTime(2019, 8, 10, 14, 13, 10, 131, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 137, DateTimeKind.Local).AddTicks(6431), new DateTime(2019, 8, 10, 14, 13, 10, 137, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 13, 10, 137, DateTimeKind.Local).AddTicks(7682), new DateTime(2019, 8, 10, 14, 13, 10, 137, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.CreateIndex(
                name: "IX_Tariffs_PractitionerTypeId",
                table: "Tariffs",
                column: "PractitionerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_PractitionerTypes_PractitionerTypeId",
                table: "Tariffs",
                column: "PractitionerTypeId",
                principalTable: "PractitionerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_PractitionerTypes_PractitionerTypeId",
                table: "Tariffs");

            migrationBuilder.DropIndex(
                name: "IX_Tariffs_PractitionerTypeId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "PractitionerTypeId",
                table: "Tariffs");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 43, DateTimeKind.Local).AddTicks(2576), new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1831), new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1904), new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1927), new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1958), new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1981), new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(2004), new DateTime(2019, 8, 10, 14, 10, 20, 45, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8233), new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8279), new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8283), new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8290), new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8294), new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8302), new DateTime(2019, 8, 10, 14, 10, 20, 50, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6233), new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6303), new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6310), new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6314), new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6318), new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6318), new DateTime(2019, 8, 10, 14, 10, 20, 78, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 106, DateTimeKind.Local).AddTicks(7794), new DateTime(2019, 8, 10, 14, 10, 20, 106, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 106, DateTimeKind.Local).AddTicks(7898), new DateTime(2019, 8, 10, 14, 10, 20, 106, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 106, DateTimeKind.Local).AddTicks(7902), new DateTime(2019, 8, 10, 14, 10, 20, 106, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9909), new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9963), new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9967), new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9971), new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9971), new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9974), new DateTime(2019, 8, 10, 14, 10, 20, 101, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(6478), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7301), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7321), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7328), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7328), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7332), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7336), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7340), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7344), new DateTime(2019, 8, 10, 14, 10, 20, 94, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 57, DateTimeKind.Local).AddTicks(6502), new DateTime(2019, 8, 10, 14, 10, 20, 57, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 57, DateTimeKind.Local).AddTicks(6556), new DateTime(2019, 8, 10, 14, 10, 20, 57, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 64, DateTimeKind.Local).AddTicks(3704), new DateTime(2019, 8, 10, 14, 10, 20, 64, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 10, 20, 64, DateTimeKind.Local).AddTicks(5002), new DateTime(2019, 8, 10, 14, 10, 20, 64, DateTimeKind.Local).AddTicks(5006) });
        }
    }
}
