using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RemovecMedicalItemLinkToTariff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropIndex(
                name: "IX_Tariffs_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "MedicalItemId",
                table: "Tariffs");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 761, DateTimeKind.Local).AddTicks(1631), new DateTime(2019, 8, 10, 14, 5, 7, 762, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(429), new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(479), new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(491), new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(495), new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(503), new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(510), new DateTime(2019, 8, 10, 14, 5, 7, 763, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7409), new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7451), new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7455), new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7459), new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7463), new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7466), new DateTime(2019, 8, 10, 14, 5, 7, 769, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9838), new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9880), new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9884), new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9888), new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9891), new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9995), new DateTime(2019, 8, 10, 14, 5, 7, 789, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 809, DateTimeKind.Local).AddTicks(5245), new DateTime(2019, 8, 10, 14, 5, 7, 809, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 809, DateTimeKind.Local).AddTicks(5291), new DateTime(2019, 8, 10, 14, 5, 7, 809, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 809, DateTimeKind.Local).AddTicks(5295), new DateTime(2019, 8, 10, 14, 5, 7, 809, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6931), new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6970), new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6974), new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6977), new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6981), new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6985), new DateTime(2019, 8, 10, 14, 5, 7, 804, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3333), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3975), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3987), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3995), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3995), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3999), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(3999), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(4002), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(4006), new DateTime(2019, 8, 10, 14, 5, 7, 801, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 772, DateTimeKind.Local).AddTicks(8086), new DateTime(2019, 8, 10, 14, 5, 7, 772, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 772, DateTimeKind.Local).AddTicks(8133), new DateTime(2019, 8, 10, 14, 5, 7, 772, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 779, DateTimeKind.Local).AddTicks(4658), new DateTime(2019, 8, 10, 14, 5, 7, 779, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 5, 7, 779, DateTimeKind.Local).AddTicks(6083), new DateTime(2019, 8, 10, 14, 5, 7, 779, DateTimeKind.Local).AddTicks(6091) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicalItemId",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 581, DateTimeKind.Local).AddTicks(1708), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6251), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6270), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6539), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6547), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6551), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6555), new DateTime(2019, 8, 10, 14, 0, 28, 584, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7402), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7475), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7483), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7575), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7591), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7595), new DateTime(2019, 8, 10, 14, 0, 28, 590, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7806), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7876), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7879), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7883), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7887), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7891), new DateTime(2019, 8, 10, 14, 0, 28, 613, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5731), new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5781), new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5785), new DateTime(2019, 8, 10, 14, 0, 28, 636, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8078), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8155), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8159), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8163), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8167), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8171), new DateTime(2019, 8, 10, 14, 0, 28, 630, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(4385), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5070), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5082), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5086), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5086), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5090), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5093), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097), new DateTime(2019, 8, 10, 14, 0, 28, 626, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5095), new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5157), new DateTime(2019, 8, 10, 14, 0, 28, 595, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(4371), new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(5657), new DateTime(2019, 8, 10, 14, 0, 28, 601, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.CreateIndex(
                name: "IX_Tariffs_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId",
                principalTable: "MedicalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
