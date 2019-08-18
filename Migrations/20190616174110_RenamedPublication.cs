using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenamedPublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_Publications_PublicationId",
                table: "MedicalItemPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_Practioners_Publications_PublicationId",
                table: "Practioners");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.RenameColumn(
                name: "PublicationId",
                table: "MedicalItemPublications",
                newName: "PublicationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_PublicationId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_PublicationTypeId");

            migrationBuilder.CreateTable(
                name: "PublicationTypes",
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
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false),
                    PublicationNo = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 251, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 252, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 257, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 275, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Renal Care Tariffs", false, "Renal Care", "RENALCARETARIFFS", "RENALCARE", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 6, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "General Practioner Tariffs", false, "General Practioner", "GENERALPRACTIONERTARIFFS", "GENERALPRACTIONER", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 5, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Private Ambulance Tariffs", false, "Private Ambulance", "PRIVATEAMBULANCETARIFFS", "PRIVATEAMBULANCE", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 4, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Physiotherapist tariffs", false, "Physiotherapist", "PHYSIOTHERAPISTTARIFFS", "PHYSIOTHERAPIST", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 3, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Dentists tarrifs", false, "Dentist", "DENTISTSTARRIFS", "DENTIST", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 9, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Wound Care Tariffs", false, "Wound Care", "WOUNDCARETARIFFS", "WOUNDCARE", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 1, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Chiropractor Tariffs", false, "Chiropractor", "CHIROPRACTORTARIFFS", "CHIROPRACTOR", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 8, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Social Worker Tariffs", false, "Social Worker", "SOCIALWORKERTARIFFS", "SOCIALWORKER", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local), "Radiologists Tariffs", false, "Radiologist", "RADIOLOGISTSTARIFFS", "RADIOLOGIST", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 41, 9, 284, DateTimeKind.Local) }
                });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 262, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 262, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 266, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 266, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 41, 9, 266, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 41, 9, 266, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_PublicationTypes_PublicationTypeId",
                table: "MedicalItemPublications",
                column: "PublicationTypeId",
                principalTable: "PublicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Practioners_PublicationTypes_PublicationId",
                table: "Practioners",
                column: "PublicationId",
                principalTable: "PublicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_PublicationTypes_PublicationTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_Practioners_PublicationTypes_PublicationId",
                table: "Practioners");

            migrationBuilder.DropTable(
                name: "PublicationTypes");

            migrationBuilder.RenameColumn(
                name: "PublicationTypeId",
                table: "MedicalItemPublications",
                newName: "PublicationId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_PublicationTypeId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_PublicationId");

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    PublicationNo = table.Column<string>(maxLength: 15, nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 37, 998, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 3, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 16, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Renal Care Tariffs", false, "Renal Care", "RENALCARETARIFFS", "RENALCARE", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 6, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "General Practioner Tariffs", false, "General Practioner", "GENERALPRACTIONERTARIFFS", "GENERALPRACTIONER", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 5, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Private Ambulance Tariffs", false, "Private Ambulance", "PRIVATEAMBULANCETARIFFS", "PRIVATEAMBULANCE", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 4, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Physiotherapist tariffs", false, "Physiotherapist", "PHYSIOTHERAPISTTARIFFS", "PHYSIOTHERAPIST", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 3, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Dentists tarrifs", false, "Dentist", "DENTISTSTARRIFS", "DENTIST", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 9, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Wound Care Tariffs", false, "Wound Care", "WOUNDCARETARIFFS", "WOUNDCARE", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 1, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Chiropractor Tariffs", false, "Chiropractor", "CHIROPRACTORTARIFFS", "CHIROPRACTOR", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 8, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Social Worker Tariffs", false, "Social Worker", "SOCIALWORKERTARIFFS", "SOCIALWORKER", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local), "Radiologists Tariffs", false, "Radiologist", "RADIOLOGISTSTARIFFS", "RADIOLOGIST", "11111", "Administrator", new DateTime(2019, 6, 16, 19, 7, 38, 24, DateTimeKind.Local) }
                });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 5, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local), new DateTime(2019, 6, 16, 19, 7, 38, 9, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_Publications_PublicationId",
                table: "MedicalItemPublications",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Practioners_Publications_PublicationId",
                table: "Practioners",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
