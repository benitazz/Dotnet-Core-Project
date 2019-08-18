using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RemovedNameConstraintInPractitioner2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Practitioners_Name",
                table: "Practitioners");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 441, DateTimeKind.Local).AddTicks(475), new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4252), new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4271), new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4275), new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4279), new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4283), new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4287), new DateTime(2019, 8, 17, 2, 36, 42, 442, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9354), new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9381), new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9385), new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9388), new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9392), new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9396), new DateTime(2019, 8, 17, 2, 36, 42, 445, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1437), new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1491), new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1495), new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1499), new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1503), new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1503), new DateTime(2019, 8, 17, 2, 36, 42, 467, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5057), new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5119), new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5123), new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5123), new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5127), new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5130), new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5134), new DateTime(2019, 8, 17, 2, 36, 42, 515, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8180), new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8245), new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8249), new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8253), new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8253), new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8257), new DateTime(2019, 8, 17, 2, 36, 42, 507, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 498, DateTimeKind.Local).AddTicks(9385), new DateTime(2019, 8, 17, 2, 36, 42, 498, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1768), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1791), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1799), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1802), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1806), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1810), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1814), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1822), new DateTime(2019, 8, 17, 2, 36, 42, 499, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 450, DateTimeKind.Local).AddTicks(5329), new DateTime(2019, 8, 17, 2, 36, 42, 450, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 450, DateTimeKind.Local).AddTicks(5368), new DateTime(2019, 8, 17, 2, 36, 42, 450, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 455, DateTimeKind.Local).AddTicks(4751), new DateTime(2019, 8, 17, 2, 36, 42, 455, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 36, 42, 455, DateTimeKind.Local).AddTicks(6891), new DateTime(2019, 8, 17, 2, 36, 42, 455, DateTimeKind.Local).AddTicks(6895) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 138, DateTimeKind.Local).AddTicks(6636), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(752), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(771), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(775), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(779), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(783), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(787), new DateTime(2019, 8, 17, 2, 8, 44, 140, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9523), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9566), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9569), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9573), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9577), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9693), new DateTime(2019, 8, 17, 2, 8, 44, 144, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5153), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5199), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5203), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5203), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5207), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5211), new DateTime(2019, 8, 17, 2, 8, 44, 161, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1252), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1283), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1283), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1286), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1294), new DateTime(2019, 8, 17, 2, 8, 44, 183, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8538), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8569), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8572), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8572), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8576), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8580), new DateTime(2019, 8, 17, 2, 8, 44, 179, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(3505), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4341), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4352), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4356), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4360), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4360), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4364), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368), new DateTime(2019, 8, 17, 2, 8, 44, 176, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6440), new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6467), new DateTime(2019, 8, 17, 2, 8, 44, 147, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(337), new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(1704), new DateTime(2019, 8, 17, 2, 8, 44, 152, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.CreateIndex(
                name: "IX_Practitioners_Name",
                table: "Practitioners",
                column: "Name",
                unique: true);
        }
    }
}
