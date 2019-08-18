using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class addedUniqueConditionPractionerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 365, DateTimeKind.Local).AddTicks(8906), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2691), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2706), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2710), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2714), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2718), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2721), new DateTime(2019, 8, 17, 1, 51, 5, 367, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2719), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2769), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2777), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2781), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2784), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2792), new DateTime(2019, 8, 17, 1, 51, 5, 371, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2469), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2535), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2539), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2539), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2543), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2546), new DateTime(2019, 8, 17, 1, 51, 5, 389, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4579), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4610), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4614), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4618), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4618), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4622), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4625), new DateTime(2019, 8, 17, 1, 51, 5, 418, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9375), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9409), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9413), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9413), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9417), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9421), new DateTime(2019, 8, 17, 1, 51, 5, 414, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(7468), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8484), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8503), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8515), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8518), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8522), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8526), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8534), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8534), new DateTime(2019, 8, 17, 1, 51, 5, 410, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5233), new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5279), new DateTime(2019, 8, 17, 1, 51, 5, 374, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(6349), new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(7608), new DateTime(2019, 8, 17, 1, 51, 5, 379, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.CreateIndex(
                name: "IX_Practitioners_Name_Description",
                table: "Practitioners",
                columns: new[] { "Name", "Description" },
                unique: true,
                filter: "[Description] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Practitioners_Name_Description",
                table: "Practitioners");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 570, DateTimeKind.Local).AddTicks(8051), new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4285), new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4312), new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4319), new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4377), new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4385), new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4389), new DateTime(2019, 8, 17, 1, 34, 1, 572, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8694), new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8740), new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8744), new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8748), new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8752), new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8756), new DateTime(2019, 8, 17, 1, 34, 1, 576, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(3959), new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4005), new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4009), new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4013), new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4013), new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4017), new DateTime(2019, 8, 17, 1, 34, 1, 596, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7051), new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7089), new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7093), new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7093), new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7097), new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7097), new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7101), new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4931), new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4954), new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4958), new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4962), new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4962), new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4966), new DateTime(2019, 8, 17, 1, 34, 1, 615, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(3845), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4823), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4835), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4839), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4842), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4846), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4846), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4850), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4854), new DateTime(2019, 8, 17, 1, 34, 1, 612, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 580, DateTimeKind.Local).AddTicks(1631), new DateTime(2019, 8, 17, 1, 34, 1, 580, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 580, DateTimeKind.Local).AddTicks(1682), new DateTime(2019, 8, 17, 1, 34, 1, 580, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 586, DateTimeKind.Local).AddTicks(4889), new DateTime(2019, 8, 17, 1, 34, 1, 586, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 34, 1, 586, DateTimeKind.Local).AddTicks(6321), new DateTime(2019, 8, 17, 1, 34, 1, 586, DateTimeKind.Local).AddTicks(6325) });
        }
    }
}
