using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class updatedPublicationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_PublicationTypes_PublicationTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropTable(
                name: "PublicationTypes");

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Description = table.Column<string>(nullable: false),
                    NormalizedDescription = table.Column<string>(nullable: false),
                    PublicationNo = table.Column<string>(maxLength: 15, nullable: false)
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

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 56, "UNKNOWN", "UNKNOWN", "P56" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 39, "PSYCHOMETRY AND REGISTERED COUNCELLORS", "PSYCHOMETRYANDREGISTEREDCOUNCELLORS", "P39" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 38, "UNIFORM PATIENT FEE SCHEDULE", "UNIFORMPATIENTFEESCHEDULE", "P38" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 37, "OPTOMETRISTS", "OPTOMETRISTS", "P37" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 36, "SUB ACUTE FACILITIES", "SUBACUTEFACILITIES", "P36" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 35, "HOSPICES", "HOSPICES", "P35" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 33, "MENTAL HEALTH INSTITUTIONS", "MENTALHEALTHINSTITUTIONS", "P33" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 40, "OSTEOPATHY", "OSTEOPATHY", "P40" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 32, "PHYSICAL REHABILITATION HOSPITALS", "PHYSICALREHABILITATIONHOSPITALS", "P32" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 31, "ORTHOTISTS AND PROSTHETISTS", "ORTHOTISTSANDPROSTHETISTS", "P31" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 30, "PHARMACISTS", "PHARMACISTS", "P30" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 29, "RADIOLOGY", "RADIOLOGY", "P29" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 34, "UNATTACHED OPERATING THEATRE UNITS", "UNATTACHEDOPERATINGTHEATREUNITS", "P34" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 41, "PHYTOTHERAPY", "PHYTOTHERAPY", "P41" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 43, "NATUROPATHS", "NATUROPATHS", "P43" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 55, "RMA ORTHOTIST", "RMAORTHOTIST", "P55" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 44, "ACUPUNCTURE AND CHINESE MEDICINE", "ACUPUNCTUREANDCHINESEMEDICINE", "P44" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 45, "THERAPEUTIC REFLEXOLOGY", "THERAPEUTICREFLEXOLOGY", "P45" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 46, "MEDICAL PHYSICISTS", "MEDICALPHYSICISTS", "P46" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 47, "MEDICLINIC", "MEDICLINIC", "P47" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 48, "TEBA", "TEBA", "P48" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 49, "NHN", "NHN", "P49" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 50, "NETCARE", "NETCARE", "P50" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 51, "UNKNOWN / COIDA NORMALISED", "UNKNOWN/COIDANORMALISED", "P51" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 52, "NAPPI", "NAPPI", "P52" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 53, "COID UNIT RATE", "COIDUNITRATE", "P53" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 54, "DR BRUNS", "DRBRUNS", "P54" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 28, "DENTAL - CDT", "DENTAL-CDT", "P28" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 42, "TISSUE TRANSPORTATION", "TISSUETRANSPORTATION", "P42" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 27, "PATHOLOGY", "PATHOLOGY", "P27" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 11, "HOMOEOPATHS", "HOMOEOPATHS", "P10" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 25, "ART THERAPY", "ARTTHERAPY", "P26" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 1, "Unknown Type of Publication", "UNKNOWNTYPEOFPUBLICATION", "" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 2, "MEDICAL PRACTITIONERS", "MEDICALPRACTITIONERS", "P01" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 3, "DENTAL", "DENTAL", "P02" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 4, "AMBULANCE SERVICES", "AMBULANCESERVICES", "P03" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 5, "OCCUPATIONAL AND ART THERAPY", "OCCUPATIONALANDARTTHERAPY", "P04" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 6, "CHIROPRACTORS", "CHIROPRACTORS", "P05" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 7, "CLINICAL TECHNOLOGY", "CLINICALTECHNOLOGY", "P06" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 8, "DIETICIANS", "DIETICIANS", "P07" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 9, "DENTAL THERAPY", "DENTALTHERAPY", "P08" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 26, "DENTAL TECHNICIANS", "DENTALTECHNICIANS", "P18" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 57, "Blood Transfusion", "BLOODTRANSFUSION", "P57" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 12, "REGISTERED NURSES IN PRIVATE PRACTICE", "REGISTEREDNURSESINPRIVATEPRACTICE", "P11" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 10, "HEARING AID ACCOUSTICIANS", "HEARINGAIDACCOUSTICIANS", "P09" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 14, "PODIATRY", "PODIATRY", "P13" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 24, "MEDICAL SCIENTISTS", "MEDICALSCIENTISTS", "P25" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 23, "NURSING AGENCIES", "NURSINGAGENCIES", "P24" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 13, "PHYSIOTHERAPY", "PHYSIOTHERAPY", "P12" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 21, "BIOKINETICS", "BIOKINETICS", "P22" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 20, "ORTHOPTISTS", "ORTHOPTISTS", "P21" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 22, "MEDICAL TECHNOLOGY", "MEDICALTECHNOLOGY", "P23" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 18, "SPEECH THERAPISTS AND AUDIOLOGISTS", "SPEECHTHERAPISTSANDAUDIOLOGISTS", "P17" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 17, "SOCIAL WORKERS IN PRIVATE PRACTICE", "SOCIALWORKERSINPRIVATEPRACTICE", "P16" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 16, "RADIOGRAPHY", "RADIOGRAPHY", "P15" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 15, "PSYCHOLOGY", "PSYCHOLOGY", "P14" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 19, "PRIVATE HOSPITALS", "PRIVATEHOSPITALS", "P20" });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "NormalizedDescription", "PublicationNo" },
                values: new object[] { 58, "Renal Care", "RENALCARE", "P58" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItemPublications_Publications_PublicationTypeId",
                table: "MedicalItemPublications");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.CreateTable(
                name: "PublicationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()"),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedDescription = table.Column<string>(maxLength: 255, nullable: false),
                    NormalizedName = table.Column<string>(maxLength: 255, nullable: false),
                    PublicationNo = table.Column<string>(maxLength: 15, nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "'Administrator'"),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GetDate()")
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
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 143, DateTimeKind.Local).AddTicks(4188), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7116), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7135), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7139), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7143), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7147), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7150), new DateTime(2019, 9, 13, 7, 4, 31, 144, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4687), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4718), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4722), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4726), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4730), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4734), new DateTime(2019, 9, 13, 7, 4, 31, 148, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1007), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1057), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1061), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1061), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1065), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1069), new DateTime(2019, 9, 13, 7, 4, 31, 165, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9319), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9358), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9362), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9369), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9396), new DateTime(2019, 9, 13, 7, 4, 31, 186, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1804), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1839), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1843), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1850), new DateTime(2019, 9, 13, 7, 4, 31, 183, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 7, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651), "Renal Care Tariffs", "Renal Care", "RENALCARETARIFFS", "RENALCARE", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 6, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651), "General Practioner Tariffs", "General Practioner", "GENERALPRACTIONERTARIFFS", "GENERALPRACTIONER", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 5, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3647), "Private Ambulance Tariffs", "Private Ambulance", "PRIVATEAMBULANCETARIFFS", "PRIVATEAMBULANCE", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 4, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3643), "Physiotherapist tariffs", "Physiotherapist", "PHYSIOTHERAPISTTARIFFS", "PHYSIOTHERAPIST", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3639), "Dentists tarrifs", "Dentist", "DENTISTSTARRIFS", "DENTIST", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 9, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3655), "Wound Care Tariffs", "Wound Care", "WOUNDCARETARIFFS", "WOUNDCARE", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3012), "Chiropractor Tariffs", "Chiropractor", "CHIROPRACTORTARIFFS", "CHIROPRACTOR", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 8, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3655), "Social Worker Tariffs", "Social Worker", "SOCIALWORKERTARIFFS", "SOCIALWORKER", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.InsertData(
                table: "PublicationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "NormalizedDescription", "NormalizedName", "PublicationNo", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3628), "Radiologists Tariffs", "Radiologist", "RADIOLOGISTSTARIFFS", "RADIOLOGIST", "11111", "Administrator", new DateTime(2019, 9, 13, 7, 4, 31, 179, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1643), new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1666), new DateTime(2019, 9, 13, 7, 4, 31, 151, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(3789), new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(5113), new DateTime(2019, 9, 13, 7, 4, 31, 155, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItemPublications_PublicationTypes_PublicationTypeId",
                table: "MedicalItemPublications",
                column: "PublicationTypeId",
                principalTable: "PublicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
