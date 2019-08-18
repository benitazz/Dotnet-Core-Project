using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedFKToTariffForVatType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VatTypeId",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 632, DateTimeKind.Local).AddTicks(3905), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6516), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6535), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6539), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6543), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6546), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6550), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9877), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9962), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9985), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9997), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(1), new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(8), new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8547), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8609), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8613), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8616), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8620), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8624), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9807), new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9865), new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 686, DateTimeKind.Local).AddTicks(3), new DateTime(2019, 8, 10, 14, 15, 43, 686, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5653), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5699), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5703), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5711), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(3610), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4333), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4349), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4353), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4353), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4357), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4360), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4364), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4368), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4543), new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4608), new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(635), new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(2351), new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.CreateIndex(
                name: "IX_Tariffs_VatTypeId",
                table: "Tariffs",
                column: "VatTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_VatTypes_VatTypeId",
                table: "Tariffs",
                column: "VatTypeId",
                principalTable: "VatTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_VatTypes_VatTypeId",
                table: "Tariffs");

            migrationBuilder.DropIndex(
                name: "IX_Tariffs_VatTypeId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "VatTypeId",
                table: "Tariffs");

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
        }
    }
}
