using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenamedTBUCTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_TariffUnitCosts_TariffUnitCostId",
                table: "Tariffs");

            migrationBuilder.DropTable(
                name: "TariffUnitCosts");

            migrationBuilder.CreateTable(
                name: "TariffBaseUnitCosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    ValidFrom = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    ValidTo = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    ActualAmount = table.Column<double>(type: "DECIMAL (19, 4)", nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffBaseUnitCosts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 676, DateTimeKind.Local).AddTicks(4933), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8976), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8996), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9000), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9003), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9007), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9011), new DateTime(2019, 8, 10, 12, 8, 30, 677, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5344), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5386), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5390), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5394), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5397), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5397), new DateTime(2019, 8, 10, 12, 8, 30, 681, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5485), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5531), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5535), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5542), new DateTime(2019, 8, 10, 12, 8, 30, 700, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2753), new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2792), new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2796), new DateTime(2019, 8, 10, 12, 8, 30, 716, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9369), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9411), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9415), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9423), new DateTime(2019, 8, 10, 12, 8, 30, 712, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6353), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6965), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6977), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6981), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6989), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6989), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6992), new DateTime(2019, 8, 10, 12, 8, 30, 708, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(318), new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(357), new DateTime(2019, 8, 10, 12, 8, 30, 685, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(465), new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(500), new DateTime(2019, 8, 10, 12, 8, 30, 689, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_TariffBaseUnitCosts_TariffUnitCostId",
                table: "Tariffs",
                column: "TariffUnitCostId",
                principalTable: "TariffBaseUnitCosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_TariffBaseUnitCosts_TariffUnitCostId",
                table: "Tariffs");

            migrationBuilder.DropTable(
                name: "TariffBaseUnitCosts");

            migrationBuilder.CreateTable(
                name: "TariffUnitCosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActualAmount = table.Column<double>(type: "DECIMAL (19, 4)", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    ValidFrom = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    ValidTo = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffUnitCosts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 865, DateTimeKind.Local).AddTicks(3886), new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7130), new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7145), new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7149), new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7153), new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7157), new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7161), new DateTime(2019, 8, 10, 12, 1, 7, 866, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2881), new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2916), new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2920), new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2924), new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2924), new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2927), new DateTime(2019, 8, 10, 12, 1, 7, 870, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5420), new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5470), new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5473), new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5473), new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5477), new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5481), new DateTime(2019, 8, 10, 12, 1, 7, 886, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 900, DateTimeKind.Local).AddTicks(8199), new DateTime(2019, 8, 10, 12, 1, 7, 900, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 900, DateTimeKind.Local).AddTicks(8222), new DateTime(2019, 8, 10, 12, 1, 7, 900, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 900, DateTimeKind.Local).AddTicks(8318), new DateTime(2019, 8, 10, 12, 1, 7, 900, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2829), new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2853), new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2856), new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2860), new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2860), new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2864), new DateTime(2019, 8, 10, 12, 1, 7, 898, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(389), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1024), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1036), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1040), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1040), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1044), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1048), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1048), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1051), new DateTime(2019, 8, 10, 12, 1, 7, 895, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 873, DateTimeKind.Local).AddTicks(2481), new DateTime(2019, 8, 10, 12, 1, 7, 873, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 873, DateTimeKind.Local).AddTicks(2519), new DateTime(2019, 8, 10, 12, 1, 7, 873, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 877, DateTimeKind.Local).AddTicks(4014), new DateTime(2019, 8, 10, 12, 1, 7, 877, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 12, 1, 7, 877, DateTimeKind.Local).AddTicks(4056), new DateTime(2019, 8, 10, 12, 1, 7, 877, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_TariffUnitCosts_TariffUnitCostId",
                table: "Tariffs",
                column: "TariffUnitCostId",
                principalTable: "TariffUnitCosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
