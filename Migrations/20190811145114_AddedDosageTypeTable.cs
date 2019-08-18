using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedDosageTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DosageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosageTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 334, DateTimeKind.Local).AddTicks(6561), new DateTime(2019, 8, 11, 16, 51, 13, 335, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(565), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(585), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(592), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(596), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(600), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(604), new DateTime(2019, 8, 11, 16, 51, 13, 336, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1776), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1830), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1838), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1842), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1849), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1857), new DateTime(2019, 8, 11, 16, 51, 13, 340, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8909), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8971), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8974), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8978), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8982), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8986), new DateTime(2019, 8, 11, 16, 51, 13, 360, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3855), new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3905), new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3909), new DateTime(2019, 8, 11, 16, 51, 13, 390, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6220), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6266), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6270), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6274), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6274), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6277), new DateTime(2019, 8, 11, 16, 51, 13, 385, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(1936), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2791), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2810), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2814), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2818), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2822), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2825), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2825), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2829), new DateTime(2019, 8, 11, 16, 51, 13, 380, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3712), new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3747), new DateTime(2019, 8, 11, 16, 51, 13, 343, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 347, DateTimeKind.Local).AddTicks(8949), new DateTime(2019, 8, 11, 16, 51, 13, 347, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 16, 51, 13, 348, DateTimeKind.Local).AddTicks(185), new DateTime(2019, 8, 11, 16, 51, 13, 348, DateTimeKind.Local).AddTicks(189) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DosageTypes");

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
        }
    }
}
