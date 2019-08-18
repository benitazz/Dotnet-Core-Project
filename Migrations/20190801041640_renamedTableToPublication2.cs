using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class renamedTableToPublication2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItemDescriptions");

            migrationBuilder.CreateTable(
                name: "MedicalItemPublications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    MedicalItemId = table.Column<int>(nullable: false),
                    PublicationTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemPublications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemPublications_MedicalItems_MedicalItemId",
                        column: x => x.MedicalItemId,
                        principalTable: "MedicalItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalItemPublications_PublicationTypes_PublicationTypeId",
                        column: x => x.PublicationTypeId,
                        principalTable: "PublicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 261, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 287, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 301, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 270, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 16, 39, 275, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublications_PublicationTypeId",
                table: "MedicalItemPublications",
                column: "PublicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublications_MedicalItemId_PublicationTypeId",
                table: "MedicalItemPublications",
                columns: new[] { "MedicalItemId", "PublicationTypeId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItemPublications");

            migrationBuilder.CreateTable(
                name: "MedicalItemDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    MedicalItemId = table.Column<int>(nullable: false),
                    PublicationTypeId = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemDescriptions_MedicalItems_MedicalItemId",
                        column: x => x.MedicalItemId,
                        principalTable: "MedicalItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalItemDescriptions_PublicationTypes_PublicationTypeId",
                        column: x => x.PublicationTypeId,
                        principalTable: "PublicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 81, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 83, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 141, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 137, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 132, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 12, 28, 105, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemDescriptions_PublicationTypeId",
                table: "MedicalItemDescriptions",
                column: "PublicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemDescriptions_MedicalItemId_PublicationTypeId",
                table: "MedicalItemDescriptions",
                columns: new[] { "MedicalItemId", "PublicationTypeId" },
                unique: true);
        }
    }
}
