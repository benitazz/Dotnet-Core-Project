using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class SeedMedicalItemType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalItemType",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "MedicalItemType",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.InsertData(
                table: "MedicalItemType",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "-", "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), "Unknown", false, "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) },
                    { 4, "M", "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), "Modifier", false, "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) },
                    { 5, "R", "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), "Rule", false, "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) },
                    { 6, "N", "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), "Note", false, "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) },
                    { 3, "ID", "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), "Drug or Pharmaceutical Item (NAPPI)", true, "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) },
                    { 2, "IT", "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local), "Treatment or Procedure Code", true, "Administrator", new DateTime(2019, 6, 15, 20, 52, 0, 246, DateTimeKind.Local) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MedicalItemType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalItemType",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "MedicalItemType",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 314, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 319, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 337, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 323, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 326, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 326, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 15, 18, 45, 45, 326, DateTimeKind.Local), new DateTime(2019, 6, 15, 18, 45, 45, 326, DateTimeKind.Local) });
        }
    }
}
