using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class ChangedUctToNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 988, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 989, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local), new DateTime(2018, 9, 26, 16, 57, 31, 990, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 174, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) });
        }
    }
}
