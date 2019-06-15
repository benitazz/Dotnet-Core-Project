using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedMedicalItemCodeDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalItemCodeDescription",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    MedicalItemCodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemCodeDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemCodeDescription_MedicalItemCodes_MedicalItemCodeId",
                        column: x => x.MedicalItemCodeId,
                        principalTable: "MedicalItemCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 488, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 493, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 512, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 516, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 496, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 500, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 500, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 33, 31, 500, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 33, 31, 500, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemCodeDescription_MedicalItemCodeId",
                table: "MedicalItemCodeDescription",
                column: "MedicalItemCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItemCodeDescription");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 76, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local) });
        }
    }
}
