using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class practitionerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 280, DateTimeKind.Local).AddTicks(3970), new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3523), new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3566), new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3577), new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3585), new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3593), new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3600), new DateTime(2019, 8, 24, 19, 22, 1, 282, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3775), new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3867), new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3879), new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3886), new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3894), new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3898), new DateTime(2019, 8, 24, 19, 22, 1, 295, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(26), new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(115), new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(122), new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(126), new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(134), new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(138), new DateTime(2019, 8, 24, 19, 22, 1, 342, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1715), new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1780), new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1784), new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1788), new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1792), new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1796), new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1796), new DateTime(2019, 8, 24, 19, 22, 1, 427, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3201), new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3309), new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3321), new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3325), new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3325), new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3332), new DateTime(2019, 8, 24, 19, 22, 1, 416, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 168, "Osteopathy", false, 0.0, "41200", "Osteopathy", "OSTEOPATHY", "OSTEOPATHY", "102000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 167, "Naturopathy", false, 0.0, "41100", "Naturopathy", "NATUROPATHY", "NATUROPATHY", "101000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 166, "Chinese Medicine & Acupuncture", false, 0.0, "41000", "Chinese Medicine & Acupuncture", "CHINESEMEDICINE&ACUPUNCTURE", "CHINESEMEDICINE&ACUPUNCTURE", "105000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 165, "Ayurveda Practitioner", false, 0.0, "40900", "Ayurveda Practitioner", "AYURVEDAPRACTITIONER", "AYURVEDAPRACTITIONER", "104000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 160, "Dental Technology", false, 0.0, "49300", "Dental Technology", "DENTALTECHNOLOGY", "DENTALTECHNOLOGY", "93000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 163, "Medicine : Clinical Haematology", false, 0.0, "11805", "Medicine : Clinical Haematology", "MEDICINE:CLINICALHAEMATOLOGY", "MEDICINE:CLINICALHAEMATOLOGY", "18001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 162, "Community Health", false, 0.0, "19700", "Community Health", "COMMUNITYHEALTH", "COMMUNITYHEALTH", "97000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 161, "Community Dentistry", false, 0.0, "29600", "Community Dentistry", "COMMUNITYDENTISTRY", "COMMUNITYDENTISTRY", "96000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 169, "Phytotherapy", false, 0.0, "41300", "Phytotherapy", "PHYTOTHERAPY", "PHYTOTHERAPY", "103000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 159, "Ambulance Services - Other", false, 0.0, "51300", "Ambulance Services - Other", "AMBULANCESERVICES-OTHER", "AMBULANCESERVICES-OTHER", "91", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 164, "Designated Specialists", true, 0.0, "19999", "Designated Specialists", "DESIGNATEDSPECIALISTS", "DESIGNATEDSPECIALISTS", "19999", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 170, "Therapeutic Aromatherapy", false, 0.0, "41400", "Therapeutic Aromatherapy", "THERAPEUTICAROMATHERAPY", "THERAPEUTICAROMATHERAPY", "106000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 176, "Private Hospitals (A - Status)(State subsidised)", false, 0.0, "57200", "Private Hospitals (A - Status)(State subsidised)", "PRIVATEHOSPITALS(A-STATUS)(STATESUBSIDISED)", "PRIVATEHOSPITALS(A-STATUS)(STATESUBSIDISED)", "57200", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 172, "Therapeutic Reflexology", false, 0.0, "41600", "Therapeutic Reflexology", "THERAPEUTICREFLEXOLOGY", "THERAPEUTICREFLEXOLOGY", "108000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 173, "Unani-Tibb", false, 0.0, "41700", "Unani-Tibb", "UNANI-TIBB", "UNANI-TIBB", "109000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 174, "Registered Counsellors", false, 0.0, "38100", "Registered Counsellors", "REGISTEREDCOUNSELLORS", "REGISTEREDCOUNSELLORS", "81000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 178, "Sub Acute Facilities", false, 0.0, "54908", "Sub-Acute Facilities : Specialised Psychiatric Uni", "SUBACUTEFACILITIES", "SUB-ACUTEFACILITIES:SPECIALISEDPSYCHIATRICUNI", "49008", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 180, "Supplementary Optometrists", false, 0.0, "37001", "Supplementary Optometrists", "SUPPLEMENTARYOPTOMETRISTS", "SUPPLEMENTARYOPTOMETRISTS", "70001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 184, "Consulting Specialists", true, 0.0, "10070", "Consulting Specialists", "CONSULTINGSPECIALISTS", "CONSULTINGSPECIALISTS", "10070", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 187, "Clinical services : Supplementary", false, 0.0, "59014", "Clinical services : Supplementary", "CLINICALSERVICES:SUPPLEMENTARY", "CLINICALSERVICES:SUPPLEMENTARY", "90014", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 188, "Parenteral Nutrition (TPN) - Homecare", false, 0.0, "59015", "Parenteral Nutrition (TPN) - Homecare", "PARENTERALNUTRITION(TPN)-HOMECARE", "PARENTERALNUTRITION(TPN)-HOMECARE", "90015", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 189, "Private Hospitals : Mine Hospitals", false, 0.0, "55710", "Private Hospitals : Mine Hospitals", "PRIVATEHOSPITALS:MINEHOSPITALS", "PRIVATEHOSPITALS:MINEHOSPITALS", "57100", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 190, "Surgical Specialists", true, 0.0, "10080", "Surgical Specialists", "SURGICALSPECIALISTS", "SURGICALSPECIALISTS", "10080", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 192, "Gynaecology : Critical Care", true, 0.0, "11600", "Gynaecology : Critical Care", "GYNAECOLOGY:CRITICALCARE", "GYNAECOLOGY:CRITICALCARE", "16001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 158, "Psychometry", false, 0.0, "38500", "Psychometry", "PSYCHOMETRY", "PSYCHOMETRY", "85000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 171, "Therapeutic Massage Therapy", false, 0.0, "41500", "Therapeutic Massage Therapy", "THERAPEUTICMASSAGETHERAPY", "THERAPEUTICMASSAGETHERAPY", "107000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 157, "Masseurs", false, 0.0, "37300", "Masseurs", "MASSEURS", "MASSEURS", "73000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 141, "Paediatric Surgery", false, 0.0, "14201", "Paediatric Surgery", "PAEDIATRICSURGERY", "PAEDIATRICSURGERY", "42004", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 155, "Pharmacotherapy", false, 0.0, "46100", "Pharmacotherapy", "PHARMACOTHERAPY", "PHARMACOTHERAPY", "61000", 5 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 130, "Pathology (Haematological)", false, 0.0, "15400", "Pathology (Haematological)", "PATHOLOGY(HAEMATOLOGICAL)", "PATHOLOGY(HAEMATOLOGICAL)", "52005", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 131, "Pathology (Microbiological)", false, 0.0, "15500", "Pathology (Microbiological)", "PATHOLOGY(MICROBIOLOGICAL)", "PATHOLOGY(MICROBIOLOGICAL)", "52007", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 132, "Pathology (Virological)", false, 0.0, "15600", "Pathology (Virological)", "PATHOLOGY(VIROLOGICAL)", "PATHOLOGY(VIROLOGICAL)", "52009", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 133, "Child Psychiatry", false, 0.0, "12201", "Child Psychiatry", "CHILDPSYCHIATRY", "CHILDPSYCHIATRY", "22001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 134, "Critical Care", false, 0.0, "11001", "Critical Care", "CRITICALCARE", "CRITICALCARE", "35000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 135, "Endocrinology", true, 0.0, "11801", "Endocrinology", "ENDOCRINOLOGY", "ENDOCRINOLOGY", "18004", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 136, "Geriatric Medicine", false, 0.0, "11802", "Geriatric Medicine", "GERIATRICMEDICINE", "GERIATRICMEDICINE", "18007", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 137, "Medical Genetics", false, 0.0, "11803", "Medical Genetics", "MEDICALGENETICS", "MEDICALGENETICS", "18008", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 138, "Neonatology", false, 0.0, "13203", "Neonatology", "NEONATOLOGY", "NEONATOLOGY", "32008", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 139, "Nephrology", true, 0.0, "11804", "Nephrology", "NEPHROLOGY", "NEPHROLOGY", "18002", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 140, "Occupational Health", false, 0.0, "19701", "Occupational Health", "OCCUPATIONALHEALTH", "OCCUPATIONALHEALTH", "29000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 193, "Gynaecology : Gynaecological Oncology", false, 0.0, "11600", "Gynaecology : Gynaecological Oncology", "GYNAECOLOGY:GYNAECOLOGICALONCOLOGY", "GYNAECOLOGY:GYNAECOLOGICALONCOLOGY", "16002", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 142, "Vascular Surgery", true, 0.0, "14202", "Vascular Surgery", "VASCULARSURGERY", "VASCULARSURGERY", "42001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 143, "Hospices : SANCA", false, 0.0, "57901", "Hospices : SANCA", "HOSPICES:SANCA", "HOSPICES:SANCA", "79001", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 144, "Speech Therapy", true, 0.0, "38201", "Speech Therapy", "SPEECHTHERAPY", "SPEECHTHERAPY", "82001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 145, "Audiology", true, 0.0, "38202", "Audiology", "AUDIOLOGY", "AUDIOLOGY", "82002", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 146, "Registered nurses : Midwife", false, 0.0, "48801", "Registered nurses : Midwife", "REGISTEREDNURSES:MIDWIFE", "REGISTEREDNURSES:MIDWIFE", "88001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 147, "Registered nurses : Psychiatric", false, 0.0, "48802", "Registered nurses : Psychiatric", "REGISTEREDNURSES:PSYCHIATRIC", "REGISTEREDNURSES:PSYCHIATRIC", "88002", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 148, "Registered nurses : Primary Care", true, 0.0, "48809", "Registered nurses : Primary Care", "REGISTEREDNURSES:PRIMARYCARE", "REGISTEREDNURSES:PRIMARYCARE", "88009", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 149, "Accredited Blood and Blood Product Couriers", false, 0.0, "50300", "Accredited Blood and Blood Product Couriers", "ACCREDITEDBLOODANDBLOODPRODUCTCOURIERS", "ACCREDITEDBLOODANDBLOODPRODUCTCOURIERS", "3000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 150, "Clinical Haemotology", false, 0.0, "12700", "Clinical Haemotology", "CLINICALHAEMOTOLOGY", "CLINICALHAEMOTOLOGY", "27000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 151, "Rheumatology", true, 0.0, "13100", "Rheumatology", "RHEUMATOLOGY", "RHEUMATOLOGY", "31000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 152, "Drug & Alcohol Rehabilitation", false, 0.0, "54700", "Drug & Alcohol Rehabilitation", "DRUG&ALCOHOLREHABILITATION", "DRUG&ALCOHOLREHABILITATION", "47000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 153, "Group Practices1", true, 0.0, "55000", "Group Practices", "GROUPPRACTICES", "GROUPPRACTICES", "50001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 154, "Group Practices/Hospitals", true, 0.0, "55100", "Group Practices/Hospitals", "GROUPPRACTICES/HOSPITALS", "GROUPPRACTICES/HOSPITALS", "51000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 156, "Medical Scientist", false, 0.0, "36900", "Medical Scientist", "MEDICALSCIENTIST", "MEDICALSCIENTIST", "69", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 194, "Gynaecology : Medical Genetics", false, 0.0, "11600", "Gynaecology : Medical Genetics", "GYNAECOLOGY:MEDICALGENETICS", "GYNAECOLOGY:MEDICALGENETICS", "16003", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 210, "Medical Technologists : Pharmacology", false, 0.0, "37600", "Medical Technologists : Pharmacology", "MEDICALTECHNOLOGISTS:PHARMACOLOGY", "MEDICALTECHNOLOGISTS:PHARMACOLOGY", "37012", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 196, "Gynaecology : Reproductive Medicine", false, 0.0, "11600", "Gynaecology : Reproductive Medicine", "GYNAECOLOGY:REPRODUCTIVEMEDICINE", "GYNAECOLOGY:REPRODUCTIVEMEDICINE", "16005", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 227, "Pulmonology", true, 0.0, "11800", "Independent Practice Subspecialist Medicine", "PULMONOLOGY", "INDEPENDENTPRACTICESUBSPECIALISTMEDICINE", "18005", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 228, "Critical Care", true, 0.0, "11800", "Independent Practice Subspecialist Medicine", "CRITICALCARE", "INDEPENDENTPRACTICESUBSPECIALISTMEDICINE", "18006", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 229, "Infectious Diseases", true, 0.0, "11800", "Independent Practice Subspecialist Medicine", "INFECTIOUSDISEASES", "INDEPENDENTPRACTICESUBSPECIALISTMEDICINE", "18009", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 230, "Gastroenterology", true, 0.0, "11800", "Independent Practice Subspecialist Medicine", "GASTROENTEROLOGY", "INDEPENDENTPRACTICESUBSPECIALISTMEDICINE", "18010", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 231, "Medical Oncology", true, 0.0, "11800", "Independent Practice Subspecialist Medicine", "MEDICALONCOLOGY", "INDEPENDENTPRACTICESUBSPECIALISTMEDICINE", "18011", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 232, "Rheumatology", true, 0.0, "11800", "Independent Practice Subspecialist Medicine", "RHEUMATOLOGY", "INDEPENDENTPRACTICESUBSPECIALISTMEDICINE", "18012", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 233, "Medicine", true, 0.0, "12100", "Cardiology Independent Practice Sub Specialist", "MEDICINE", "CARDIOLOGYINDEPENDENTPRACTICESUBSPECIALIST", "21001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 234, "Paediatrics", false, 0.0, "12100", "Cardiology Independent Practice Sub Specialist", "PAEDIATRICS", "CARDIOLOGYINDEPENDENTPRACTICESUBSPECIALIST", "21002", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 235, "Special Merit", true, 0.0, "12100", "Cardiology Independent Practice Sub Specialist", "SPECIALMERIT", "CARDIOLOGYINDEPENDENTPRACTICESUBSPECIALIST", "21003", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 236, "Critical Care", true, 0.0, "12400", "Independent Practice Sub Specialist Neurosurgery", "CRITICALCARE", "INDEPENDENTPRACTICESUBSPECIALISTNEUROSURGERY", "24001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 237, "Blood Transfusion Technology", false, 0.0, "37600", "Medical technology", "BLOODTRANSFUSIONTECHNOLOGY", "MEDICALTECHNOLOGY", "37001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 238, "Lung Function", true, 0.0, "37600", "Medical technology", "LUNGFUNCTION", "MEDICALTECHNOLOGY", "37009", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 239, "Critical Care", true, 0.0, "14200", "Surgery Independent Practice Sub Specialist", "CRITICALCARE", "SURGERYINDEPENDENTPRACTICESUBSPECIALIST", "42002", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 240, "Gastroenterology", true, 0.0, "14200", "Surgery Independent Practice Sub Specialist", "GASTROENTEROLOGY", "SURGERYINDEPENDENTPRACTICESUBSPECIALIST", "42003", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 241, "Travel Clinic", false, 0.0, "0", "Travel Clinic", "TRAVELCLINIC", "TRAVELCLINIC", "48000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 242, "Group practices", true, 0.0, "55000", "Group practices", "GROUPPRACTICES", "GROUPPRACTICES", "50000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 243, "DOH Orthotics & Prosthetics Centre", false, 0.0, "55600", "Provincial Hospitals", "DOHORTHOTICS&PROSTHETICSCENTRE", "PROVINCIALHOSPITALS", "56010", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 244, "Primary Healthcare Advisor", false, 0.0, "40900", "Ayurveda", "PRIMARYHEALTHCAREADVISOR", "AYURVEDA", "104001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 245, "Yoga Therapist", false, 0.0, "40900", "Ayurveda ", "YOGATHERAPIST", "AYURVEDA", "104002", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 246, "Ambulance Services - Advanced", false, 0.0, "51200", "Ambulance Services - Advanced ", "AMBULANCESERVICES-ADVANCED", "AMBULANCESERVICES-ADVANCED", "9000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 248, "Paediatrics", false, 0.0, "12700", "Clinical Haematology", "PAEDIATRICS", "CLINICALHAEMATOLOGY", "27002", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 249, "Medicine", false, 0.0, "12700", "Clinical Haematology", "MEDICINE", "CLINICALHAEMATOLOGY", "27003", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 250, "Paed. Cardiology", false, 0.0, "13300", "Paed. Cardiology", "PAED.CARDIOLOGY", "PAED.CARDIOLOGY", "33000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 251, "Pathology (Haematological)", false, 0.0, "12700", "Clinical Haematology Independent Practice", "PATHOLOGY(HAEMATOLOGICAL)", "CLINICALHAEMATOLOGYINDEPENDENTPRACTICE", "27001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 252, "", null, 420.0, "NULL", "registered nurse", "", "REGISTEREDNURSE", "88041", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 226, "Cardiology", true, 0.0, "11800", "Independent Practice Subspecialist Medicine", "CARDIOLOGY", "INDEPENDENTPRACTICESUBSPECIALISTMEDICINE", "18003", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 225, "Provincial Ambulance Service", false, 0.0, "51200", "Ambulance Service", "PROVINCIALAMBULANCESERVICE", "AMBULANCESERVICE", "9004", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 224, "Clinical technology : Cardiology", false, 0.0, "37500", "Clinical technology : Cardiology", "CLINICALTECHNOLOGY:CARDIOLOGY", "CLINICALTECHNOLOGY:CARDIOLOGY", "75010", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 223, "Paediatrics : Clinical Haematology", false, 0.0, "13200", "Paediatrics : Clinical Haematology", "PAEDIATRICS:CLINICALHAEMATOLOGY", "PAEDIATRICS:CLINICALHAEMATOLOGY", "32014", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 197, "Gynaecology : Infectious Diseases", false, 0.0, "11600", "Gynaecology : Infectious Diseases", "GYNAECOLOGY:INFECTIOUSDISEASES", "GYNAECOLOGY:INFECTIOUSDISEASES", "16006", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 198, "Pathology : Clinical", false, 0.0, "15300", "Pathology : Clinical", "PATHOLOGY:CLINICAL", "PATHOLOGY:CLINICAL", "52003", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 199, "Pathology : Medical Genetics", false, 0.0, "15300", "Pathology : Medical Genetics", "PATHOLOGY:MEDICALGENETICS", "PATHOLOGY:MEDICALGENETICS", "52006", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 200, "Pathology : Infectious Diseases", false, 0.0, "15300", "Pathology : Infectious Diseases", "PATHOLOGY:INFECTIOUSDISEASES", "PATHOLOGY:INFECTIOUSDISEASES", "52008", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 201, "Medical Technologists : Cardiology", false, 0.0, "37600", "Medical Technologists : Cardiology", "MEDICALTECHNOLOGISTS:CARDIOLOGY", "MEDICALTECHNOLOGISTS:CARDIOLOGY", "37002", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 202, "Medical Technologists : Chemical Pathology", false, 0.0, "37600", "Medical Technologists : Chemical Pathology", "MEDICALTECHNOLOGISTS:CHEMICALPATHOLOGY", "MEDICALTECHNOLOGISTS:CHEMICALPATHOLOGY", "37003", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 203, "Medical Technologists : Clinical Pathology", false, 0.0, "37600", "Medical Technologists : Clinical Pathology", "MEDICALTECHNOLOGISTS:CLINICALPATHOLOGY", "MEDICALTECHNOLOGISTS:CLINICALPATHOLOGY", "37004", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 204, "Medical Technologists : Cytotechnology", false, 0.0, "37600", "Medical Technologists : Cytotechnology", "MEDICALTECHNOLOGISTS:CYTOTECHNOLOGY", "MEDICALTECHNOLOGISTS:CYTOTECHNOLOGY", "37005", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 205, "Medical Technologists : Forensic Pathology", false, 0.0, "37600", "Medical Technologists : Forensic Pathology", "MEDICALTECHNOLOGISTS:FORENSICPATHOLOGY", "MEDICALTECHNOLOGISTS:FORENSICPATHOLOGY", "37006", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 206, "Medical Technologists : Haematology", false, 0.0, "37600", "Medical Technologists : Haematology", "MEDICALTECHNOLOGISTS:HAEMATOLOGY", "MEDICALTECHNOLOGISTS:HAEMATOLOGY", "37007", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 207, "Medical Technologists : Lung Function", true, 0.0, "37600", "Medical Technologists : Lung Function", "MEDICALTECHNOLOGISTS:LUNGFUNCTION", "MEDICALTECHNOLOGISTS:LUNGFUNCTION", "37008", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 208, "Medical Technologists : Microbiology", false, 0.0, "37600", "Medical Technologists : Microbiology", "MEDICALTECHNOLOGISTS:MICROBIOLOGY", "MEDICALTECHNOLOGISTS:MICROBIOLOGY", "37010", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 195, "Gynaecology : Maternal and Foetal Medicine", false, 0.0, "11600", "Gynaecology : Maternal and Foetal Medicine", "GYNAECOLOGY:MATERNALANDFOETALMEDICINE", "GYNAECOLOGY:MATERNALANDFOETALMEDICINE", "16004", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 209, "Medical Technologists : Parasitology", false, 0.0, "37600", "Medical Technologists : Parasitology", "MEDICALTECHNOLOGISTS:PARASITOLOGY", "MEDICALTECHNOLOGISTS:PARASITOLOGY", "37011", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 211, "Medical Technologists : Virology", false, 0.0, "37600", "Medical Technologists : Virology", "MEDICALTECHNOLOGISTS:VIROLOGY", "MEDICALTECHNOLOGISTS:VIROLOGY", "37013", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 212, "Medical Technologists : Immunology", false, 0.0, "37600", "Medical Technologists : Immunology", "MEDICALTECHNOLOGISTS:IMMUNOLOGY", "MEDICALTECHNOLOGISTS:IMMUNOLOGY", "37014", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 213, "Medical Technologists : Radio-Isotope Technology", false, 0.0, "37600", "Medical Technologists : Radio-Isotope Technology", "MEDICALTECHNOLOGISTS:RADIO-ISOTOPETECHNOLOGY", "MEDICALTECHNOLOGISTS:RADIO-ISOTOPETECHNOLOGY", "37015", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 214, "Paediatrics : Medical Oncology", false, 0.0, "13200", "Paediatrics : Medical Oncology", "PAEDIATRICS:MEDICALONCOLOGY", "PAEDIATRICS:MEDICALONCOLOGY", "32003", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 215, "Paediatrics : Infectious Diseases", false, 0.0, "13200", "Paediatrics : Infectious Diseases", "PAEDIATRICS:INFECTIOUSDISEASES", "PAEDIATRICS:INFECTIOUSDISEASES", "32004", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 216, "Paediatrics : Medical Genetics", false, 0.0, "13200", "Paediatrics : Medical Genetics", "PAEDIATRICS:MEDICALGENETICS", "PAEDIATRICS:MEDICALGENETICS", "32005", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 217, "Paediatrics : Endocrinology", false, 0.0, "13200", "Paediatrics : Endocrinology", "PAEDIATRICS:ENDOCRINOLOGY", "PAEDIATRICS:ENDOCRINOLOGY", "32006", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 218, "Paediatrics : Gastroenterology", false, 0.0, "13200", "Paediatrics : Gastroenterology", "PAEDIATRICS:GASTROENTEROLOGY", "PAEDIATRICS:GASTROENTEROLOGY", "32007", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 219, "Paediatrics : Pulmonology", false, 0.0, "13200", "Paediatrics : Pulmonology", "PAEDIATRICS:PULMONOLOGY", "PAEDIATRICS:PULMONOLOGY", "32009", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 220, "Paediatrics : Rheumatology", false, 0.0, "13200", "Paediatrics : Rheumatology", "PAEDIATRICS:RHEUMATOLOGY", "PAEDIATRICS:RHEUMATOLOGY", "32010", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 221, "Paediatrics : Nephrology", false, 0.0, "13200", "Paediatrics : Nephrology", "PAEDIATRICS:NEPHROLOGY", "PAEDIATRICS:NEPHROLOGY", "32011", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 222, "Paediatrics : Critical Care", false, 0.0, "13200", "Paediatrics : Critical Care", "PAEDIATRICS:CRITICALCARE", "PAEDIATRICS:CRITICALCARE", "32012", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 129, "Pathology (Forensic)", false, 0.0, "15100", "Pathology (Forensic)", "PATHOLOGY(FORENSIC)", "PATHOLOGY(FORENSIC)", "52004", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 128, "Pathology (Chemical)", false, 0.0, "15000", "Pathology (Chemical)", "PATHOLOGY(CHEMICAL)", "PATHOLOGY(CHEMICAL)", "52002", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 123, "Clinical services : Employer Primary Care Faciliti", false, 0.0, "59010", "Clinical services : Employer Primary Care Faciliti", "CLINICALSERVICES:EMPLOYERPRIMARYCAREFACILITI", "CLINICALSERVICES:EMPLOYERPRIMARYCAREFACILITI", "90010", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 126, "Clinical services : Diabetes Appliances", true, 0.0, "59013", "Clinical services : Diabetes Appliances", "CLINICALSERVICES:DIABETESAPPLIANCES", "CLINICALSERVICES:DIABETESAPPLIANCES", "90013", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 33, "Maxillo-facial and Oral Surgery", true, 0.0, "26200", "Maxillo-facial and Oral Surgery", "MAXILLO-FACIALANDORALSURGERY", "MAXILLO-FACIALANDORALSURGERY", "62000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 34, "Orthodontics", true, 0.0, "26400", "Orthodontics", "ORTHODONTICS", "ORTHODONTICS", "64000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 35, "Occupational Therapy", true, 0.0, "36600", "Occupational Therapy", "OCCUPATIONALTHERAPY", "OCCUPATIONALTHERAPY", "66000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 36, "Podiatry", true, 0.0, "36800", "Podiatry", "PODIATRY", "PODIATRY", "68000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 37, "OPTOMETRISTS", true, 0.0, "37000", "OPTOMETRISTS", "OPTOMETRISTS", "OPTOMETRISTS", "70000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 38, "ARTIFICAL EYE PRACTITIONER", true, 0.0, "37100", "ARTIFICAL EYE PRACTITIONER", "ARTIFICALEYEPRACTITIONER", "ARTIFICALEYEPRACTITIONER", "71000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 39, "Physiotherapists", true, 0.0, "37200", "Physiotherapists", "PHYSIOTHERAPISTS", "PHYSIOTHERAPISTS", "72000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 40, "Orthoptists", false, 0.0, "37400", "Orthoptists", "ORTHOPTISTS", "ORTHOPTISTS", "74000", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 41, "Clinical Technologists", false, 0.0, "37500", "Clinical Technologists", "CLINICALTECHNOLOGISTS", "CLINICALTECHNOLOGISTS", "75000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 42, "Unattached operating theatres / Day clinics", false, 0.0, "57600", "Unattached operating theatres / Day clinics", "UNATTACHEDOPERATINGTHEATRES/DAYCLINICS", "UNATTACHEDOPERATINGTHEATRES/DAYCLINICS", "76000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 43, "Approved U O T U / Day clinics", false, 0.0, "57700", "Approved U O T U / Day clinics", "APPROVEDUOTU/DAYCLINICS", "APPROVEDUOTU/DAYCLINICS", "77000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 44, "BLOOD TRANSFUSION", false, 0.0, "57800", "BLOOD TRANSFUSION", "BLOODTRANSFUSION", "BLOODTRANSFUSION", "78000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 45, "Speech therapy / Audiology", null, 0.0, "38200", "Speech therapy / Audiology", "SPEECHTHERAPY/AUDIOLOGY", "SPEECHTHERAPY/AUDIOLOGY", "82000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 32, "PHARMACY", false, 0.0, "46000", "PHARMACY", "PHARMACY", "PHARMACY", "60000", 5 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 46, "Dieticians", true, 0.0, "38400", "Dieticians", "DIETICIANS", "DIETICIANS", "84000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 48, "ORTHOTIST/PROSTHETIST", false, 0.0, "38700", "ORTHOTIST/PROSTHETIST", "ORTHOTIST/PROSTHETIST", "ORTHOTIST/PROSTHETIST", "87000", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 49, "Registered nurses", true, 0.0, "48800", "Registered nurses", "REGISTEREDNURSES", "REGISTEREDNURSES", "88000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 50, "ORTHOPAEDIC SUPPLIERS", false, 0.0, "59000", "ORTHOPAEDIC SUPPLIERS", "ORTHOPAEDICSUPPLIERS", "ORTHOPAEDICSUPPLIERS", "90000", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 51, "Periodontics", false, 0.0, "29200", "Periodontics", "PERIODONTICS", "PERIODONTICS", "92000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 52, "Prostodontics", true, 0.0, "29400", "Prostodontics", "PROSTODONTICS", "PROSTODONTICS", "94000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 53, "Other specialists/General Practitioners", false, 0.0, "10099", "Other specialists/General Practitioners", "OTHERSPECIALISTS/GENERALPRACTITIONERS", "OTHERSPECIALISTS/GENERALPRACTITIONERS", "99000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 54, "Pulmonology", true, 0.0, "11700", "Pulmonology", "PULMONOLOGY", "PULMONOLOGY", "17000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 55, "Gastroenterology", true, 0.0, "11900", "Gastroenterology", "GASTROENTEROLOGY", "GASTROENTEROLOGY", "19000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 56, "Cardiology", true, 0.0, "12100", "Cardiology", "CARDIOLOGY", "CARDIOLOGY", "21000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 127, "Medical Scientist : Clinical Biochemist", false, 0.0, "36904", "Medical Scientist : Clinical Biochemist", "MEDICALSCIENTIST:CLINICALBIOCHEMIST", "MEDICALSCIENTIST:CLINICALBIOCHEMIST", "69000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 58, "Nuclear Medicine", false, 0.0, "12500", "Nuclear Medicine", "NUCLEARMEDICINE", "NUCLEARMEDICINE", "25000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 59, "Paediatric Cardiology", false, 0.0, "13300", "Paediatric Cardiology", "PAEDIATRICCARDIOLOGY", "PAEDIATRICCARDIOLOGY", "32013", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 60, "Oral pathology", false, 0.0, "29800", "Oral pathology", "ORALPATHOLOGY", "ORALPATHOLOGY", "98000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 47, "Psychologists", true, 0.0, "38600", "Psychologists", "PSYCHOLOGISTS", "PSYCHOLOGISTS", "86000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 61, "Advanced Life Support", false, 0.0, "51000", "Advanced Life Support", "ADVANCEDLIFESUPPORT", "ADVANCEDLIFESUPPORT", "9003", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 31, "Private Hospitals ('B' - Tariff)", false, 0.0, "55800", "Private Hospitals ('B' - Tariff)", "PRIVATEHOSPITALS('B'-TARIFF)", "PRIVATEHOSPITALS('B'-TARIFF)", "58000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 29, "Hospitals", false, 0.0, "55600", "Hospitals", "HOSPITALS", "HOSPITALS", "56000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 1, "Unknown Type of Practitioner", false, 0.0, "00000", "Unknown", "UNKNOWNTYPEOFPRACTITIONER", "UNKNOWN", "00000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 2, "Chiropractors", false, 0.0, "40400", "Chiropractors", "CHIROPRACTORS", "CHIROPRACTORS", "4000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 3, "Homeopaths", false, 0.0, "40800", "Homeopaths", "HOMEOPATHS", "HOMEOPATHS", "8000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 4, "Aneasthetics", false, 0.0, "11000", "Aneasthetics", "ANEASTHETICS", "ANEASTHETICS", "10000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 5, "Dermatology", true, 0.0, "11200", "Dermatology", "DERMATOLOGY", "DERMATOLOGY", "12000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 6, "Basic Life Support", false, 0.0, "51200", "Basic Life Support", "BASICLIFESUPPORT", "BASICLIFESUPPORT", "9001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 7, "General Practitioner", true, 0.0, "11400", "General Practitioner", "GENERALPRACTITIONER", "GENERALPRACTITIONER", "14000", 3 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 8, "GENERAL PRACTITIONER (CONSULTATIONS)", false, 0.0, "11500", "GENERAL PRACTITIONER (CONSULTATIONS)", "GENERALPRACTITIONER(CONSULTATIONS)", "GENERALPRACTITIONER(CONSULTATIONS)", "15000", 3 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 9, "Gynaecology", true, 0.0, "11600", "Gynaecology", "GYNAECOLOGY", "GYNAECOLOGY", "16000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 10, "Physicians", true, 0.0, "11800", "Physicians", "PHYSICIANS", "PHYSICIANS", "18000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 11, "Neurology", true, 0.0, "12000", "Neurology", "NEUROLOGY", "NEUROLOGY", "20000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 12, "Psychiatry", true, 0.0, "12200", "Psychiatry", "PSYCHIATRY", "PSYCHIATRY", "22000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 13, "Neurosurgery", true, 0.0, "12400", "Neurosurgery", "NEUROSURGERY", "NEUROSURGERY", "24000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 30, "Private Hospitals ('A' - Status)", false, 0.0, "55700", "Private Hospitals ('A' - Status)", "PRIVATEHOSPITALS('A'-STATUS)", "PRIVATEHOSPITALS('A'-STATUS)", "57000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 14, "Opthalmology", true, 0.0, "12600", "Opthalmology", "OPTHALMOLOGY", "OPTHALMOLOGY", "26000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 16, "Otorhinolaryngology", true, 0.0, "13000", "Otorhinolaryngology", "OTORHINOLARYNGOLOGY", "OTORHINOLARYNGOLOGY", "30000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 17, "MASSAGE", false, 0.0, "NULL", "MASSAGE", "MASSAGE", "MASSAGE", "", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 18, "Paediatrics Independent Practice Specialist", false, 0.0, "13200", "Paediatrics Independent Practice Specialist", "PAEDIATRICSINDEPENDENTPRACTICESPECIALIST", "PAEDIATRICSINDEPENDENTPRACTICESPECIALIST", "32000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 19, "Physical Medicine", true, 0.0, "13400", "Physical Medicine", "PHYSICALMEDICINE", "PHYSICALMEDICINE", "34000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 20, "Plastic and Reconstructive Surgery", true, 0.0, "13600", "Plastic and Reconstructive Surgery", "PLASTICANDRECONSTRUCTIVESURGERY", "PLASTICANDRECONSTRUCTIVESURGERY", "36000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 21, "Radiology", true, 0.0, "13800", "Radiology", "RADIOLOGY", "RADIOLOGY", "38000", 7 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 22, "Radiation Oncology", true, 0.0, "14000", "Radiation Oncology", "RADIATIONONCOLOGY", "RADIATIONONCOLOGY", "40000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 23, "Surgery", true, 0.0, "14200", "Surgery", "SURGERY", "SURGERY", "42000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 24, "Thoracic surgery", true, 0.0, "14400", "Thoracic surgery", "THORACICSURGERY", "THORACICSURGERY", "44000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 25, "Urology", true, 0.0, "14600", "Urology", "UROLOGY", "UROLOGY", "46000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 26, "Clinical Pathology", false, 0.0, "15200", "Clinical Pathology", "CLINICALPATHOLOGY", "CLINICALPATHOLOGY", "52000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 27, "Anatomical Pathology", false, 0.0, "15300", "Anatomical Pathology", "ANATOMICALPATHOLOGY", "ANATOMICALPATHOLOGY", "52001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 28, "Dental Practice", true, 0.0, "25400", "Dental Practice", "DENTALPRACTICE", "DENTALPRACTICE", "54000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 15, "Orthopaedics", true, 0.0, "12800", "Orthopaedics", "ORTHOPAEDICS", "ORTHOPAEDICS", "28000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 62, "Intermediate Life Support", false, 0.0, "51100", "Intermediate Life Support", "INTERMEDIATELIFESUPPORT", "INTERMEDIATELIFESUPPORT", "9002", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 57, "Medical Oncology", false, 0.0, "12300", "Medical Oncology", "MEDICALONCOLOGY", "MEDICALONCOLOGY", "23000", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 64, "Hearing Aid Acoustician", false, 0.0, "38300", "Hearing Aid Acoustician", "HEARINGAIDACOUSTICIAN", "HEARINGAIDACOUSTICIAN", "83000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 98, "Provincial Hospitals : Primary Care Centres", false, 0.0, "55609", "Provincial Hospitals : Primary Care Centres", "PROVINCIALHOSPITALS:PRIMARYCARECENTRES", "PROVINCIALHOSPITALS:PRIMARYCARECENTRES", "56009", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 99, "Private Hospitals ('A' - Status): + ICU + theatre < 100 beds", false, 0.0, "55701", "Private Hosp A Status : + ICU + theatre < 100 beds", "PRIVATEHOSPITALS('A'-STATUS):+ICU+THEATRE<100BEDS", "PRIVATEHOSPASTATUS:+ICU+THEATRE<100BEDS", "57001", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 100, "Private Hospitals ('A' - Status) : - ICU + theatre", false, 0.0, "55702", "Private Hosp A Status : - ICU + theatre", "PRIVATEHOSPITALS('A'-STATUS):-ICU+THEATRE", "PRIVATEHOSPASTATUS:-ICU+THEATRE", "57002", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 63, "Dental therapy", false, 0.0, "39500", "Dental therapy", "DENTALTHERAPY", "DENTALTHERAPY", "95000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 102, "Private Hospitals ('A' - Status) : - ICU - theatre", false, 0.0, "55704", "Private Hospitals ('A' - Status) : - ICU - theatre", "PRIVATEHOSPITALS('A'-STATUS):-ICU-THEATRE", "PRIVATEHOSPITALS('A'-STATUS):-ICU-THEATRE", "57004", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 103, "Private Hospitals ('A' - Status) : + theatre Maternity only", false, 0.0, "55705", "Private Hosp A Status : + theatre Maternity only", "PRIVATEHOSPITALS('A'-STATUS):+THEATREMATERNITYONLY", "PRIVATEHOSPASTATUS:+THEATREMATERNITYONLY", "57005", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 104, "Private Hospitals ('A' - Status) : - Theatre Maternity Only", false, 0.0, "55706", "Private Hosp A Status : - Theatre Maternity Only", "PRIVATEHOSPITALS('A'-STATUS):-THEATREMATERNITYONLY", "PRIVATEHOSPASTATUS:-THEATREMATERNITYONLY", "57006", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 105, "Group Practices : Primary Care", true, 0.0, "55009", "Group Practices : Primary Care", "GROUPPRACTICES:PRIMARYCARE", "GROUPPRACTICES:PRIMARYCARE", "50009", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 106, "Group Practices : Child Delayed Development", false, 0.0, "55010", "Group Practices : Child Delayed Development", "GROUPPRACTICES:CHILDDELAYEDDEVELOPMENT", "GROUPPRACTICES:CHILDDELAYEDDEVELOPMENT", "50010", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 107, "Medical Scientist : Medical Biological Scientist", false, 0.0, "36902", "Medical Scientist : Medical Biological Scientist", "MEDICALSCIENTIST:MEDICALBIOLOGICALSCIENTIST", "MEDICALSCIENTIST:MEDICALBIOLOGICALSCIENTIST", "69002", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 108, "Medical Scientist : Medical Physicist", false, 0.0, "36903", "Medical Scientist : Medical Physicist", "MEDICALSCIENTIST:MEDICALPHYSICIST", "MEDICALSCIENTIST:MEDICALPHYSICIST", "69003", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 109, "Clinical technology : Cardio-Vascular", false, 0.0, "37501", "Clinical technology : Cardio-Vascular", "CLINICALTECHNOLOGY:CARDIO-VASCULAR", "CLINICALTECHNOLOGY:CARDIO-VASCULAR", "75001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 110, "Clinical technology : Pulmonology/Nephrology", false, 0.0, "37502", "Clinical technology : Pulmonology/Nephrology", "CLINICALTECHNOLOGY:PULMONOLOGY/NEPHROLOGY", "CLINICALTECHNOLOGY:PULMONOLOGY/NEPHROLOGY", "75002", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 111, "Clinical technology : Reproductive biology", false, 0.0, "37504", "Clinical technology : Reproductive biology", "CLINICALTECHNOLOGY:REPRODUCTIVEBIOLOGY", "CLINICALTECHNOLOGY:REPRODUCTIVEBIOLOGY", "75004", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 112, "Clinical technology : Neurophysiology", false, 0.0, "37506", "Clinical technology : Neurophysiology", "CLINICALTECHNOLOGY:NEUROPHYSIOLOGY", "CLINICALTECHNOLOGY:NEUROPHYSIOLOGY", "75006", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 113, "Clinical technology : Critical Care", false, 0.0, "37507", "Clinical technology : Critical Care", "CLINICALTECHNOLOGY:CRITICALCARE", "CLINICALTECHNOLOGY:CRITICALCARE", "75007", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 114, "Clinical services : Oxygen Supplier", false, 0.0, "59001", "Clinical services : Oxygen Supplier", "CLINICALSERVICES:OXYGENSUPPLIER", "CLINICALSERVICES:OXYGENSUPPLIER", "90001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 115, "Clinical services : Wheelchair Supplier", false, 0.0, "59002", "Clinical services : Wheelchair Supplier", "CLINICALSERVICES:WHEELCHAIRSUPPLIER", "CLINICALSERVICES:WHEELCHAIRSUPPLIER", "90002", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 116, "Clinical services : Ear & Voice Prosthetic Supplie", false, 0.0, "59003", "Clinical services : Ear & Voice Prosthetic Supplie", "CLINICALSERVICES:EAR&VOICEPROSTHETICSUPPLIE", "CLINICALSERVICES:EAR&VOICEPROSTHETICSUPPLIE", "90003", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 117, "Clinical services : Eye Prosthetic Supplier", true, 0.0, "59004", "Clinical services : Eye Prosthetic Supplier", "CLINICALSERVICES:EYEPROSTHETICSUPPLIER", "CLINICALSERVICES:EYEPROSTHETICSUPPLIER", "90004", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 118, "Clinical services : Breast Prosthetic Supplier", false, 0.0, "59005", "Clinical services : Breast Prosthetic Supplier", "CLINICALSERVICES:BREASTPROSTHETICSUPPLIER", "CLINICALSERVICES:BREASTPROSTHETICSUPPLIER", "90005", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 119, "Clinical services : Cardiac Prosthetic Supplier", false, 0.0, "59006", "Clinical services : Cardiac Prosthetic Supplier", "CLINICALSERVICES:CARDIACPROSTHETICSUPPLIER", "CLINICALSERVICES:CARDIACPROSTHETICSUPPLIER", "90006", 6 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 120, "Clinical services : Stomal/Appliances Supplier", false, 0.0, "59007", "Clinical services : Stomal/Appliances Supplier", "CLINICALSERVICES:STOMAL/APPLIANCESSUPPLIER", "CLINICALSERVICES:STOMAL/APPLIANCESSUPPLIER", "90007", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 121, "Clinical services : General Medical Supplier", false, 0.0, "59008", "Clinical services : General Medical Supplier", "CLINICALSERVICES:GENERALMEDICALSUPPLIER", "CLINICALSERVICES:GENERALMEDICALSUPPLIER", "90008", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 122, "Clinical services : FAMSA", false, 0.0, "59009", "Clinical services : FAMSA", "CLINICALSERVICES:FAMSA", "CLINICALSERVICES:FAMSA", "90009", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 124, "Clinical services : Oncology units (not owned by h", false, 0.0, "59011", "Clinical services : Oncology units (not owned by h", "CLINICALSERVICES:ONCOLOGYUNITS(NOTOWNEDBYH", "CLINICALSERVICES:ONCOLOGYUNITS(NOTOWNEDBYH", "90011", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 125, "Clinical services : Namibia Clinics", false, 0.0, "89012", "Clinical services : Namibia Clinics", "CLINICALSERVICES:NAMIBIACLINICS", "CLINICALSERVICES:NAMIBIACLINICS", "90012", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 97, "Provincial Hospitals : Oral", false, 0.0, "55604", "Provincial Hospitals : Oral", "PROVINCIALHOSPITALS:ORAL", "PROVINCIALHOSPITALS:ORAL", "56004", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 96, "Provincial Hospitals : Central", false, 0.0, "55603", "Provincial Hospitals : Central", "PROVINCIALHOSPITALS:CENTRAL", "PROVINCIALHOSPITALS:CENTRAL", "56003", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 101, "Private Hospitals ('A' - Status) : + ICU - theatre", false, 0.0, "55703", "Private Hospitals A Status : + ICU - theatre", "PRIVATEHOSPITALS('A'-STATUS):+ICU-THEATRE", "PRIVATEHOSPITALSASTATUS:+ICU-THEATRE", "57003", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 94, "Provincial Hospitals : District", false, 0.0, "55601", "Provincial Hospitals : District", "PROVINCIALHOSPITALS:DISTRICT", "PROVINCIALHOSPITALS:DISTRICT", "56001", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 65, "Radiography", false, 0.0, "33900", "Radiography", "RADIOGRAPHY", "RADIOGRAPHY", "39000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 66, "Biokinetics", true, 0.0, "37700", "Biokinetics", "BIOKINETICS", "BIOKINETICS", "91000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 67, "Medical Technologists", false, 0.0, "37600", "Medical Technologists", "MEDICALTECHNOLOGISTS", "MEDICALTECHNOLOGISTS", "37000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 68, "Social workers", true, 0.0, "48900", "Social workers", "SOCIALWORKERS", "SOCIALWORKERS", "89000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 69, "Mental Health Institutions", false, 0.0, "55500", "Mental Health Institutions", "MENTALHEALTHINSTITUTIONS", "MENTALHEALTHINSTITUTIONS", "55000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 70, "Nurses institutes", false, 0.0, "48000", "Nurses institutes", "NURSESINSTITUTES", "NURSESINSTITUTES", "80000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 71, "Genetic Councellor", false, 0.0, "36901", "Genetic Councellor", "GENETICCOUNCELLOR", "GENETICCOUNCELLOR", "69001", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 95, "Provincial Hospitals : Regional", false, 0.0, "55602", "Provincial Hospitals : Regional", "PROVINCIALHOSPITALS:REGIONAL", "PROVINCIALHOSPITALS:REGIONAL", "56002", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 73, "Sub-Acute Facilities", false, 0.0, "54900", "Sub-Acute Facilities", "SUB-ACUTEFACILITIES", "SUB-ACUTEFACILITIES", "49000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 75, "Aeromedical Rotor Wing Type A", false, 0.0, "51301", "Aeromedical Rotor Wing Type A", "AEROMEDICALROTORWINGTYPEA", "AEROMEDICALROTORWINGTYPEA", "9100", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 76, "Aeromedical Rotor Wing Type B", false, 0.0, "51302", "Aeromedical Rotor Wing Type B", "AEROMEDICALROTORWINGTYPEB", "AEROMEDICALROTORWINGTYPEB", "9200", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 77, "Aeromedical Rotor Wing Type C", false, 0.0, "51303", "Aeromedical Rotor Wing Type C", "AEROMEDICALROTORWINGTYPEC", "AEROMEDICALROTORWINGTYPEC", "9300", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 78, "Aeromedical Fixed Wing Type A", false, 0.0, "51304", "Aeromedical Fixed Wing Type A", "AEROMEDICALFIXEDWINGTYPEA", "AEROMEDICALFIXEDWINGTYPEA", "9400", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 79, "Rehabilitation Hospitals", false, 0.0, "55900", "Rehabilitation Hospitals", "REHABILITATIONHOSPITALS", "REHABILITATIONHOSPITALS", "59000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 72, "Hospice or other approved facilities", false, 0.0, "57900", "Hospice or other approved facilities", "HOSPICEOROTHERAPPROVEDFACILITIES", "HOSPICEOROTHERAPPROVEDFACILITIES", "79000", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 81, "Specialist Radiologist/Nuclear Physicians", true, 0.0, "10008", "Specialist Radiologist/Nuclear Physicians", "SPECIALISTRADIOLOGIST/NUCLEARPHYSICIANS", "SPECIALISTRADIOLOGIST/NUCLEARPHYSICIANS", "99900", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 80, "Art Therapy", false, 0.0, "36700", "Art Therapy", "ARTTHERAPY", "ARTTHERAPY", "67000", 1 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 92, "Sub-Acute Facilities : Psychiatric/Post Natal", false, 0.0, "54906", "Sub-Acute Facilities : Psychiatric/Post Natal", "SUB-ACUTEFACILITIES:PSYCHIATRIC/POSTNATAL", "SUB-ACUTEFACILITIES:PSYCHIATRIC/POSTNATAL", "49006", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 91, "Sub-Acute Facilities : Post Natal Unit", false, 0.0, "54905", "Sub-Acute Facilities : Post Natal Unit", "SUB-ACUTEFACILITIES:POSTNATALUNIT", "SUB-ACUTEFACILITIES:POSTNATALUNIT", "49005", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 90, "Sub-Acute Facilities : All Services", false, 0.0, "54904", "Sub-Acute Facilities : All Services", "SUB-ACUTEFACILITIES:ALLSERVICES", "SUB-ACUTEFACILITIES:ALLSERVICES", "49004", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 89, "Sub-Acute Facilities : Physical Rehab", false, 0.0, "54903", "Sub-Acute Facilities : Physical Rehab", "SUB-ACUTEFACILITIES:PHYSICALREHAB", "SUB-ACUTEFACILITIES:PHYSICALREHAB", "49003", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 88, "Sub-Acute Facilities : Psychiatry", false, 0.0, "54902", "Sub-Acute Facilities : Psychiatry", "SUB-ACUTEFACILITIES:PSYCHIATRY", "SUB-ACUTEFACILITIES:PSYCHIATRY", "49002", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 93, "Sub-Acute Facilities : Rehab/Post Natal", false, 0.0, "54907", "Sub-Acute Facilities : Rehab/Post Natal", "SUB-ACUTEFACILITIES:REHAB/POSTNATAL", "SUB-ACUTEFACILITIES:REHAB/POSTNATAL", "49007", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 86, "Drug & Alcohol Rehabilitation : Welfare", false, 0.0, "54701", "Drug & Alcohol Rehabilitation : Welfare", "DRUG&ALCOHOLREHABILITATION:WELFARE", "DRUG&ALCOHOLREHABILITATION:WELFARE", "47001", 4 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 85, "Paediatrics : Developmental", false, 0.0, "13202", "Paediatrics : Developmental", "PAEDIATRICS:DEVELOPMENTAL", "PAEDIATRICS:DEVELOPMENTAL", "32002", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 84, "Paediatrics : Neurology", false, 0.0, "13201", "Paediatrics : Neurology", "PAEDIATRICS:NEUROLOGY", "PAEDIATRICS:NEUROLOGY", "32001", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 83, "Namibian Practioners Only (Not recognized by HPCS)", false, 0.0, "80700", "Namibian Practioners Only (Not recognized by HPCS)", "NAMIBIANPRACTIONERSONLY(NOTRECOGNIZEDBYHPCS)", "NAMIBIANPRACTIONERSONLY(NOTRECOGNIZEDBYHPCS)", "7000", 3 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 82, "Specialist", true, 0.0, "10000", "Specialist", "SPECIALIST", "SPECIALIST", "80700", 2 });

            migrationBuilder.InsertData(
                table: "Practitioners",
                columns: new[] { "Id", "Description", "IsMedReportRequired", "MaxTreatmentDays", "NRPLPracticeCode", "Name", "NormalizedDescription", "NormalizedName", "PracticeCode", "PractitionerGroupTypeId" },
                values: new object[] { 87, "Sub-Acute Facilities : Acute", false, 0.0, "54901", "Sub-Acute Facilities : Acute", "SUB-ACUTEFACILITIES:ACUTE", "SUB-ACUTEFACILITIES:ACUTE", "49001", 4 });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(3103), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4386), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4409), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4609), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4617), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4617), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4620), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4624), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "PublicationTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4628), new DateTime(2019, 8, 24, 19, 22, 1, 409, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 302, DateTimeKind.Local).AddTicks(7068), new DateTime(2019, 8, 24, 19, 22, 1, 302, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 302, DateTimeKind.Local).AddTicks(7126), new DateTime(2019, 8, 24, 19, 22, 1, 302, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 312, DateTimeKind.Local).AddTicks(1187), new DateTime(2019, 8, 24, 19, 22, 1, 312, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 24, 19, 22, 1, 312, DateTimeKind.Local).AddTicks(3058), new DateTime(2019, 8, 24, 19, 22, 1, 312, DateTimeKind.Local).AddTicks(3066) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Practitioners",
                keyColumn: "Id",
                keyValue: 252);

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
    }
}
