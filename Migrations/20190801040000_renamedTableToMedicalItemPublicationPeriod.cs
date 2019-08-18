using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class renamedTableToMedicalItemPublicationPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItemPublications");

            migrationBuilder.CreateTable(
                name: "MedicalItemPublicationPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    MedicalItemDescriptionId = table.Column<int>(nullable: false),
                    ValiFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemPublicationPeriods", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 698, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 730, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 739, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 712, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local), new DateTime(2019, 8, 1, 5, 59, 58, 717, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItemPublicationPeriods");

            migrationBuilder.CreateTable(
                name: "MedicalItemPublications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    MedicalItemDescriptionId = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    ValiFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItemPublications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 793, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 798, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 839, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 804, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local), new DateTime(2019, 7, 31, 22, 18, 18, 808, DateTimeKind.Local) });
        }
    }
}
