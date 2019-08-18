using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedPublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publications",
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
                    From = table.Column<DateTime>(nullable: true),
                    To = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 554, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local), 0.14m, new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local), 0.15m, new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 294, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 296, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local), new DateTime(2018, 10, 6, 19, 10, 26, 298, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 300, DateTimeKind.Local), 0m, new DateTime(2018, 10, 6, 19, 10, 26, 300, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 10, 26, 300, DateTimeKind.Local), 0m, new DateTime(2018, 10, 6, 19, 10, 26, 300, DateTimeKind.Local) });
        }
    }
}
