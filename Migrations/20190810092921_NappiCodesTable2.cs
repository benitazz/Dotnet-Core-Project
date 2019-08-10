using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class NappiCodesTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NappiCodeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NappiCode = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductStrength = table.Column<int>(nullable: false),
                    DosageFrom = table.Column<int>(nullable: false),
                    ProductPackSize = table.Column<int>(nullable: false),
                    ManufacturerCode = table.Column<string>(nullable: true),
                    Schedule = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NappiCodeTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 489, DateTimeKind.Local).AddTicks(889), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5226), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5245), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5249), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5256), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5256), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5264), new DateTime(2019, 8, 10, 11, 29, 20, 490, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4745), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4780), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4784), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4784), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4788), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4792), new DateTime(2019, 8, 10, 11, 29, 20, 494, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9063), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9113), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9120), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9124), new DateTime(2019, 8, 10, 11, 29, 20, 510, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9282), new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9305), new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9309), new DateTime(2019, 8, 10, 11, 29, 20, 524, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4024), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4063), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4067), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4070), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4070), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4074), new DateTime(2019, 8, 10, 11, 29, 20, 522, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(6459), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7099), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7110), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7114), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7118), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7118), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7122), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7125), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7125), new DateTime(2019, 8, 10, 11, 29, 20, 518, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9449), new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9472), new DateTime(2019, 8, 10, 11, 29, 20, 496, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2561), new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2618), new DateTime(2019, 8, 10, 11, 29, 20, 501, DateTimeKind.Local).AddTicks(2622) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NappiCodeTypes");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 151, DateTimeKind.Local).AddTicks(6708), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8066), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8085), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8089), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8092), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8096), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8100), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3139), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3166), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3170), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3174), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3178), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3182), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(7553), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8011), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8038), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8045), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4266), new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4289), new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4293), new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7338), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7369), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7373), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7380), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(4559), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5240), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5252), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5255), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5255), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5263), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5267), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7951), new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7986), new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6837), new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6867), new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6871) });
        }
    }
}
