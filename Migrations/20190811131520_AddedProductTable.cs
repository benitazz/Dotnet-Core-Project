using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(nullable: true),
                    Strength = table.Column<double>(nullable: true),
                    PackSize = table.Column<int>(nullable: false),
                    ManufactureTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ManufactureTypes_ManufactureTypeId",
                        column: x => x.ManufactureTypeId,
                        principalTable: "ManufactureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 783, DateTimeKind.Local).AddTicks(5932), new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9980), new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9999), new DateTime(2019, 8, 11, 15, 15, 18, 784, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(3), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(7), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(11), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(14), new DateTime(2019, 8, 11, 15, 15, 18, 785, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(36), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(94), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(102), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(109), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(117), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(121), new DateTime(2019, 8, 11, 15, 15, 18, 790, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5555), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5609), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5613), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5617), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5617), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5621), new DateTime(2019, 8, 11, 15, 15, 18, 813, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(818), new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(879), new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(883), new DateTime(2019, 8, 11, 15, 15, 18, 843, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6582), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6629), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6633), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6636), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6636), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6640), new DateTime(2019, 8, 11, 15, 15, 18, 836, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(1945), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2957), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2977), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2984), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2988), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2992), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2996), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(2996), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(3000), new DateTime(2019, 8, 11, 15, 15, 18, 831, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(165), new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(215), new DateTime(2019, 8, 11, 15, 15, 18, 795, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(3937), new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(5223), new DateTime(2019, 8, 11, 15, 15, 18, 800, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufactureTypeId",
                table: "Products",
                column: "ManufactureTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 307, DateTimeKind.Local).AddTicks(6125), new DateTime(2019, 8, 11, 14, 51, 12, 308, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(607), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(634), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(642), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(646), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(650), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(657), new DateTime(2019, 8, 11, 14, 51, 12, 309, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1467), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1510), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1510), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1513), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1517), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1521), new DateTime(2019, 8, 11, 14, 51, 12, 313, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(812), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(858), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(862), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(866), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(866), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(870), new DateTime(2019, 8, 11, 14, 51, 12, 333, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2412), new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2454), new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2454), new DateTime(2019, 8, 11, 14, 51, 12, 358, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7449), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7604), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7608), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7611), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7615), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7619), new DateTime(2019, 8, 11, 14, 51, 12, 354, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(1976), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2831), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2850), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2858), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2862), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2866), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2869), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2873), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2877), new DateTime(2019, 8, 11, 14, 51, 12, 349, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2018), new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2057), new DateTime(2019, 8, 11, 14, 51, 12, 316, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(3484), new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(4746), new DateTime(2019, 8, 11, 14, 51, 12, 321, DateTimeKind.Local).AddTicks(4750) });
        }
    }
}
