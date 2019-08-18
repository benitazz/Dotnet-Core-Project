using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenamedVat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vats");

            migrationBuilder.CreateTable(
                name: "VatTypes",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Percentage = table.Column<double>(type: "DECIMAL (5, 2)", nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 608, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 610, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 613, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 631, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local), new DateTime(2019, 6, 16, 18, 52, 13, 618, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "VatTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "Percentage", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local), "14% Percent VAT", false, 0.14, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local), "15% Percent VAT", false, 0.15, "Administrator", new DateTime(2019, 6, 16, 18, 52, 13, 623, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VatTypes");

            migrationBuilder.CreateTable(
                name: "Vats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Percentage = table.Column<double>(type: "DECIMAL (5, 2)", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vats", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Vats",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "Percentage", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local), "14% Percent VAT", false, 0.14, "Administrator", new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local), "15% Percent VAT", false, 0.15, "Administrator", new DateTime(2019, 6, 16, 18, 17, 35, 863, DateTimeKind.Local) }
                });
        }
    }
}
