using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class RenamedMedicalItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItems",
                table: "MedicalItems");

            migrationBuilder.RenameTable(
                name: "MedicalItems",
                newName: "MedicalItemCodes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItemCodes",
                table: "MedicalItemCodes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 539, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 543, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 551, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 551, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 20, 45, 551, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 20, 45, 551, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_MedicalItemCodes_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId",
                principalTable: "MedicalItemCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_MedicalItemCodes_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItemCodes",
                table: "MedicalItemCodes");

            migrationBuilder.RenameTable(
                name: "MedicalItemCodes",
                newName: "MedicalItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItems",
                table: "MedicalItems",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 702, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 704, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 707, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 720, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 711, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 14, 12, 714, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId",
                principalTable: "MedicalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
