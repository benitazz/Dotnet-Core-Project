using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedTBUCTypeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "VatTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "VatTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "TariffTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "TariffTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Tariffs",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Tariffs",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "TariffBaseUnitCostTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "TariffBaseUnitCostTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "TariffBaseUnitCosts",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "TariffBaseUnitCosts",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "SectionTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "SectionTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PublicationTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PublicationTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PractitionerTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PractitionerTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Practitioners",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Practitioners",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PractitionerPractitionerTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PractitionerPractitionerTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PractitionerGroupTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PractitionerGroupTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItems",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItems",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItemPublications",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItemPublications",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItemPublicationPeriods",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItemPublicationPeriods",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 745, DateTimeKind.Local).AddTicks(2873), new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7121), new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7148), new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7155), new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7163), new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7171), new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7178), new DateTime(2019, 8, 10, 15, 7, 39, 746, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3841), new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3887), new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3891), new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3895), new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3899), new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3903), new DateTime(2019, 8, 10, 15, 7, 39, 752, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9829), new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9895), new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9910), new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9914), new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9918), new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9922), new DateTime(2019, 8, 10, 15, 7, 39, 774, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 802, DateTimeKind.Local).AddTicks(8262), new DateTime(2019, 8, 10, 15, 7, 39, 802, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 802, DateTimeKind.Local).AddTicks(8296), new DateTime(2019, 8, 10, 15, 7, 39, 802, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 802, DateTimeKind.Local).AddTicks(8300), new DateTime(2019, 8, 10, 15, 7, 39, 802, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8171), new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8244), new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8248), new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8251), new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8255), new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8259), new DateTime(2019, 8, 10, 15, 7, 39, 798, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 793, DateTimeKind.Local).AddTicks(9358), new DateTime(2019, 8, 10, 15, 7, 39, 793, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(16), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(27), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(31), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(35), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(35), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(39), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(43), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(43), new DateTime(2019, 8, 10, 15, 7, 39, 794, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 6, "RADIATION ONCOLOGY", "RADONC", "RADIATIONONCOLOGY", "RADONC" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 37, "NATUROPATHY", "NATURO", "NATUROPATHY", "NATURO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 38, "NURSING AGENCY", "NURSAG", "NURSINGAGENCY", "NURSAG" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 39, "OPTOMETRY", "OPTO", "OPTOMETRY", "OPTO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 40, "ORTHOPTISTS", "ORTHOP", "ORTHOPTISTS", "ORTHOP" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 41, "OSTEOPATHY", "OSTEO", "OSTEOPATHY", "OSTEO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 42, "PATOLOGY", "PAT", "PATOLOGY", "PAT" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 43, "PHYTOTHERAPY", "PHYTO", "PHYTOTHERAPY", "PHYTO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 44, "PODIATRY", "PODIAT", "PODIATRY", "PODIAT" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 45, "PSYCHOLOGY", "PSYCHO", "PSYCHOLOGY", "PSYCHO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 46, "PSYCHOMETRY", "PSYCME", "PSYCHOMETRY", "PSYCME" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 47, "RADIOLOGY NHRPL", "RADIO", "RADIOLOGYNHRPL", "RADIO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 48, "RADIOGRAPHY", "RADIOGR", "RADIOGRAPHY", "RADIOGR" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 49, "SOCIAL WORKERS", "SOCIAL", "SOCIALWORKERS", "SOCIAL" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 50, "SPEECH THERAPY AND AUDIOLOGY", "SPEECH", "SPEECHTHERAPYANDAUDIOLOGY", "SPEECH" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 51, "TISSUE TRANSPLANT", "TISSUE", "TISSUETRANSPLANT", "TISSUE" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 52, "UNATTACHED OPERATING THEATRE", "UNATTACH", "UNATTACHEDOPERATINGTHEATRE", "UNATTACH" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 53, "COID UNIT", "UNIT", "COIDUNIT", "UNIT" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 54, "UPFS", "UPFS", "UPFS", "UPFS" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 55, "DENTAL THERAPY", "DENTT", "DENTALTHERAPY", "DENTT" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 56, "NONE", "NONE", "NONE", "NONE" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 57, "Blood Transfusion", "Blood", "BLOODTRANSFUSION", "BLOOD" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 58, "Renal Care", "Renal", "RENALCARE", "RENAL" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 3, "CLINICAL PROCEDURES", "CLIN", "CLINICALPROCEDURES", "CLIN" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 2, "ANAESTHETIC", "ANA", "ANAESTHETIC", "ANA" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 1, "CONSULTATION", "CONS", "CONSULTATION", "CONS" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 5, "PATHOLOGY", "PATH", "PATHOLOGY", "PATH" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 35, "HOMEOPATHY", "HOMEO", "HOMEOPATHY", "HOMEO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 36, "MEDICAL TECHNOLOGY", "MTEC", "MEDICALTECHNOLOGY", "MTEC" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 33, "GENETIC COUNCELLOR", "GENC", "GENETICCOUNCELLOR", "GENC" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 7, "DENTAL PROCEDURES", "DENTAL", "DENTALPROCEDURES", "DENTAL" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 8, "OCCUPATIONAL AND ART THERAPY", "OCC", "OCCUPATIONALANDARTTHERAPY", "OCC" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 9, "CHIROPRACTOR", "CHI", "CHIROPRACTOR", "CHI" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 10, "PHYSIOTHERAPY", "PHYSIO", "PHYSIOTHERAPY", "PHYSIO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 11, "AMBULANCE", "AMB", "AMBULANCE", "AMB" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 12, "ORTHOTIST AND PROSTHETISTS", "ORTPRO", "ORTHOTISTANDPROSTHETISTS", "ORTPRO" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 13, "NAPPI", "NAPPI", "NAPPI", "NAPPI" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 14, "PRIVATE HOSPITAL", "PRIHOSP", "PRIVATEHOSPITAL", "PRIHOSP" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 15, "SUBACUTE FACILITY", "SUBACUTE", "SUBACUTEFACILITY", "SUBACUTE" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 16, "REHABILITATION HOSPITAL", "REHAB", "REHABILITATIONHOSPITAL", "REHAB" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 34, "HEARING AID ACOUSTICIAN", "HAAC", "HEARINGAIDACOUSTICIAN", "HAAC" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 4, "RADIOLOGY", "RAD", "RADIOLOGY", "RAD" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 19, "REGISTERED NURSE", "NURSE", "REGISTEREDNURSE", "NURSE" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 17, "PHARMACY", "PHAR", "PHARMACY", "PHAR" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 21, "NETCARE", "NETCARE", "NETCARE", "NETCARE" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 32, "DENTAL TECHNICIAN", "DTEC", "DENTALTECHNICIAN", "DTEC" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 31, "DIETICIAN", "DIET", "DIETICIAN", "DIET" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 30, "CLINICAL TECHNOLOGY", "CTEC", "CLINICALTECHNOLOGY", "CTEC" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 20, "NHN", "NHN", "NHN", "NHN" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 28, "BRUNS", "BRUNS", "BRUNS", "BRUNS" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 29, "DENTAL CDT", "CDT", "DENTALCDT", "CDT" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 26, "ART THERAPY", "ART", "ARTTHERAPY", "ART" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 25, "ACUPUNCTURE", "ACU", "ACUPUNCTURE", "ACU" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 24, "TEBA", "TEBA", "TEBA", "TEBA" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 23, "MEDICLINIC", "MEDI", "MEDICLINIC", "MEDI" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 22, "MENTAL HEALTH", "MENTAL", "MENTALHEALTH", "MENTAL" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 27, "BIOKINETICS", "BIOK", "BIOKINETICS", "BIOK" });

            migrationBuilder.InsertData(
                table: "TariffBaseUnitCostTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 18, "ORTHOTIST", "ORTH", "ORTHOTIST", "ORTH" });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 755, DateTimeKind.Local).AddTicks(1084), new DateTime(2019, 8, 10, 15, 7, 39, 755, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 755, DateTimeKind.Local).AddTicks(1107), new DateTime(2019, 8, 10, 15, 7, 39, 755, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 759, DateTimeKind.Local).AddTicks(9405), new DateTime(2019, 8, 10, 15, 7, 39, 759, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 7, 39, 760, DateTimeKind.Local).AddTicks(3385), new DateTime(2019, 8, 10, 15, 7, 39, 760, DateTimeKind.Local).AddTicks(3389) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TariffBaseUnitCostTypes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "VatTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "VatTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "TariffTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "TariffTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Tariffs",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Tariffs",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "TariffBaseUnitCostTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "TariffBaseUnitCostTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "TariffBaseUnitCosts",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "TariffBaseUnitCosts",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "SectionTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "SectionTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PublicationTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PublicationTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PractitionerTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PractitionerTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Practitioners",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Practitioners",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PractitionerPractitionerTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PractitionerPractitionerTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "PractitionerGroupTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "PractitionerGroupTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItemTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItems",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItems",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItemPublications",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItemPublications",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MedicalItemPublicationPeriods",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MedicalItemPublicationPeriods",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 632, DateTimeKind.Local).AddTicks(3905), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6516), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6535), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6539), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6543), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6546), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6550), new DateTime(2019, 8, 10, 14, 15, 43, 633, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9877), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9962), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9985), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9997), new DateTime(2019, 8, 10, 14, 15, 43, 639, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(1), new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(8), new DateTime(2019, 8, 10, 14, 15, 43, 640, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8547), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8609), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8613), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8616), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8620), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8624), new DateTime(2019, 8, 10, 14, 15, 43, 667, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9807), new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9865), new DateTime(2019, 8, 10, 14, 15, 43, 685, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 686, DateTimeKind.Local).AddTicks(3), new DateTime(2019, 8, 10, 14, 15, 43, 686, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5653), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5699), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5703), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5711), new DateTime(2019, 8, 10, 14, 15, 43, 682, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(3610), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4333), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4349), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4353), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4353), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4357), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4360), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4364), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4368), new DateTime(2019, 8, 10, 14, 15, 43, 677, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4543), new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4608), new DateTime(2019, 8, 10, 14, 15, 43, 646, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(635), new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(2351), new DateTime(2019, 8, 10, 14, 15, 43, 654, DateTimeKind.Local).AddTicks(2355) });
        }
    }
}
