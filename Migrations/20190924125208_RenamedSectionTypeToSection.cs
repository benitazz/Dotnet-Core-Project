using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenamedSectionTypeToSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionTypes");

            migrationBuilder.CreateTable(
                name: "Sections",
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
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false),
                    SectionNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 567, DateTimeKind.Local).AddTicks(7733), new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(706), new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(725), new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(729), new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(736), new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(740), new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(744), new DateTime(2019, 9, 24, 14, 51, 56, 572, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(588), new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(626), new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(630), new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(630), new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(634), new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(638), new DateTime(2019, 9, 24, 14, 51, 56, 576, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4797), new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4847), new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4851), new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4851), new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4855), new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4859), new DateTime(2019, 9, 24, 14, 51, 57, 613, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4816), new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4855), new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4859), new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4863), new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4863), new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4867), new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4867), new DateTime(2019, 9, 24, 14, 51, 57, 642, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6910), new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6956), new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6960), new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6964), new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6964), new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6967), new DateTime(2019, 9, 24, 14, 51, 57, 638, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 578, DateTimeKind.Local).AddTicks(6411), new DateTime(2019, 9, 24, 14, 51, 56, 578, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 578, DateTimeKind.Local).AddTicks(6434), new DateTime(2019, 9, 24, 14, 51, 56, 578, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 583, DateTimeKind.Local).AddTicks(974), new DateTime(2019, 9, 24, 14, 51, 56, 583, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 24, 14, 51, 56, 583, DateTimeKind.Local).AddTicks(2286), new DateTime(2019, 9, 24, 14, 51, 56, 583, DateTimeKind.Local).AddTicks(2290) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.CreateTable(
                name: "SectionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    SectionNo = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 287, DateTimeKind.Local).AddTicks(2775), new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6661), new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6692), new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6700), new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6707), new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6715), new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6723), new DateTime(2019, 9, 22, 14, 17, 54, 294, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9814), new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9880), new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9887), new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9895), new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9899), new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9903), new DateTime(2019, 9, 22, 14, 17, 54, 300, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7063), new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7163), new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7171), new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7179), new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7182), new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7190), new DateTime(2019, 9, 22, 14, 17, 55, 879, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6815), new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6896), new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6904), new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6907), new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6911), new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6915), new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6919), new DateTime(2019, 9, 22, 14, 17, 55, 930, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9415), new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9472), new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9472), new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9476), new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9480), new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9484), new DateTime(2019, 9, 22, 14, 17, 55, 925, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 306, DateTimeKind.Local).AddTicks(7358), new DateTime(2019, 9, 22, 14, 17, 54, 306, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 306, DateTimeKind.Local).AddTicks(7435), new DateTime(2019, 9, 22, 14, 17, 54, 306, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 315, DateTimeKind.Local).AddTicks(3851), new DateTime(2019, 9, 22, 14, 17, 54, 315, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 22, 14, 17, 54, 315, DateTimeKind.Local).AddTicks(5892), new DateTime(2019, 9, 22, 14, 17, 54, 315, DateTimeKind.Local).AddTicks(5899) });
        }
    }
}
