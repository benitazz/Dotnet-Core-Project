using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class isDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Vats",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TariffUnitCosts",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TariffTypes",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tariffs",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InvoiceStatuses",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FileStatuses",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 741, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local), 0.14m, new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local), 0.15m, new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Vats");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TariffUnitCosts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TariffTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InvoiceStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FileStatuses");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 963, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 965, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 13, 5, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local), 0m, new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local), 0m, new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local) });
        }
    }
}
