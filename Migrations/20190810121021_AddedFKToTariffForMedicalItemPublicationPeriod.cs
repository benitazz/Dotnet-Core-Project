using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedFKToTariffForMedicalItemPublicationPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicalItemPublicationPeriodId",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Tariffs_MedicalItemPublicationPeriodId",
                table: "Tariffs",
                column: "MedicalItemPublicationPeriodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_MedicalItemPublicationPeriods_MedicalItemPublicationPeriodId",
                table: "Tariffs",
                column: "MedicalItemPublicationPeriodId",
                principalTable: "MedicalItemPublicationPeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_MedicalItemPublicationPeriods_MedicalItemPublicationPeriodId",
                table: "Tariffs");

            migrationBuilder.DropIndex(
                name: "IX_Tariffs_MedicalItemPublicationPeriodId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "MedicalItemPublicationPeriodId",
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
    }
}
