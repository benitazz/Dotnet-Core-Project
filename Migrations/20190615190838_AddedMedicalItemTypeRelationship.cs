using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedMedicalItemTypeRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicalItemTypeId",
                table: "MedicalItemCodes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 76, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 77, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 81, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 98, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 85, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local), new DateTime(2019, 6, 15, 21, 8, 38, 89, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItemCodes_MedicalItemTypeId",
                table: "MedicalItemCodes",
                column: "MedicalItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemCodes_MedicalItemType_MedicalItemTypeId",
                table: "MedicalItemCodes",
                column: "MedicalItemTypeId",
                principalTable: "MedicalItemType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemCodes_MedicalItemType_MedicalItemTypeId",
                table: "MedicalItemCodes");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItemCodes_MedicalItemTypeId",
                table: "MedicalItemCodes");

            migrationBuilder.DropColumn(
                name: "MedicalItemTypeId",
                table: "MedicalItemCodes");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 225, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 226, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 230, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 251, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 238, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 238, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 20, 52, 0, 238, DateTimeKind.Local), new DateTime(2019, 6, 15, 20, 52, 0, 238, DateTimeKind.Local) });
        }
    }
}
