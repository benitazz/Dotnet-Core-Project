using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedSecitonTypen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemCodeDescription_MedicalItemCodes_MedicalItemCodeId",
                table: "MedicalItemCodeDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItemCodeDescription",
                table: "MedicalItemCodeDescription");

            migrationBuilder.RenameTable(
                name: "MedicalItemCodeDescription",
                newName: "MedicalItemCodeDescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemCodeDescription_MedicalItemCodeId",
                table: "MedicalItemCodeDescriptions",
                newName: "IX_MedicalItemCodeDescriptions_MedicalItemCodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItemCodeDescriptions",
                table: "MedicalItemCodeDescriptions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SectionTypes",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false),
                    SectionNo = table.Column<string>(nullable: true)
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
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 567, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 569, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 572, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 586, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 592, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 592, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 593, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 575, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 579, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 579, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 56, 50, 579, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 56, 50, 579, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemCodeDescriptions_MedicalItemCodes_MedicalItemCodeId",
                table: "MedicalItemCodeDescriptions",
                column: "MedicalItemCodeId",
                principalTable: "MedicalItemCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemCodeDescriptions_MedicalItemCodes_MedicalItemCodeId",
                table: "MedicalItemCodeDescriptions");

            migrationBuilder.DropTable(
                name: "SectionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItemCodeDescriptions",
                table: "MedicalItemCodeDescriptions");

            migrationBuilder.RenameTable(
                name: "MedicalItemCodeDescriptions",
                newName: "MedicalItemCodeDescription");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemCodeDescriptions_MedicalItemCodeId",
                table: "MedicalItemCodeDescription",
                newName: "IX_MedicalItemCodeDescription_MedicalItemCodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItemCodeDescription",
                table: "MedicalItemCodeDescription",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemCodeDescription_MedicalItemCodes_MedicalItemCodeId",
                table: "MedicalItemCodeDescription",
                column: "MedicalItemCodeId",
                principalTable: "MedicalItemCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
