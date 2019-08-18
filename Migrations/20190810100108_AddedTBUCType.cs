using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedTBUCType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TariffBaseUnitCostTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffBaseUnitCostTypes", x => x.Id);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TariffBaseUnitCostTypes");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 931, DateTimeKind.Local).AddTicks(2092), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9697), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9727), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9731), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9739), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9747), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9750), new DateTime(2019, 8, 10, 11, 34, 39, 932, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7401), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7439), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7443), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7443), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7447), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7451), new DateTime(2019, 8, 10, 11, 34, 39, 937, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7804), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7850), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7850), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7854), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7857), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7857), new DateTime(2019, 8, 10, 11, 34, 39, 953, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(993), new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1028), new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1032), new DateTime(2019, 8, 10, 11, 34, 39, 970, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3459), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3502), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3509), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3509), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3513), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3517), new DateTime(2019, 8, 10, 11, 34, 39, 966, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(2375), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3237), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3256), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3264), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3268), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3272), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3276), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3279), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3279), new DateTime(2019, 8, 10, 11, 34, 39, 961, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2936), new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2967), new DateTime(2019, 8, 10, 11, 34, 39, 940, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4053), new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4096), new DateTime(2019, 8, 10, 11, 34, 39, 944, DateTimeKind.Local).AddTicks(4096) });
        }
    }
}
