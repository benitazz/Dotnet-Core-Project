using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace switchapi.Migrations
{
    public partial class AddedProductUnknownData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 104, DateTimeKind.Local).AddTicks(8820), new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9426), new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9457), new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9465), new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9476), new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9480), new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9488), new DateTime(2019, 8, 11, 15, 43, 45, 106, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7604), new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7662), new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7670), new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7673), new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7681), new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7685), new DateTime(2019, 8, 11, 15, 43, 45, 113, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "Unknown", "Unknown", "UNKNOWN", "UNKNOWN" });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "AMW", "AMW", "AMW", "AMW" });

            migrationBuilder.InsertData(
                table: "ManufactureTypes",
                columns: new[] { "Id", "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { 3, "MGP", "MGP", "MGP", "MGP" });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8869), new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8938), new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8946), new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8950), new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8953), new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8957), new DateTime(2019, 8, 11, 15, 43, 45, 147, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 188, DateTimeKind.Local).AddTicks(4183), new DateTime(2019, 8, 11, 15, 43, 45, 188, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 188, DateTimeKind.Local).AddTicks(4237), new DateTime(2019, 8, 11, 15, 43, 45, 188, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 188, DateTimeKind.Local).AddTicks(4241), new DateTime(2019, 8, 11, 15, 43, 45, 188, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4449), new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4530), new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4549), new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4553), new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4557), new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4560), new DateTime(2019, 8, 11, 15, 43, 45, 182, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PackSize",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(2468), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3750), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3770), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3777), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3781), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3785), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3789), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3793), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3797), new DateTime(2019, 8, 11, 15, 43, 45, 175, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 120, DateTimeKind.Local).AddTicks(3829), new DateTime(2019, 8, 11, 15, 43, 45, 120, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 120, DateTimeKind.Local).AddTicks(3887), new DateTime(2019, 8, 11, 15, 43, 45, 120, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 129, DateTimeKind.Local).AddTicks(4564), new DateTime(2019, 8, 11, 15, 43, 45, 129, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 43, 45, 129, DateTimeKind.Local).AddTicks(6254), new DateTime(2019, 8, 11, 15, 43, 45, 129, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManufactureTypeId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 324, DateTimeKind.Local).AddTicks(2883), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5898), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5944), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5952), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5956), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5964), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5971), new DateTime(2019, 8, 11, 15, 28, 54, 325, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9180), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9219), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9223), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9226), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9230), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9234), new DateTime(2019, 8, 11, 15, 28, 54, 329, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "AMW", "AMW", "AMW", "AMW" });

            migrationBuilder.UpdateData(
                table: "ManufactureTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "NormalizedDescription", "NormalizedName" },
                values: new object[] { "MGP", "MGP", "MGP", "MGP" });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5248), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5298), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5302), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5309), new DateTime(2019, 8, 11, 15, 28, 54, 348, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1087), new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1121), new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1125), new DateTime(2019, 8, 11, 15, 28, 54, 372, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9489), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9531), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9539), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9539), new DateTime(2019, 8, 11, 15, 28, 54, 368, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PackSize",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManufactureTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManufactureTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(4517), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5153), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5164), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5168), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5172), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5172), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5176), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179), new DateTime(2019, 8, 11, 15, 28, 54, 364, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(142), new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(177), new DateTime(2019, 8, 11, 15, 28, 54, 333, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(1489), new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(2755), new DateTime(2019, 8, 11, 15, 28, 54, 338, DateTimeKind.Local).AddTicks(2763) });
        }
    }
}
