using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class LevelMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_TariffTypes_TariffTypeId",
                table: "Tariffs");

            migrationBuilder.DropForeignKey(
                name: "FK_TariffUnitCosts_Tariffs_TariffId",
                table: "TariffUnitCosts");

            migrationBuilder.DropForeignKey(
                name: "FK_TariffUnitCosts_Vats_VatId",
                table: "TariffUnitCosts");

            migrationBuilder.DropIndex(
                name: "IX_TariffUnitCosts_TariffId",
                table: "TariffUnitCosts");

            migrationBuilder.DropIndex(
                name: "IX_TariffUnitCosts_VatId",
                table: "TariffUnitCosts");

            migrationBuilder.DropIndex(
                name: "IX_Tariffs_TariffTypeId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "TariffId",
                table: "TariffUnitCosts");

            migrationBuilder.DropColumn(
                name: "VatAmount",
                table: "TariffUnitCosts");

            migrationBuilder.DropColumn(
                name: "VatId",
                table: "TariffUnitCosts");

            migrationBuilder.DropColumn(
                name: "TariffTypeId",
                table: "Tariffs");

            migrationBuilder.RenameColumn(
                name: "ItemDescription",
                table: "TariffUnitCosts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "Publications",
                newName: "ValidTo");

            migrationBuilder.RenameColumn(
                name: "From",
                table: "Publications",
                newName: "ValidFrom");

            migrationBuilder.RenameColumn(
                name: "ToDate",
                table: "MedicalItems",
                newName: "ValidTo");

            migrationBuilder.RenameColumn(
                name: "FromDate",
                table: "MedicalItems",
                newName: "ValidFrom");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TariffUnitCosts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TariffUnitCostId",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 325, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 326, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 327, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 330, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 333, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local), new DateTime(2019, 6, 2, 9, 23, 26, 337, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Tariffs_TariffUnitCostId",
                table: "Tariffs",
                column: "TariffUnitCostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_TariffUnitCosts_TariffUnitCostId",
                table: "Tariffs",
                column: "TariffUnitCostId",
                principalTable: "TariffUnitCosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_TariffUnitCosts_TariffUnitCostId",
                table: "Tariffs");

            migrationBuilder.DropIndex(
                name: "IX_Tariffs_TariffUnitCostId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TariffUnitCosts");

            migrationBuilder.DropColumn(
                name: "TariffUnitCostId",
                table: "Tariffs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TariffUnitCosts",
                newName: "ItemDescription");

            migrationBuilder.RenameColumn(
                name: "ValidTo",
                table: "Publications",
                newName: "To");

            migrationBuilder.RenameColumn(
                name: "ValidFrom",
                table: "Publications",
                newName: "From");

            migrationBuilder.RenameColumn(
                name: "ValidTo",
                table: "MedicalItems",
                newName: "ToDate");

            migrationBuilder.RenameColumn(
                name: "ValidFrom",
                table: "MedicalItems",
                newName: "FromDate");

            migrationBuilder.AddColumn<int>(
                name: "TariffId",
                table: "TariffUnitCosts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "VatAmount",
                table: "TariffUnitCosts",
                type: "DECIMAL (19, 4)",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "VatId",
                table: "TariffUnitCosts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TariffTypeId",
                table: "Tariffs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 819, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 820, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 824, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 829, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 833, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 833, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 26, 9, 18, 8, 833, DateTimeKind.Local), new DateTime(2019, 5, 26, 9, 18, 8, 833, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_TariffUnitCosts_TariffId",
                table: "TariffUnitCosts",
                column: "TariffId");

            migrationBuilder.CreateIndex(
                name: "IX_TariffUnitCosts_VatId",
                table: "TariffUnitCosts",
                column: "VatId");

            migrationBuilder.CreateIndex(
                name: "IX_Tariffs_TariffTypeId",
                table: "Tariffs",
                column: "TariffTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_TariffTypes_TariffTypeId",
                table: "Tariffs",
                column: "TariffTypeId",
                principalTable: "TariffTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TariffUnitCosts_Tariffs_TariffId",
                table: "TariffUnitCosts",
                column: "TariffId",
                principalTable: "Tariffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TariffUnitCosts_Vats_VatId",
                table: "TariffUnitCosts",
                column: "VatId",
                principalTable: "Vats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
