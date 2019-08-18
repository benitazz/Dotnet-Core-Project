using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class AddedManufatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "NappiCodeTypes",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "NappiCodeTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Schedule",
                table: "NappiCodeTypes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductStrength",
                table: "NappiCodeTypes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductPackSize",
                table: "NappiCodeTypes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "NappiCodeTypes",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DosageFrom",
                table: "NappiCodeTypes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "NappiCodeTypes",
                type: "DATETIME2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "NappiCodeTypes",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "'Administrator'",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ManufactureTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufactureTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 863, DateTimeKind.Local).AddTicks(1667), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8837), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8856), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8860), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8864), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8867), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8871), new DateTime(2019, 8, 11, 14, 35, 40, 864, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7189), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7254), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7266), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7274), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7281), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7285), new DateTime(2019, 8, 11, 14, 35, 40, 870, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4570), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4616), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4620), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4624), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4628), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4631), new DateTime(2019, 8, 11, 14, 35, 40, 892, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(946), new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(973), new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(977), new DateTime(2019, 8, 11, 14, 35, 40, 915, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1439), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1482), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1486), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1493), new DateTime(2019, 8, 11, 14, 35, 40, 912, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(291), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(949), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(964), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(968), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(968), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(972), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(976), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(976), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(980), new DateTime(2019, 8, 11, 14, 35, 40, 908, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6132), new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6167), new DateTime(2019, 8, 11, 14, 35, 40, 874, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(1908), new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(3170), new DateTime(2019, 8, 11, 14, 35, 40, 879, DateTimeKind.Local).AddTicks(3174) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManufactureTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "NappiCodeTypes",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "NappiCodeTypes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

            migrationBuilder.AlterColumn<int>(
                name: "Schedule",
                table: "NappiCodeTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStrength",
                table: "NappiCodeTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductPackSize",
                table: "NappiCodeTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "NappiCodeTypes",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "DosageFrom",
                table: "NappiCodeTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "NappiCodeTypes",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "NappiCodeTypes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "'Administrator'");

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
    }
}
