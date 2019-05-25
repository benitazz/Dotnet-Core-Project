using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class seedpublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 35, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 36, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 39, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "From", "IsDeleted", "Name", "NormalizedDescription", "NormalizedName", "To", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Renal Care Tariffs", null, false, "Renal Care", "RENALCARETARIFFS", "RENALCARE", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 6, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "General Practioner Tariffs", null, false, "General Practioner", "GENERALPRACTIONERTARIFFS", "GENERALPRACTIONER", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 5, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Private Ambulance Tariffs", null, false, "Private Ambulance", "PRIVATEAMBULANCETARIFFS", "PRIVATEAMBULANCE", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 4, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Physiotherapist tariffs", null, false, "Physiotherapist", "PHYSIOTHERAPISTTARIFFS", "PHYSIOTHERAPIST", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 3, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Dentists tarrifs", null, false, "Dentist", "DENTISTSTARRIFS", "DENTIST", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 2, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Radiologists Tariffs", null, false, "Radiologist", "RADIOLOGISTSTARIFFS", "RADIOLOGIST", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 1, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Chiropractor Tariffs", null, false, "Chiropractor", "CHIROPRACTORTARIFFS", "CHIROPRACTOR", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 9, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Wound Care Tariffs", null, false, "Wound Care", "WOUNDCARETARIFFS", "WOUNDCARE", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) },
                    { 8, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local), "Social Worker Tariffs", null, false, "Social Worker", "SOCIALWORKERTARIFFS", "SOCIALWORKER", null, "Administrator", new DateTime(2019, 5, 25, 21, 54, 41, 43, DateTimeKind.Local) }
                });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 54, 41, 47, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 50, DateTimeKind.Local), 0.14m, new DateTime(2019, 5, 25, 21, 54, 41, 50, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 54, 41, 50, DateTimeKind.Local), 0.15m, new DateTime(2019, 5, 25, 21, 54, 41, 50, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 554, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local), 0m, new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Percentage", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local), 0m, new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local) });
        }
    }
}
