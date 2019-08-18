using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedRecommendedunit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_TariffTypes_TariffTypeId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Tariffs");

            migrationBuilder.AlterColumn<int>(
                name: "TariffTypeId",
                table: "Tariffs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MedicalItemId",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "RecommendedUnit",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "Tariffs",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "Tariffs",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "IX_Tariffs_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs",
                column: "MedicalItemId",
                principalTable: "MedicalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_TariffTypes_TariffTypeId",
                table: "Tariffs",
                column: "TariffTypeId",
                principalTable: "TariffTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_MedicalItems_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Tariffs_TariffTypes_TariffTypeId",
                table: "Tariffs");

            migrationBuilder.DropIndex(
                name: "IX_Tariffs_MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "MedicalItemId",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "RecommendedUnit",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "Tariffs");

            migrationBuilder.AlterColumn<int>(
                name: "TariffTypeId",
                table: "Tariffs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Tariffs",
                maxLength: 10,
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tariffs_TariffTypes_TariffTypeId",
                table: "Tariffs",
                column: "TariffTypeId",
                principalTable: "TariffTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
