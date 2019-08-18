using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class tariffs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TariffTypes",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vats",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Percentage = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tariffs",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    TariffTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tariffs_TariffTypes_TariffTypeId",
                        column: x => x.TariffTypeId,
                        principalTable: "TariffTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TariffUnitCosts",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ValidFrom = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    ValidTo = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    ActualAmount = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: false),
                    VatAmount = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: false),
                    TariffId = table.Column<int>(nullable: false),
                    VatId = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffUnitCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TariffUnitCosts_Tariffs_TariffId",
                        column: x => x.TariffId,
                        principalTable: "Tariffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TariffUnitCosts_Vats_VatId",
                        column: x => x.VatId,
                        principalTable: "Vats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 19, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TariffTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Chiropractor Tariffs", "Chiropractor", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Radiologists Tariffs", "Radiologist", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 3, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Dentists tarrifs", "Dentist", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 4, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Physiotherapist tariffs", "Physiotherapist", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 5, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Private Ambulance Tariffs", "Private Ambulance", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 6, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "General Practioner Tariffs", "General Practioner", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 7, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Renal Care Tariffs", "Renal Care", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 8, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Social Worker Tariffs", "Social Worker", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) },
                    { 9, "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), "Wound Care Tariffs", "Wound Care", "Administrator", new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tariffs_TariffTypeId",
                table: "Tariffs",
                column: "TariffTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TariffUnitCosts_TariffId",
                table: "TariffUnitCosts",
                column: "TariffId");

            migrationBuilder.CreateIndex(
                name: "IX_TariffUnitCosts_VatId",
                table: "TariffUnitCosts",
                column: "VatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TariffUnitCosts");

            migrationBuilder.DropTable(
                name: "Tariffs");

            migrationBuilder.DropTable(
                name: "Vats");

            migrationBuilder.DropTable(
                name: "TariffTypes");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 988, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });
        }
    }
}
