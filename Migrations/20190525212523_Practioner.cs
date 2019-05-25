using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class Practioner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Practioners",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PracticeNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    IsHospital = table.Column<bool>(nullable: false),
                    PublicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practioners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Practioners_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 520, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 522, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 526, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 530, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 535, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 535, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 23, 25, 22, 535, DateTimeKind.Local), new DateTime(2019, 5, 25, 23, 25, 22, 535, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Practioners_PublicationId",
                table: "Practioners",
                column: "PublicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Practioners");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 314, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 330, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 22, 56, 40, 330, DateTimeKind.Local), new DateTime(2019, 5, 25, 22, 56, 40, 330, DateTimeKind.Local) });
        }
    }
}
