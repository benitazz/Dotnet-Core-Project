using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class normalizedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NormalizedDescription",
                table: "TariffTypes",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "TariffTypes",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDescription",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "InvoiceStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDescription",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "FileStatuses",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local), "SUCCESSFULLYUPLOADEDTHEFILE", "UPLOADED", new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local), "THEMANAGERREJECTEDTHEFILE", "REJECTED", new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local), "READYTOSUBMITTOTHEFUND", "APPROVED", new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local), "FILESUCCESSFULLYSUBMITTEDTOTHEFUND", "SUBMITTED", new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local), "NOTALLINVOICESWEREPAID", "PARTIALLY PAID", new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local), "ALLINVOICESWERESUCCESSFULLYPAID", "PAID", new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local), "FILEOVERDUE", "OVERDUE", new DateTime(2018, 10, 6, 19, 4, 9, 557, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local), "PENDING", "PENDING", new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local), "APPROVED", "APPROVED", new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local), "PAYMENTREJECTED", "REJECTED", new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local), "INVOICESUBMITTEDTOTHEFUND", "SUBMITTED", new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local), "INVOICEPAID", "PAID", new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local), "INVOICEOVERDUE", "OVERDUE", new DateTime(2018, 10, 6, 19, 4, 9, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "CHIROPRACTORTARIFFS", "CHIROPRACTOR", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "RADIOLOGISTSTARIFFS", "RADIOLOGIST", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "DENTISTSTARRIFS", "DENTIST", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "PHYSIOTHERAPISTTARIFFS", "PHYSIOTHERAPIST", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "PRIVATEAMBULANCETARIFFS", "PRIVATE AMBULANCE", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "GENERALPRACTIONERTARIFFS", "GENERAL PRACTIONER", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "RENALCARETARIFFS", "RENAL CARE", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "SOCIALWORKERTARIFFS", "SOCIAL WORKER", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "NormalizedDescription", "NormalizedName", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local), "WOUNDCARETARIFFS", "WOUND CARE", new DateTime(2018, 10, 6, 19, 4, 9, 561, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 563, DateTimeKind.Local), 0.14m, new DateTime(2018, 10, 6, 19, 4, 9, 563, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 19, 4, 9, 563, DateTimeKind.Local), 0.15m, new DateTime(2018, 10, 6, 19, 4, 9, 563, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalizedDescription",
                table: "TariffTypes");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "TariffTypes");

            migrationBuilder.DropColumn(
                name: "NormalizedDescription",
                table: "InvoiceStatuses");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "InvoiceStatuses");

            migrationBuilder.DropColumn(
                name: "NormalizedDescription",
                table: "FileStatuses");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "FileStatuses");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 741, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 742, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 744, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local), new DateTime(2018, 10, 6, 17, 48, 53, 746, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local), 0m, new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local), 0m, new DateTime(2018, 10, 6, 17, 48, 53, 748, DateTimeKind.Local) });
        }
    }
}
