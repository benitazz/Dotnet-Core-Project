using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenamedMedicalItemCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemDescriptions_MedicalItemCodes_MedicalItemCodeId",
                table: "MedicalItemDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_MedicalItemCodes_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropTable(
                name: "MedicalItemCodes");

            migrationBuilder.RenameColumn(
                name: "MedicalItemCodeId",
                table: "MedicalItemDescriptions",
                newName: "MedicalItemId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemCodeId",
                table: "MedicalItemDescriptions",
                newName: "IX_MedicalItemDescriptions_MedicalItemId");

            migrationBuilder.CreateTable(
                name: "MedicalItems",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    MedicalItemTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItems_MedicalItemTypes_MedicalItemTypeId",
                        column: x => x.MedicalItemTypeId,
                        principalTable: "MedicalItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 850, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 852, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 870, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 883, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 859, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItems_MedicalItemTypeId",
                table: "MedicalItems",
                column: "MedicalItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemDescriptions_MedicalItems_MedicalItemId",
                table: "MedicalItemDescriptions",
                column: "MedicalItemId",
                principalTable: "MedicalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId",
                principalTable: "MedicalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemDescriptions_MedicalItems_MedicalItemId",
                table: "MedicalItemDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropTable(
                name: "MedicalItems");

            migrationBuilder.RenameColumn(
                name: "MedicalItemId",
                table: "MedicalItemDescriptions",
                newName: "MedicalItemCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemId",
                table: "MedicalItemDescriptions",
                newName: "IX_MedicalItemDescriptions_MedicalItemCodeId");

            migrationBuilder.CreateTable(
                name: "MedicalItemCodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    MedicalItemTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemCodes_MedicalItemTypes_MedicalItemTypeId",
                        column: x => x.MedicalItemTypeId,
                        principalTable: "MedicalItemTypes",
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
                name: "IX_MedicalItemCodes_MedicalItemTypeId",
                table: "MedicalItemCodes",
                column: "MedicalItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemDescriptions_MedicalItemCodes_MedicalItemCodeId",
                table: "MedicalItemDescriptions",
                column: "MedicalItemCodeId",
                principalTable: "MedicalItemCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_MedicalItemCodes_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId",
                principalTable: "MedicalItemCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
