using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class UpdatePractionerGroupType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PractitionerGroupTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 7, "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7101), "RAD discipline", "RAD", "RAD DISCIPLINE", "RAD", "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.InsertData(
                table: "PractitionerGroupTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 6, "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7097), "PRS discipline", "PRS", "PRS DISCIPLINE", "PRS", "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.InsertData(
                table: "PractitionerGroupTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 5, "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7097), "PHR discipline", "PHR", "PHR DISCIPLINE", "PHR", "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.InsertData(
                table: "PractitionerGroupTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 4, "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7093), "HOS discipline", "HOS", "HOS DISCIPLINE", "HOS", "Administrator", new DateTime(2019, 8, 17, 1, 34, 1, 620, DateTimeKind.Local).AddTicks(7093) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 697, DateTimeKind.Local).AddTicks(2621), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5375), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5391), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5395), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5398), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5402), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5406), new DateTime(2019, 8, 17, 1, 32, 1, 698, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4010), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4052), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4056), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4060), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4064), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4067), new DateTime(2019, 8, 17, 1, 32, 1, 702, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7034), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7080), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7084), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7088), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092), new DateTime(2019, 8, 17, 1, 32, 1, 718, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8199), new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8222), new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8226), new DateTime(2019, 8, 17, 1, 32, 1, 738, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1414), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1452), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1456), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1456), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1460), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1464), new DateTime(2019, 8, 17, 1, 32, 1, 736, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2287), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2879), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2891), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2899), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2902), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2926), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2926), new DateTime(2019, 8, 17, 1, 32, 1, 732, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4876), new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4914), new DateTime(2019, 8, 17, 1, 32, 1, 705, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(6421), new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(8004), new DateTime(2019, 8, 17, 1, 32, 1, 709, DateTimeKind.Local).AddTicks(8007) });
        }
    }
}
