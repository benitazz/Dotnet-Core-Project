using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class RemovedPractitionerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Practioners");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 235, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 240, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 255, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 267, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 243, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 243, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 243, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 243, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 246, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 43, 2, 246, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 43, 2, 246, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Practioners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    IsHospital = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PracticeNo = table.Column<string>(nullable: true),
                    PublicationId = table.Column<int>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practioners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Practioners_PublicationTypes_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "PublicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 432, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 434, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 439, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 453, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 463, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 460, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 441, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 441, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 441, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 441, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 444, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 444, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 21, 32, 27, 444, DateTimeKind.Local), new DateTime(2019, 6, 16, 21, 32, 27, 444, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Practioners_PublicationId",
                table: "Practioners",
                column: "PublicationId");
        }
    }
}
