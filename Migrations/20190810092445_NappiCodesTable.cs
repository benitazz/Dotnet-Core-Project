using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class NappiCodesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MedicalItems");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MedicalItemPublications",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 151, DateTimeKind.Local).AddTicks(6708), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8066), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8085), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8089), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8092), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8096), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8100), new DateTime(2019, 8, 10, 11, 24, 45, 153, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3139), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3166), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3170), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3174), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3178), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3182), new DateTime(2019, 8, 10, 11, 24, 45, 157, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(7553), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8011), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8038), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8045), new DateTime(2019, 8, 10, 11, 24, 45, 179, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4266), new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4289), new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4293), new DateTime(2019, 8, 10, 11, 24, 45, 194, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7338), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7369), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7373), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7380), new DateTime(2019, 8, 10, 11, 24, 45, 191, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(4559), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5240), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5252), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5255), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5255), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5259), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5263), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5267), new DateTime(2019, 8, 10, 11, 24, 45, 188, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7951), new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7986), new DateTime(2019, 8, 10, 11, 24, 45, 163, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6837), new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6867), new DateTime(2019, 8, 10, 11, 24, 45, 167, DateTimeKind.Local).AddTicks(6871) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MedicalItemPublications");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MedicalItems",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 112, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 121, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 163, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 192, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 189, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 178, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 126, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local), new DateTime(2019, 8, 1, 6, 29, 29, 135, DateTimeKind.Local) });
        }
    }
}
