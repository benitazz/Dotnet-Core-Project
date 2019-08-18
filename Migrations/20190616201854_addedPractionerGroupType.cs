﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedPractionerGroupType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PractitionerGroupTypes",
                columns: table => new
                {
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PractitionerGroupTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 825, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 830, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 846, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 857, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 853, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 832, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 832, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 832, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 832, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 836, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 836, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 18, 53, 836, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 18, 53, 836, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PractitionerGroupTypes");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 207, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 209, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 225, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 237, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 215, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 215, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 215, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 215, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 218, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 218, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 22, 6, 22, 218, DateTimeKind.Local), new DateTime(2019, 6, 16, 22, 6, 22, 218, DateTimeKind.Local) });
        }
    }
}
