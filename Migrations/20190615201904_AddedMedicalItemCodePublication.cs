using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedMedicalItemCodePublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemCodes_MedicalItemType_MedicalItemTypeId",
                table: "MedicalItemCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItemType",
                table: "MedicalItemType");

            migrationBuilder.RenameTable(
                name: "MedicalItemType",
                newName: "MedicalItemTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItemTypes",
                table: "MedicalItemTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MedicalItemCodePublications",
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
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 232, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 22, 19, 4, 246, DateTimeKind.Local) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemCodes_MedicalItemTypes_MedicalItemTypeId",
                table: "MedicalItemCodes",
                column: "MedicalItemTypeId",
                principalTable: "MedicalItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemCodes_MedicalItemTypes_MedicalItemTypeId",
                table: "MedicalItemCodes");

            migrationBuilder.DropTable(
                name: "MedicalItemCodePublications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItemTypes",
                table: "MedicalItemTypes");

            migrationBuilder.RenameTable(
                name: "MedicalItemTypes",
                newName: "MedicalItemType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItemType",
                table: "MedicalItemType",
                column: "Id");

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
                name: "FK_MedicalItemCodes_MedicalItemType_MedicalItemTypeId",
                table: "MedicalItemCodes",
                column: "MedicalItemTypeId",
                principalTable: "MedicalItemType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
