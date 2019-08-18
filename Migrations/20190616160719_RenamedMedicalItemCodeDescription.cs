using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenamedMedicalItemCodeDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_MedicalItemCodeDescriptions_MedicalItemCodeDescriptionId",
                table: "MedicalItemPublications");

            migrationBuilder.DropTable(
                name: "MedicalItemCodeDescriptions");

            migrationBuilder.RenameColumn(
                name: "MedicalItemCodeDescriptionId",
                table: "MedicalItemPublications",
                newName: "MedicalItemDescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_MedicalItemCodeDescriptionId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_MedicalItemDescriptionId");

            migrationBuilder.CreateTable(
                name: "MedicalItemDescriptions",
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
                    table.PrimaryKey("PK_MedicalItemDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemDescriptions_MedicalItemCodes_MedicalItemCodeId",
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
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 317, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 335, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 325, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 328, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 328, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 7, 19, 328, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 7, 19, 328, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemCodeId",
                table: "MedicalItemDescriptions",
                column: "MedicalItemCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_MedicalItemDescriptions_MedicalItemDescriptionId",
                table: "MedicalItemPublications",
                column: "MedicalItemDescriptionId",
                principalTable: "MedicalItemDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_MedicalItemDescriptions_MedicalItemDescriptionId",
                table: "MedicalItemPublications");

            migrationBuilder.DropTable(
                name: "MedicalItemDescriptions");

            migrationBuilder.RenameColumn(
                name: "MedicalItemDescriptionId",
                table: "MedicalItemPublications",
                newName: "MedicalItemCodeDescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_MedicalItemDescriptionId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_MedicalItemCodeDescriptionId");

            migrationBuilder.CreateTable(
                name: "MedicalItemCodeDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    MedicalItemCodeId = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemCodeDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemCodeDescriptions_MedicalItemCodes_MedicalItemCodeId",
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
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 847, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 848, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 849, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 869, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 861, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 861, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 55, 59, 861, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 55, 59, 861, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemCodeDescriptions_MedicalItemCodeId",
                table: "MedicalItemCodeDescriptions",
                column: "MedicalItemCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_MedicalItemCodeDescriptions_MedicalItemCodeDescriptionId",
                table: "MedicalItemPublications",
                column: "MedicalItemCodeDescriptionId",
                principalTable: "MedicalItemCodeDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
