using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class VatData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Vats",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Vats",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Percentage",
                table: "Vats",
                type: "DECIMAL(5,2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vats",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vats",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Vats",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.InsertData(
                table: "Vats",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Percentage", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local), "14% Percent VAT", 0.14m, "Administrator", new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local), "15% Percent VAT", 0.15m, "Administrator", new DateTime(2018, 10, 6, 10, 13, 5, 969, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Vats",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Vats",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<double>(
                name: "Percentage",
                table: "Vats",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vats",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vats",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Vats",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 19, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 20, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 21, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local), new DateTime(2018, 10, 6, 10, 6, 4, 23, DateTimeKind.Local) });
        }
    }
}
