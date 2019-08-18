using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class RenameNappiCodeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_NappiCodeTypes_NappiCodeTypeId",
                table: "MedicalItems");

            migrationBuilder.DropTable(
                name: "NappiCodeTypes");

            migrationBuilder.RenameColumn(
                name: "NappiCodeTypeId",
                table: "MedicalItems",
                newName: "NappiCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItems_NappiCodeTypeId",
                table: "MedicalItems",
                newName: "IX_MedicalItems_NappiCodeId");

            migrationBuilder.CreateTable(
                name: "NappiCodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Code = table.Column<string>(nullable: true),
                    Schedule = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    DosageTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NappiCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NappiCodes_DosageTypes_DosageTypeId",
                        column: x => x.DosageTypeId,
                        principalTable: "DosageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NappiCodes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 742, DateTimeKind.Local).AddTicks(9193), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8217), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8248), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8260), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8268), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8275), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8279), new DateTime(2019, 8, 11, 21, 10, 36, 747, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7363), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7409), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7413), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7417), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7421), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7425), new DateTime(2019, 8, 11, 21, 10, 36, 753, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3627), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3677), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3681), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3681), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3685), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3688), new DateTime(2019, 8, 11, 21, 10, 36, 778, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 10, "100055", 1, 10, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 9, "100047", 3, 9, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 8, "100040", 2, 8, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 7, "100039", 1, 7, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 6, "100032", 1, 6, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 5, "100024", 1, 5, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 4, "100016", 1, 4, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 3, "100008", 1, 3, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 2, "100001", 1, 2, null });

            migrationBuilder.InsertData(
                table: "NappiCodes",
                columns: new[] { "Id", "Code", "DosageTypeId", "ProductId", "Schedule" },
                values: new object[] { 1, "Unknown", 1, 1, null });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8120), new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8170), new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8170), new DateTime(2019, 8, 11, 21, 10, 36, 813, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9473), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9538), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9546), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9550), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9550), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9554), new DateTime(2019, 8, 11, 21, 10, 36, 809, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(2556), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3460), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3480), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3491), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3495), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3499), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3499), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3503), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3506), new DateTime(2019, 8, 11, 21, 10, 36, 803, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6072), new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6114), new DateTime(2019, 8, 11, 21, 10, 36, 757, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(6376), new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(8077), new DateTime(2019, 8, 11, 21, 10, 36, 766, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.CreateIndex(
                name: "IX_NappiCodes_DosageTypeId",
                table: "NappiCodes",
                column: "DosageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NappiCodes_ProductId",
                table: "NappiCodes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_NappiCodes_NappiCodeId",
                table: "MedicalItems",
                column: "NappiCodeId",
                principalTable: "NappiCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_NappiCodes_NappiCodeId",
                table: "MedicalItems");

            migrationBuilder.DropTable(
                name: "NappiCodes");

            migrationBuilder.RenameColumn(
                name: "NappiCodeId",
                table: "MedicalItems",
                newName: "NappiCodeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItems_NappiCodeId",
                table: "MedicalItems",
                newName: "IX_MedicalItems_NappiCodeTypeId");

            migrationBuilder.CreateTable(
                name: "NappiCodeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    DosageTypeId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    NappiCode = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Schedule = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NappiCodeTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NappiCodeTypes_DosageTypes_DosageTypeId",
                        column: x => x.DosageTypeId,
                        principalTable: "DosageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NappiCodeTypes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 920, DateTimeKind.Local).AddTicks(4822), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8700), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8719), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8723), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8730), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8734), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8738), new DateTime(2019, 8, 11, 17, 15, 10, 921, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4281), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4320), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4324), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4327), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4331), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4335), new DateTime(2019, 8, 11, 17, 15, 10, 925, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5129), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5175), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5179), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5183), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5183), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5187), new DateTime(2019, 8, 11, 17, 15, 10, 943, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 10, 1, "100055", 10, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 9, 3, "100047", 9, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 8, 2, "100040", 8, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 7, 1, "100039", 7, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 6, 1, "100032", 6, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 5, 1, "100024", 5, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 4, 1, "100016", 4, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 3, 1, "100008", 3, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 2, 1, "100001", 2, null });

            migrationBuilder.InsertData(
                table: "NappiCodeTypes",
                columns: new[] { "Id", "DosageTypeId", "NappiCode", "ProductId", "Schedule" },
                values: new object[] { 1, 1, "Unknown", 1, null });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7238), new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7284), new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7288), new DateTime(2019, 8, 11, 17, 15, 10, 966, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3007), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3042), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3050), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3050), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3054), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3057), new DateTime(2019, 8, 11, 17, 15, 10, 963, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(8578), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9717), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9736), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9740), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9744), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9748), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9752), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9756), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9760), new DateTime(2019, 8, 11, 17, 15, 10, 957, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5271), new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5305), new DateTime(2019, 8, 11, 17, 15, 10, 928, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 932, DateTimeKind.Local).AddTicks(9580), new DateTime(2019, 8, 11, 17, 15, 10, 932, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 11, 17, 15, 10, 933, DateTimeKind.Local).AddTicks(850), new DateTime(2019, 8, 11, 17, 15, 10, 933, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.CreateIndex(
                name: "IX_NappiCodeTypes_DosageTypeId",
                table: "NappiCodeTypes",
                column: "DosageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NappiCodeTypes_ProductId",
                table: "NappiCodeTypes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_NappiCodeTypes_NappiCodeTypeId",
                table: "MedicalItems",
                column: "NappiCodeTypeId",
                principalTable: "NappiCodeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
