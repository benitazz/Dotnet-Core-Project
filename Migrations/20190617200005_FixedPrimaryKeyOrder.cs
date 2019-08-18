using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class FixedPrimaryKeyOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "MedicalItemTypes",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDescription",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 311, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 312, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), "UNKNOWN", "-", new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), "TREATMENTORPROCEDURECODE", "IT", new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), "DRUGORPHARMACEUTICALITEM(NAPPI)", "ID", new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), "MODIFIER", "M", new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), "RULE", "R", new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local), "NOTE", "N", new DateTime(2019, 6, 17, 22, 0, 5, 329, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 343, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 341, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 318, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local), new DateTime(2019, 6, 17, 22, 0, 5, 322, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalizedDescription",
                table: "MedicalItemTypes");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "MedicalItemTypes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MedicalItemTypes",
                newName: "Code");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 226, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 229, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 234, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 250, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 264, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 261, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local), new DateTime(2019, 6, 17, 21, 15, 47, 241, DateTimeKind.Local) });
        }
    }
}
