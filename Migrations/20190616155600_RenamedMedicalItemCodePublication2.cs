using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenamedMedicalItemCodePublication2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItemCodePublications");

            migrationBuilder.CreateTable(
                name: "MedicalItemPublications",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedicalItemCodeDescriptionId = table.Column<int>(nullable: false),
                    PublicationId = table.Column<int>(nullable: false),
                    SectionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemPublications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemPublications_MedicalItemCodeDescriptions_MedicalItemCodeDescriptionId",
                        column: x => x.MedicalItemCodeDescriptionId,
                        principalTable: "MedicalItemCodeDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalItemPublications_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalItemPublications_SectionTypes_SectionTypeId",
                        column: x => x.SectionTypeId,
                        principalTable: "SectionTypes",
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
                name: "IX_MedicalItemPublications_MedicalItemCodeDescriptionId",
                table: "MedicalItemPublications",
                column: "MedicalItemCodeDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublications_PublicationId",
                table: "MedicalItemPublications",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemPublications_SectionTypeId",
                table: "MedicalItemPublications",
                column: "SectionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItemPublications");

            migrationBuilder.CreateTable(
                name: "MedicalItemCodePublications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    MedicalItemCodeDescriptionId = table.Column<int>(nullable: false),
                    PublicationId = table.Column<int>(nullable: false),
                    SectionTypeId = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemCodePublications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItemCodePublications_MedicalItemCodeDescriptions_MedicalItemCodeDescriptionId",
                        column: x => x.MedicalItemCodeDescriptionId,
                        principalTable: "MedicalItemCodeDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalItemCodePublications_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalItemCodePublications_SectionTypes_SectionTypeId",
                        column: x => x.SectionTypeId,
                        principalTable: "SectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 154, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 155, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 159, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 175, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 183, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 164, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local), new DateTime(2019, 6, 16, 17, 53, 22, 168, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemCodePublications_MedicalItemCodeDescriptionId",
                table: "MedicalItemCodePublications",
                column: "MedicalItemCodeDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemCodePublications_PublicationId",
                table: "MedicalItemCodePublications",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemCodePublications_SectionTypeId",
                table: "MedicalItemCodePublications",
                column: "SectionTypeId");
        }
    }
}
