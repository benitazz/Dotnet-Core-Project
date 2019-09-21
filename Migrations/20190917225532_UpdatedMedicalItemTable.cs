using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class UpdatedMedicalItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_Publications_PublicationTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_NappiCodes_NappiCodeId",
                table: "MedicalItems");

            migrationBuilder.RenameColumn(
                name: "PublicationTypeId",
                table: "MedicalItemPublications",
                newName: "PublicationId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_MedicalItemId_PublicationTypeId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_MedicalItemId_PublicationId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_PublicationTypeId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_PublicationId");

            migrationBuilder.AlterColumn<int>(
                name: "NappiCodeId",
                table: "MedicalItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 172, DateTimeKind.Local).AddTicks(7610), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5887), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5918), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5922), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5934), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5941), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5945), new DateTime(2019, 9, 18, 0, 55, 30, 174, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2473), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2519), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2523), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2527), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2531), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2534), new DateTime(2019, 9, 18, 0, 55, 30, 180, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6190), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6248), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6252), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6255), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259), new DateTime(2019, 9, 18, 0, 55, 30, 202, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1593), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1655), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1659), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1663), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1666), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1666), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1670), new DateTime(2019, 9, 18, 0, 55, 30, 237, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5195), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5233), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5237), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5241), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245), new DateTime(2019, 9, 18, 0, 55, 30, 233, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1769), new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1800), new DateTime(2019, 9, 18, 0, 55, 30, 183, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(6065), new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(7959), new DateTime(2019, 9, 18, 0, 55, 30, 189, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_Publications_PublicationId",
                table: "MedicalItemPublications",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_NappiCodes_NappiCodeId",
                table: "MedicalItems",
                column: "NappiCodeId",
                principalTable: "NappiCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_Publications_PublicationId",
                table: "MedicalItemPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_NappiCodes_NappiCodeId",
                table: "MedicalItems");

            migrationBuilder.RenameColumn(
                name: "PublicationId",
                table: "MedicalItemPublications",
                newName: "PublicationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_MedicalItemId_PublicationId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_MedicalItemId_PublicationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItemPublications_PublicationId",
                table: "MedicalItemPublications",
                newName: "IX_MedicalItemPublications_PublicationTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "NappiCodeId",
                table: "MedicalItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 701, DateTimeKind.Local).AddTicks(6815), new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4783), new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4810), new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4817), new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4825), new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4833), new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4840), new DateTime(2019, 9, 15, 15, 43, 5, 704, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(7938), new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8007), new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8015), new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8023), new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8030), new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8038), new DateTime(2019, 9, 15, 15, 43, 5, 712, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3483), new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3529), new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3533), new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3533), new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3537), new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3541), new DateTime(2019, 9, 15, 15, 43, 5, 740, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5602), new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5633), new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5637), new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5640), new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5640), new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5671), new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5671), new DateTime(2019, 9, 15, 15, 43, 5, 799, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5705), new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5747), new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5751), new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5755), new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5755), new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5759), new DateTime(2019, 9, 15, 15, 43, 5, 795, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 719, DateTimeKind.Local).AddTicks(2031), new DateTime(2019, 9, 15, 15, 43, 5, 719, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 719, DateTimeKind.Local).AddTicks(2073), new DateTime(2019, 9, 15, 15, 43, 5, 719, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 726, DateTimeKind.Local).AddTicks(8739), new DateTime(2019, 9, 15, 15, 43, 5, 726, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 43, 5, 727, DateTimeKind.Local).AddTicks(1341), new DateTime(2019, 9, 15, 15, 43, 5, 727, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_Publications_PublicationTypeId",
                table: "MedicalItemPublications",
                column: "PublicationTypeId",
                principalTable: "Publications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_NappiCodes_NappiCodeId",
                table: "MedicalItems",
                column: "NappiCodeId",
                principalTable: "NappiCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
