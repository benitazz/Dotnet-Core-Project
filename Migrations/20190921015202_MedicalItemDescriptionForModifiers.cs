using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalEngineMicroService.Migrations
{
    public partial class MedicalItemDescriptionForModifiers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NormalizedDescription",
                table: "MedicalItemPublications",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 558, DateTimeKind.Local).AddTicks(8350), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5014), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5041), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5049), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5057), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5061), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5068), new DateTime(2019, 9, 21, 3, 51, 58, 560, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6526), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6695), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6719), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6746), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6784), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6807), new DateTime(2019, 9, 21, 3, 51, 58, 568, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 53, "Pathology tests performed by non-pathologists: Where items under Clinical Pathology (section 21) and Anatomical Pathology (section 22) fall within the province of other specialists or general practitioners, the fee is to be charged at two-thirds of the pathologists fee", 53, "PATHOLOGYTESTSPERFORMEDBYNON-PATHOLOGISTS:WHEREITEMSUNDERCLINICALPATHOLOGY(SECTION21)ANDANATOMICALPATHOLOGY(SECTION22)FALLWITHINTHEPROVINCEOFOTHERSPECIALISTSORGENERALPRACTITIONERS,THEFEEISTOBECHARGEDATTWO-THIRDSOFTHEPATHOLOGISTSFEE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 52, "Radio-isotope therapy patients who fail to keep their appointments: Fee will include cost of isotope", 52, "RADIO-ISOTOPETHERAPYPATIENTSWHOFAILTOKEEPTHEIRAPPOINTMENTS:FEEWILLINCLUDECOSTOFISOTOPE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 51, "Radiation materials: Exclusively for use where radiation materials supplied by the practice are used by clinical and radiation oncologists, modifier 0095 should be used to identify these materials. A material code list with descriptions and guideline costs for these materials, maintained and updated on a regular basis, will be supplied  by the Society of Clinical and Radiation Oncology.  This modifier is only chargeable by the practice responsible for the cost of this material and where the hospital did not charge therefore. Please note that item 0201 should not be used for these materials", 51, "RADIATIONMATERIALS:EXCLUSIVELYFORUSEWHERERADIATIONMATERIALSSUPPLIEDBYTHEPRACTICEAREUSEDBYCLINICALANDRADIATIONONCOLOGISTS,MODIFIER0095SHOULDBEUSEDTOIDENTIFYTHESEMATERIALS.AMATERIALCODELISTWITHDESCRIPTIONSANDGUIDELINECOSTSFORTHESEMATERIALS,MAINTAINEDANDUPDATEDONAREGULARBASIS,WILLBESUPPLIEDBYTHESOCIETYOFCLINICALANDRADIATIONONCOLOGY.THISMODIFIERISONLYCHARGEABLEBYTHEPRACTICERESPONSIBLEFORTHECOSTOFTHISMATERIALANDWHERETHEHOSPITALDIDNOTCHARGETHEREFORE.PLEASENOTETHATITEM0201SHOULDNOTBEUSEDFORTHESEMATERIALS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 50, "Diagnostic services rendered to outpatients: Quote Modifier 0092 on all accounts for diagnostic services (e.g. MRI, X-rays, pathology tests) performed on patients NOT officially admitted to hospital or day clinic (could be within the confines of a hospital) (refer to Rule YY)", 50, "DIAGNOSTICSERVICESRENDEREDTOOUTPATIENTS:QUOTEMODIFIER0092ONALLACCOUNTSFORDIAGNOSTICSERVICES(E.G.MRI,X-RAYS,PATHOLOGYTESTS)PERFORMEDONPATIENTSNOTOFFICIALLYADMITTEDTOHOSPITALORDAYCLINIC(COULDBEWITHINTHECONFINESOFAHOSPITAL)(REFERTORULEYY)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 49, "Diagnostic services rendered to hospital inpatients: Quote Modifier 0091 on all accounts for diagnostic services (e.g. MRI, X-rays, pathology tests) performed on patients officially admitted to hospital or day clinic (refer to Rule XX)", 49, "DIAGNOSTICSERVICESRENDEREDTOHOSPITALINPATIENTS:QUOTEMODIFIER0091ONALLACCOUNTSFORDIAGNOSTICSERVICES(E.G.MRI,X-RAYS,PATHOLOGYTESTS)PERFORMEDONPATIENTSOFFICIALLYADMITTEDTOHOSPITALORDAYCLINIC(REFERTORULEXX)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 48, "Radiologist?s fee for participation in a team: 30,00 radiology units per ? hour or part thereof for all interventional radiological procedures, excluding any pre- or post-operative angiography, catheterisation, CT-scanning, ultrasound-scanning or x-ray procedures. (Only to be charged if radiologist is hands-on, and not for interpretation of images only)", 48, "RADIOLOGIST?SFEEFORPARTICIPATIONINATEAM:30,00RADIOLOGYUNITSPER?HOURORPARTTHEREOFFORALLINTERVENTIONALRADIOLOGICALPROCEDURES,EXCLUDINGANYPRE-ORPOST-OPERATIVEANGIOGRAPHY,CATHETERISATION,CT-SCANNING,ULTRASOUND-SCANNINGORX-RAYPROCEDURES.(ONLYTOBECHARGEDIFRADIOLOGISTISHANDS-ON,ANDNOTFORINTERPRETATIONOFIMAGESONLY)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 47, "Vascular groups: ?Film series? and ?Introduction of Contrast Media? are complementary and together constitute a single examination: neither fee is therefore subject to increase in terms of Modifier 0080: Multiple examinations", 47, "VASCULARGROUPS:?FILMSERIES?AND?INTRODUCTIONOFCONTRASTMEDIA?ARECOMPLEMENTARYANDTOGETHERCONSTITUTEASINGLEEXAMINATION:NEITHERFEEISTHEREFORESUBJECTTOINCREASEINTERMSOFMODIFIER0080:MULTIPLEEXAMINATIONS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 40, "When a first consultation/visit proceeds into, or is immediately followed by a medical psychotherapeutic procedure, fees for the procedure are calculated according to the appropriate individual psychotherapy code (items 2957, 2974 or 2975)", 40, "WHENAFIRSTCONSULTATION/VISITPROCEEDSINTO,ORISIMMEDIATELYFOLLOWEDBYAMEDICALPSYCHOTHERAPEUTICPROCEDURE,FEESFORTHEPROCEDUREARECALCULATEDACCORDINGTOTHEAPPROPRIATEINDIVIDUALPSYCHOTHERAPYCODE(ITEMS2957,2974OR2975)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 45, "Film costs: In the case of radiological items where films are used, practitioners should adjust the fee upwards or downwards in accordance with changes in the price of films in comparison with November 1979", 45, "FILMCOSTS:INTHECASEOFRADIOLOGICALITEMSWHEREFILMSAREUSED,PRACTITIONERSSHOULDADJUSTTHEFEEUPWARDSORDOWNWARDSINACCORDANCEWITHCHANGESINTHEPRICEOFFILMSINCOMPARISONWITHNOVEMBER1979", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 44, "A reduction of 33,33% (1/3) in the fee will apply to radiological examinations as indicated in section 19: Radiology where hospital equipment is used", 44, "AREDUCTIONOF33,33%(1/3)INTHEFEEWILLAPPLYTORADIOLOGICALEXAMINATIONSASINDICATEDINSECTION19:RADIOLOGYWHEREHOSPITALEQUIPMENTISUSED", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 43, "\" + \" Means that this item is complementary to a preceding item and is therefore not subject to reduction", 43, "\" + \"MEANSTHATTHISITEMISCOMPLEMENTARYTOAPRECEDINGITEMANDISTHEREFORENOTSUBJECTTOREDUCTION", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 42, "Repeat examinations: No reduction", 42, "REPEATEXAMINATIONS:NOREDUCTION", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 41, "Multiple examinations: Full Fee", 41, "MULTIPLEEXAMINATIONS:FULLFEE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 54, "Aspiration of biopsy procedure performed under direct ultrasound control by an ultrasound aspiration biopsy transducer (Static Realtime): Fee for part examined plus 30% of the units", 54, "ASPIRATIONOFBIOPSYPROCEDUREPERFORMEDUNDERDIRECTULTRASOUNDCONTROLBYANULTRASOUNDASPIRATIONBIOPSYTRANSDUCER(STATICREALTIME):FEEFORPARTEXAMINEDPLUS30%OFTHEUNITS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 38, "Physical treatment: When two separate areas are treated simultaneously for totally different conditions, such treatment shall be regarded as two treatments for which separate fees may be charged. (Only applicable if services are provided by a specialist in physical medicine)", 38, "PHYSICALTREATMENT:WHENTWOSEPARATEAREASARETREATEDSIMULTANEOUSLYFORTOTALLYDIFFERENTCONDITIONS,SUCHTREATMENTSHALLBEREGARDEDASTWOTREATMENTSFORWHICHSEPARATEFEESMAYBECHARGED.(ONLYAPPLICABLEIFSERVICESAREPROVIDEDBYASPECIALISTINPHYSICALMEDICINE)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 46, "Left Side' modifier to be added to when items 6500 to 6519 are used when the left side is examined. Please note that the absence of this modifier indicates that the right side was examined", 46, "LEFTSIDE'MODIFIERTOBEADDEDTOWHENITEMS6500TO6519AREUSEDWHENTHELEFTSIDEISEXAMINED.PLEASENOTETHATTHEABSENCEOFTHISMODIFIERINDICATESTHATTHERIGHTSIDEWASEXAMINED", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 55, "Use of contrast during ultrasound study: add 6.00 ultrasound units", 55, "USEOFCONTRASTDURINGULTRASOUNDSTUDY:ADD6.00ULTRASOUNDUNITS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 61, "Limited examination of the hypophysis e.g. where a coronal T1 and sagittal T1 series are performed, two-thirds (2/3) of the fee is applicable", 61, "LIMITEDEXAMINATIONOFTHEHYPOPHYSISE.G.WHEREACORONALT1ANDSAGITTALT1SERIESAREPERFORMED,TWO-THIRDS(2/3)OFTHEFEEISAPPLICABLE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 57, "In order to charge the full fee (600,00 magnetic resonance units) for an examination of a specific single anatomical region, it should be performed with the applicable radio frequency coil including T1 and T2 weighted images on at least two planes", 57, "INORDERTOCHARGETHEFULLFEE(600,00MAGNETICRESONANCEUNITS)FORANEXAMINATIONOFASPECIFICSINGLEANATOMICALREGION,ITSHOULDBEPERFORMEDWITHTHEAPPLICABLERADIOFREQUENCYCOILINCLUDINGT1ANDT2WEIGHTEDIMAGESONATLEASTTWOPLANES", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 72, "When multiple catheterisation procedures are used (items 3557, 3559, 3560, 3562) and an angiogram investigation is performed at each level, the unit value of each such multiple procedure will be reduced by 20,00 radiological units for each procedure after the initial catheterisation. The first catheterisation is charged at 100% of the unit value", 72, "WHENMULTIPLECATHETERISATIONPROCEDURESAREUSED(ITEMS3557,3559,3560,3562)ANDANANGIOGRAMINVESTIGATIONISPERFORMEDATEACHLEVEL,THEUNITVALUEOFEACHSUCHMULTIPLEPROCEDUREWILLBEREDUCEDBY20,00RADIOLOGICALUNITSFOREACHPROCEDUREAFTERTHEINITIALCATHETERISATION.THEFIRSTCATHETERISATIONISCHARGEDAT100%OFTHEUNITVALUE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 71, "When a procedure is performed entirely by a non-radiologist in a facility owned by a radiologist, the radiologist owning the facility may charge 55% of the procedure units used. Modifier 6302 applies to the non radiologist performing the procedure", 71, "WHENAPROCEDUREISPERFORMEDENTIRELYBYANON-RADIOLOGISTINAFACILITYOWNEDBYARADIOLOGIST,THERADIOLOGISTOWNINGTHEFACILITYMAYCHARGE55%OFTHEPROCEDUREUNITSUSED.MODIFIER6302APPLIESTOTHENONRADIOLOGISTPERFORMINGTHEPROCEDURE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 70, "When the procedure is performed by a non-radiologist, the fee will be reduced by 40% (i.e. 60% of the fee will be charged)", 70, "WHENTHEPROCEDUREISPERFORMEDBYANON-RADIOLOGIST,THEFEEWILLBEREDUCEDBY40%(I.E.60%OFTHEFEEWILLBECHARGED)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 69, "If a procedure is performed by a radiologist in a facility not owned by himself, the fee will be reduced by 40% (i.e. 60% of the fee will be charged)", 69, "IFAPROCEDUREISPERFORMEDBYARADIOLOGISTINAFACILITYNOTOWNEDBYHIMSELF,THEFEEWILLBEREDUCEDBY40%(I.E.60%OFTHEFEEWILLBECHARGED)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 68, "If a procedure lasts less than 30 minutes, only 50% of the machine fees for items 3536-3550 will be allowed (specify time of procedure on account)", 68, "IFAPROCEDURELASTSLESSTHAN30MINUTES,ONLY50%OFTHEMACHINEFEESFORITEMS3536-3550WILLBEALLOWED(SPECIFYTIMEOFPROCEDUREONACCOUNT)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 67, "MRI spectroscopy: 50% of fee", 67, "MRISPECTROSCOPY:50%OFFEE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 66, "Very limited studies to be charged at 33,33% of the full fee e.g. MR urography for renal colic, diffusion studies of the brain additional to routine brain", 66, "VERYLIMITEDSTUDIESTOBECHARGEDAT33,33%OFTHEFULLFEEE.G.MRUROGRAPHYFORRENALCOLIC,DIFFUSIONSTUDIESOFTHEBRAINADDITIONALTOROUTINEBRAIN", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 65, "Where only a gradient echo series is performed with a machine without a recognised angiographic software package with reconstruction ability, 20% of the full fee is applicable specifying that it is a ?flow sensitive series?", 65, "WHEREONLYAGRADIENTECHOSERIESISPERFORMEDWITHAMACHINEWITHOUTARECOGNISEDANGIOGRAPHICSOFTWAREPACKAGEWITHRECONSTRUCTIONABILITY,20%OFTHEFULLFEEISAPPLICABLESPECIFYINGTHATITISA?FLOWSENSITIVESERIES?", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 64, "Where a magnetic resonance angiography (MRA) of the vessels is performed additional to an examination of a particular region, 50% of the fee is applicable for the angiography. This modifier is only applicable if the series is performed by use of a recognised angiographic software package with reconstruction capability", 64, "WHEREAMAGNETICRESONANCEANGIOGRAPHY(MRA)OFTHEVESSELSISPERFORMEDADDITIONALTOANEXAMINATIONOFAPARTICULARREGION,50%OFTHEFEEISAPPLICABLEFORTHEANGIOGRAPHY.THISMODIFIERISONLYAPPLICABLEIFTHESERIESISPERFORMEDBYUSEOFARECOGNISEDANGIOGRAPHICSOFTWAREPACKAGEWITHRECONSTRUCTIONCAPABILITY", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 63, "Where a magnetic resonance angiography (MRA) of large vessels is performed as primary examination, 100% of the fee is applicable. This modifier is only applicable if the series is performed by use of a recognised angiographic software package with reconstruction capability", 63, "WHEREAMAGNETICRESONANCEANGIOGRAPHY(MRA)OFLARGEVESSELSISPERFORMEDASPRIMARYEXAMINATION,100%OFTHEFEEISAPPLICABLE.THISMODIFIERISONLYAPPLICABLEIFTHESERIESISPERFORMEDBYUSEOFARECOGNISEDANGIOGRAPHICSOFTWAREPACKAGEWITHRECONSTRUCTIONCAPABILITY", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 62, "Where, in a limited hypophysis examination, Gadolinium is administered and coronal T1 and sagittal T1 series are repeated, a single full fee for the entire examination is applicable + cost of Gadolinium + disposable items", 62, "WHERE,INALIMITEDHYPOPHYSISEXAMINATION,GADOLINIUMISADMINISTEREDANDCORONALT1ANDSAGITTALT1SERIESAREREPEATED,ASINGLEFULLFEEFORTHEENTIREEXAMINATIONISAPPLICABLE+COSTOFGADOLINIUM+DISPOSABLEITEMS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 37, "Endoscopic procedures performed in own procedure room: The fee plus 21,00 clinical procedure units will apply where endoscopic procedures are performed in rooms with own equipment. This fee is chargeable by medical practitioners who own or rent the facility. Please note: Modifier 0075 is not applicable to any of the items for diagnostic procedures in the otorhinolaryngology sections of the tariff.", 37, "ENDOSCOPICPROCEDURESPERFORMEDINOWNPROCEDUREROOM:THEFEEPLUS21,00CLINICALPROCEDUREUNITSWILLAPPLYWHEREENDOSCOPICPROCEDURESAREPERFORMEDINROOMSWITHOWNEQUIPMENT.THISFEEISCHARGEABLEBYMEDICALPRACTITIONERSWHOOWNORRENTTHEFACILITY.PLEASENOTE:MODIFIER0075ISNOTAPPLICABLETOANYOFTHEITEMSFORDIAGNOSTICPROCEDURESINTHEOTORHINOLARYNGOLOGYSECTIONSOFTHETARIFF.", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 60, "Post-contrast study: Bone tumour: 100% of the fee", 60, "POST-CONTRASTSTUDY:BONETUMOUR:100%OFTHEFEE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 59, "All post-contrast studies (except bone tumour), including perfusion studies, to be charges at 50% of the fee", 59, "ALLPOST-CONTRASTSTUDIES(EXCEPTBONETUMOUR),INCLUDINGPERFUSIONSTUDIES,TOBECHARGESAT50%OFTHEFEE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 58, "Where a limited series of a specific anatomical region is performed (except bone tumour), e.g. a T2 weighted image of a bone for an occult stress fracture, not more than two-thirds (2/3) of the fee may be charged. Also applicable to all radiotherapy planning studies, per region", 58, "WHEREALIMITEDSERIESOFASPECIFICANATOMICALREGIONISPERFORMED(EXCEPTBONETUMOUR),E.G.AT2WEIGHTEDIMAGEOFABONEFORANOCCULTSTRESSFRACTURE,NOTMORETHANTWO-THIRDS(2/3)OFTHEFEEMAYBECHARGED.ALSOAPPLICABLETOALLRADIOTHERAPYPLANNINGSTUDIES,PERREGION", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 56, "Ultrasound in pregnancy, multiple gestation, after twenty weeks: plus 30%", 56, "ULTRASOUNDINPREGNANCY,MULTIPLEGESTATION,AFTERTWENTYWEEKS:PLUS30%", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 36, "Endoscopic procedures performed with own equipment : The basic procedure fee plus 33.33 % (1 / 3) of that fee (\" + \"codes excluded) will apply where endoscopic procedures are performed with own equipment.", 36, @"ENDOSCOPICPROCEDURESPERFORMEDWITHOWNEQUIPMENT : THEBASICPROCEDUREFEEPLUS33 .33 % (1 / 3) OFTHATFEE ("" + ""CODESEXCLUDED) WILLAPPLYWHEREENDOSCOPICPROCEDURESAREPERFORMEDWITHOWNEQUIPMENT.
    ", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 39, "When a testis biopsy is done combined with vasogram or seminal vesiculogram or epididymogram, add 50% of the units for the appropriate procedure", 39, "WHENATESTISBIOPSYISDONECOMBINEDWITHVASOGRAMORSEMINALVESICULOGRAMOREPIDIDYMOGRAM,ADD50%OFTHEUNITSFORTHEAPPROPRIATEPROCEDURE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 34, "Non invasive peripheral vascular tests: The number of tests in a single case is restricted to two (2) per diagnosis. Tests are not justified in cases of uncomplicated varicose veins", 34, "NONINVASIVEPERIPHERALVASCULARTESTS:THENUMBEROFTESTSINASINGLECASEISRESTRICTEDTOTWO(2)PERDIAGNOSIS.TESTSARENOTJUSTIFIEDINCASESOFUNCOMPLICATEDVARICOSEVEINS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 15, "Surgery on neonates (up to and including 28 days after birth) and low birth weight infants (less than 2500g) under general anaesthesia (excluding circumcision): per fee for procedure + 50% for surgeons and a 50% increase in anaesthetic time units for anaesthesiologists", 15, "SURGERYONNEONATES(UPTOANDINCLUDING28DAYSAFTERBIRTH)ANDLOWBIRTHWEIGHTINFANTS(LESSTHAN2500G)UNDERGENERALANAESTHESIA(EXCLUDINGCIRCUMCISION):PERFEEFORPROCEDURE+50%FORSURGEONSANDA50%INCREASEINANAESTHETICTIMEUNITSFORANAESTHESIOLOGISTS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 14, "Surgical modifier for persons with a BMI of 35> (calculated according to kg/m2): Fee for procedure +50% for surgeons and a 50% increase in anaesthetic time units for anaesthesiologists", 14, "SURGICALMODIFIERFORPERSONSWITHABMIOF35>(CALCULATEDACCORDINGTOKG/M2):FEEFORPROCEDURE+50%FORSURGEONSANDA50%INCREASEINANAESTHETICTIMEUNITSFORANAESTHESIOLOGISTS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 13, "Injections administered by practitioners: When desensitisation, intravenous, intramuscular or subcutaneous injections are administered by the practitioner him-/herself to patients who attend the consulting rooms, a first injection forms part of the consultation/visit and only all subsequent injections for the same condition should be charged at 7.50 consultative services units using modifier 0017 to reflect the amount (not chargeable together with a consultation item)", 13, "INJECTIONSADMINISTEREDBYPRACTITIONERS:WHENDESENSITISATION,INTRAVENOUS,INTRAMUSCULARORSUBCUTANEOUSINJECTIONSAREADMINISTEREDBYTHEPRACTITIONERHIM-/HERSELFTOPATIENTSWHOATTENDTHECONSULTINGROOMS,AFIRSTINJECTIONFORMSPARTOFTHECONSULTATION/VISITANDONLYALLSUBSEQUENTINJECTIONSFORTHESAMECONDITIONSHOULDBECHARGEDAT7.50CONSULTATIVESERVICESUNITSUSINGMODIFIER0017TOREFLECTTHEAMOUNT(NOTCHARGEABLETOGETHERWITHACONSULTATIONITEM)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 12, "Intravenous infusions: Where intravenous infusions (including blood and blood cellular products) are administered as part of the after-treatment after the operation or confinement, no extra fees shall be charged as this is included in the global operative or maternity fees.  Should the practitioner doing the operation or attending to the maternity case prefer to ask another practitioner to perform post-operative or post-confinement intravenous infusions, then the practitioner himself (and not the patient) shall be responsible for remunerating such practitioner for the infusions", 12, "INTRAVENOUSINFUSIONS:WHEREINTRAVENOUSINFUSIONS(INCLUDINGBLOODANDBLOODCELLULARPRODUCTS)AREADMINISTEREDASPARTOFTHEAFTER-TREATMENTAFTERTHEOPERATIONORCONFINEMENT,NOEXTRAFEESSHALLBECHARGEDASTHISISINCLUDEDINTHEGLOBALOPERATIVEORMATERNITYFEES.SHOULDTHEPRACTITIONERDOINGTHEOPERATIONORATTENDINGTOTHEMATERNITYCASEPREFERTOASKANOTHERPRACTITIONERTOPERFORMPOST-OPERATIVEORPOST-CONFINEMENTINTRAVENOUSINFUSIONS,THENTHEPRACTITIONERHIMSELF(ANDNOTTHEPATIENT)SHALLBERESPONSIBLEFORREMUNERATINGSUCHPRACTITIONERFORTHEINFUSIONS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 11, "Operations previously performed by other surgeons: Where an operation is performed which has been previously performed by another surgeon, e.g. a revision or repeat operation, the fee shall be calculated according to the tariff for the full operation plus an additional fee to be negotiated under general Rule J: In exceptional cases where the fee is disproportionately low in relation to actual service rendered, except where already specified in the tariff", 11, "OPERATIONSPREVIOUSLYPERFORMEDBYOTHERSURGEONS:WHEREANOPERATIONISPERFORMEDWHICHHASBEENPREVIOUSLYPERFORMEDBYANOTHERSURGEON,E.G.AREVISIONORREPEATOPERATION,THEFEESHALLBECALCULATEDACCORDINGTOTHETARIFFFORTHEFULLOPERATIONPLUSANADDITIONALFEETOBENEGOTIATEDUNDERGENERALRULEJ:INEXCEPTIONALCASESWHERETHEFEEISDISPROPORTIONATELYLOWINRELATIONTOACTUALSERVICERENDERED,EXCEPTWHEREALREADYSPECIFIEDINTHETARIFF", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 10, "Endoscopic examinations done at operations: Where a related endoscopic examination is done at an operation by the operating surgeon or the attending anaesthesiologist, only 50% of the fee for the endoscopic examination may be charged", 10, "ENDOSCOPICEXAMINATIONSDONEATOPERATIONS:WHEREARELATEDENDOSCOPICEXAMINATIONISDONEATANOPERATIONBYTHEOPERATINGSURGEONORTHEATTENDINGANAESTHESIOLOGIST,ONLY50%OFTHEFEEFORTHEENDOSCOPICEXAMINATIONMAYBECHARGED", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 9, "Emergency procedures: Any bona fide, justifiable emergency procedure (all hours) undertaken in an operating theatre and/or in another setting in lieu of an operating theatre, will attract an additional 12,00 clinical procedure units per half-hour or part thereof of the operating time for all members of the surgical team. Modifier 0011 does not apply in respect of patients on scheduled lists. (A medical emergency is any condition where death or irreparable harm to the patient will result if there are undue delays in receiving appropriate medical treatment)", 9, "EMERGENCYPROCEDURES:ANYBONAFIDE,JUSTIFIABLEEMERGENCYPROCEDURE(ALLHOURS)UNDERTAKENINANOPERATINGTHEATREAND/ORINANOTHERSETTINGINLIEUOFANOPERATINGTHEATRE,WILLATTRACTANADDITIONAL12,00CLINICALPROCEDUREUNITSPERHALF-HOURORPARTTHEREOFOFTHEOPERATINGTIMEFORALLMEMBERSOFTHESURGICALTEAM.MODIFIER0011DOESNOTAPPLYINRESPECTOFPATIENTSONSCHEDULEDLISTS.(AMEDICALEMERGENCYISANYCONDITIONWHEREDEATHORIRREPARABLEHARMTOTHEPATIENTWILLRESULTIFTHEREAREUNDUEDELAYSINRECEIVINGAPPROPRIATEMEDICALTREATMENT)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 8, "Local anaesthetic: (a) A fee for a local anaesthetic administered by the operator may only be charged for (1) an operation or procedure having a value greater than 30,00 clinical procedure units (i.e. 31,00 or more clinical procedure units allocated to a single item) or (2) where more than one operation or procedure is done at the same time with a combined value greater than 50,00 clinical procedure units. (b) The fee shall be calculated according to the basic anaesthetic units for the specific operation. Anaesthetic time may not be charged for, but the minimum fee as per Modifier 0036: Anaesthetic administered by a general practitioner, shall be applicable in such a case. (c) Not applicable to radiological procedures (such as angiography and myelography. (d) No fee may be levied for topical application of local anaesthetic. (e) Please note: Modifier 0010: Local anaesthetic administered by the operator, may not be added on the surgeon?s account for procedures that were performed under general anaesthetic.", 8, "LOCALANAESTHETIC:(A)AFEEFORALOCALANAESTHETICADMINISTEREDBYTHEOPERATORMAYONLYBECHARGEDFOR(1)ANOPERATIONORPROCEDUREHAVINGAVALUEGREATERTHAN30,00CLINICALPROCEDUREUNITS(I.E.31,00ORMORECLINICALPROCEDUREUNITSALLOCATEDTOASINGLEITEM)OR(2)WHEREMORETHANONEOPERATIONORPROCEDUREISDONEATTHESAMETIMEWITHACOMBINEDVALUEGREATERTHAN50,00CLINICALPROCEDUREUNITS.(B)THEFEESHALLBECALCULATEDACCORDINGTOTHEBASICANAESTHETICUNITSFORTHESPECIFICOPERATION.ANAESTHETICTIMEMAYNOTBECHARGEDFOR,BUTTHEMINIMUMFEEASPERMODIFIER0036:ANAESTHETICADMINISTEREDBYAGENERALPRACTITIONER,SHALLBEAPPLICABLEINSUCHACASE.(C)NOTAPPLICABLETORADIOLOGICALPROCEDURES(SUCHASANGIOGRAPHYANDMYELOGRAPHY.(D)NOFEEMAYBELEVIEDFORTOPICALAPPLICATIONOFLOCALANAESTHETIC.(E)PLEASENOTE:MODIFIER0010:LOCALANAESTHETICADMINISTEREDBYTHEOPERATOR,MAYNOTBEADDEDONTHESURGEON?SACCOUNTFORPROCEDURESTHATWEREPERFORMEDUNDERGENERALANAESTHETIC.", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 35, "When item 1288 (Cardiac catheterisation for congenital heart disease: All ages above 1 year old) or item 1289 (Paediatric cardiac catheterisation: Infants below the age of one year) is performed by paediatric cardiologists (?33?): fee for procedure + 100%", 35, "WHENITEM1288(CARDIACCATHETERISATIONFORCONGENITALHEARTDISEASE:ALLAGESABOVE1YEAROLD)ORITEM1289(PAEDIATRICCARDIACCATHETERISATION:INFANTSBELOWTHEAGEOFONEYEAR)ISPERFORMEDBYPAEDIATRICCARDIOLOGISTS(?33?):FEEFORPROCEDURE+100%", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 6, "Specialist surgeon assistant: Where a procedure requires a registered specialist surgeon assistant, the fee is 33,33% (1/3) of the fee for the specialist surgeon", 6, "SPECIALISTSURGEONASSISTANT:WHEREAPROCEDUREREQUIRESAREGISTEREDSPECIALISTSURGEONASSISTANT,THEFEEIS33,33%(1/3)OFTHEFEEFORTHESPECIALISTSURGEON", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 5, "a) Use of own monitoring equipment in the rooms:  Remuneration for the use of any type of own monitoring equipment in the rooms for procedures performed under intravenous sedation - 15,00 clinical procedure units irrespective of the number of items of equipment provided.\\r\\nb) Use of own equipment in hospital theatre or unattached theatre unit:  Remuneration for the use of any type of own equipment for procedures performed in a hospital theatre or unattached theatre unit when appropriate equipment is not provided by the hospital - 15,00 clinical procedure units irrespective of the number of items of equipment provided.", 5, @"
    A) USEOFOWNMONITORINGEQUIPMENTINTHEROOMS : REMUNERATIONFORTHEUSEOFANYTYPEOFOWNMONITORINGEQUIPMENTINTHEROOMSFORPROCEDURESPERFORMEDUNDERINTRAVENOUSSEDATION - 15, 00 CLINICALPROCEDUREUNITSIRRESPECTIVEOFTHENUMBEROFITEMSOFEQUIPMENTPROVIDED.\R\ NB) USEOFOWNEQUIPMENTINHOSPITALTHEATREORUNATTACHEDTHEATREUNIT : REMUNERATIONFORTHEUSEOFANYTYPEOFOWNEQUIPMENTFORPROCEDURESPERFORMEDINAHOSPITALTHEATREORUNATTACHEDTHEATREUNITWHENAPPROPRIATEEQUIPMENTISNOTPROVIDEDBYTHEHOSPITAL - 15, 00 CLINICALPROCEDUREUNITSIRRESPECTIVEOFTHENUMBEROFITEMSOFEQUIPMENTPROVIDED.
", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 4, "Visiting specialists performing procedures:  Where specialists visit smaller centres to perform procedures, fees for these particular procedures are exclusive of after-care. The referring practitioner will then be entitled to subsequent hospital visits for after-care. If the referring practitioner is not available, the specialist shall, on consultation with the patient, choose an appropriate locum tenens. Both the surgeon and the practitioner who handled the after-care, must in such instances quote Modifier 0006 with the particular items which they use", 4, "VISITINGSPECIALISTSPERFORMINGPROCEDURES:WHERESPECIALISTSVISITSMALLERCENTRESTOPERFORMPROCEDURES,FEESFORTHESEPARTICULARPROCEDURESAREEXCLUSIVEOFAFTER-CARE.THEREFERRINGPRACTITIONERWILLTHENBEENTITLEDTOSUBSEQUENTHOSPITALVISITSFORAFTER-CARE.IFTHEREFERRINGPRACTITIONERISNOTAVAILABLE,THESPECIALISTSHALL,ONCONSULTATIONWITHTHEPATIENT,CHOOSEANAPPROPRIATELOCUMTENENS.BOTHTHESURGEONANDTHEPRACTITIONERWHOHANDLEDTHEAFTER-CARE,MUSTINSUCHINSTANCESQUOTEMODIFIER0006WITHTHEPARTICULARITEMSWHICHTHEYUSE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 3, "Multiple therapeutic procedures/operations under the same anaesthetic:\\r\\na) Unless otherwise identified in the tariff when multiple therapeutic procedures/operations add significant time and/or complexity, and when each procedure/operation is clearly identified and defined, the following values shall prevail:  100% (full value) for the first or major procedure/operation, 75% for the second procedure/operation, 50% for the third procedure/operation, 25% for the fourth and subsequent procedures/operations. This modifier does not apply to purely diagnostic procedures.\\r\\nb) In the case of multiple fractures and/or dislocations the above values shall prevail.\\r\\nc) When purely diagnostic endoscopic procedures or diagnostic endoscopic procedures unrelated to any therapeutic procedures performed, are performed under the same general anaesthetic, Modifier 0005 is not applicable to the fees for such diagnostic endoscopic procedures as the fees for endoscopic procedures do not provide for after-care. Specify unrelated endoscopic procedure and provide diagnosis to indicate diagnostic endoscopic procedure(s) unrelated to other (therapeutic) procedures performed under the same anaesthetic.\\r\\nd) Please note:  When more than one small procedure is performed and the tariff makes provision for items for \"subsequent\" or \"maximum for multiple additional procedures\" (see Section 2. Integumentary System) Modifier 0005 is not applicable as the fee is already a reduced fee.\\r\\ne) ?+? Means that this item is used in addition to another definitive procedure and is therefore not subject to reduction according to Modifier 0005 (see also Modifier 0082)", 3, @"
                    MULTIPLETHERAPEUTICPROCEDURES / OPERATIONSUNDERTHESAMEANAESTHETIC: \R\ NA) UNLESSOTHERWISEIDENTIFIEDINTHETARIFFWHENMULTIPLETHERAPEUTICPROCEDURES / OPERATIONSADDSIGNIFICANTTIMEAND / ORCOMPLEXITY, ANDWHENEACHPROCEDURE / OPERATIONISCLEARLYIDENTIFIEDANDDEFINED, THEFOLLOWINGVALUESSHALLPREVAIL : 100 % (FULLVALUE) FORTHEFIRSTORMAJORPROCEDURE / OPERATION, 75 % FORTHESECONDPROCEDURE / OPERATION, 50 % FORTHETHIRDPROCEDURE / OPERATION, 25 % FORTHEFOURTHANDSUBSEQUENTPROCEDURES / OPERATIONS.THISMODIFIERDOESNOTAPPLYTOPURELYDIAGNOSTICPROCEDURES.\R\ NB) INTHECASEOFMULTIPLEFRACTURESAND / ORDISLOCATIONSTHEABOVEVALUESSHALLPREVAIL.\R\ NC) WHENPURELYDIAGNOSTICENDOSCOPICPROCEDURESORDIAGNOSTICENDOSCOPICPROCEDURESUNRELATEDTOANYTHERAPEUTICPROCEDURESPERFORMED,
        AREPERFORMEDUNDERTHESAMEGENERALANAESTHETIC,
        MODIFIER0005ISNOTAPPLICABLETOTHEFEESFORSUCHDIAGNOSTICENDOSCOPICPROCEDURESASTHEFEESFORENDOSCOPICPROCEDURESDONOTPROVIDEFORAFTER - CARE.SPECIFYUNRELATEDENDOSCOPICPROCEDUREANDPROVIDEDIAGNOSISTOINDICATEDIAGNOSTICENDOSCOPICPROCEDURE (S) UNRELATEDTOOTHER (THERAPEUTIC) PROCEDURESPERFORMEDUNDERTHESAMEANAESTHETIC.\R\ ND) PLEASENOTE : WHENMORETHANONESMALLPROCEDUREISPERFORMEDANDTHETARIFFMAKESPROVISIONFORITEMSFOR ""
    SUBSEQUENT ""
    OR ""
    MAXIMUMFORMULTIPLEADDITIONALPROCEDURES "" (SEESECTION2.INTEGUMENTARYSYSTEM) MODIFIER0005ISNOTAPPLICABLEASTHEFEEISALREADYAREDUCEDFEE.\R\ NE) ? + ? MEANSTHATTHISITEMISUSEDINADDITIONTOANOTHERDEFINITIVEPROCEDUREANDISTHEREFORENOTSUBJECTTOREDUCTIONACCORDINGTOMODIFIER0005 (SEEALSOMODIFIER0082)
", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 2, "Procedures performed in own procedure rooms: Procedures performed in doctors' own procedure rooms instead of in a hospital theatre or unattached theatre unit: as per fee for procedure + 100% (the value of modifier 0004 equals 100% of the value of the procedure performed). See Section V (Section G in SAMA's DBT) for a list of procedures, which are often done in rooms to which Modifier 0004 should not be applied. Please note: Only the medical practitioner who owns the facility and the equipment may charge modifier 0004. Only one person may claim this modifier for procedures performed in doctors' own procedure rooms", 2, "PROCEDURESPERFORMEDINOWNPROCEDUREROOMS:PROCEDURESPERFORMEDINDOCTORS'OWNPROCEDUREROOMSINSTEADOFINAHOSPITALTHEATREORUNATTACHEDTHEATREUNIT:ASPERFEEFORPROCEDURE+100%(THEVALUEOFMODIFIER0004EQUALS100%OFTHEVALUEOFTHEPROCEDUREPERFORMED).SEESECTIONV(SECTIONGINSAMA'SDBT)FORALISTOFPROCEDURES,WHICHAREOFTENDONEINROOMSTOWHICHMODIFIER0004SHOULDNOTBEAPPLIED.PLEASENOTE:ONLYTHEMEDICALPRACTITIONERWHOOWNSTHEFACILITYANDTHEEQUIPMENTMAYCHARGEMODIFIER0004.ONLYONEPERSONMAYCLAIMTHISMODIFIERFORPROCEDURESPERFORMEDINDOCTORS'OWNPROCEDUREROOMS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 1, "Written report on X-rays: The lowest level code for a new patient office (consulting rooms) visit, is applicable only where a radiologist is requested to give a written report on X-rays taken elsewhere and submitted to him. The above mentioned item and the lowest level initial hospital visit code, as appropriate are not to be used for routine reporting of X-rays taken elsewhere", 1, "WRITTENREPORTONX-RAYS:THELOWESTLEVELCODEFORANEWPATIENTOFFICE(CONSULTINGROOMS)VISIT,ISAPPLICABLEONLYWHEREARADIOLOGISTISREQUESTEDTOGIVEAWRITTENREPORTONX-RAYSTAKENELSEWHEREANDSUBMITTEDTOHIM.THEABOVEMENTIONEDITEMANDTHELOWESTLEVELINITIALHOSPITALVISITCODE,ASAPPROPRIATEARENOTTOBEUSEDFORROUTINEREPORTINGOFX-RAYSTAKENELSEWHERE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 16, "Where in the treatment of a specific fracture or dislocation (compound or closed) an initial procedure is followed within one month by an open reduction, internal fixation, external skeletal fixation or bone grafting on the same bone, the fee for the initial treatment of that fracture or dislocation shall be reduced by 50%.   Please note:  This reduction does not include the assistant?s fee where applicable.  After one month, a full fee as for the initial treatment, is applicable", 16, "WHEREINTHETREATMENTOFASPECIFICFRACTUREORDISLOCATION(COMPOUNDORCLOSED)ANINITIALPROCEDUREISFOLLOWEDWITHINONEMONTHBYANOPENREDUCTION,INTERNALFIXATION,EXTERNALSKELETALFIXATIONORBONEGRAFTINGONTHESAMEBONE,THEFEEFORTHEINITIALTREATMENTOFTHATFRACTUREORDISLOCATIONSHALLBEREDUCEDBY50%.PLEASENOTE:THISREDUCTIONDOESNOTINCLUDETHEASSISTANT?SFEEWHEREAPPLICABLE.AFTERONEMONTH,AFULLFEEASFORTHEINITIALTREATMENT,ISAPPLICABLE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 17, "A fracture NOT requiring reduction shall be charged on a fee per service basis", 17, "AFRACTURENOTREQUIRINGREDUCTIONSHALLBECHARGEDONAFEEPERSERVICEBASIS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 7, "Assistant: The fee for an assistant is 20% of the fee for the specialist surgeon, with a minimum of 36,00 clinical procedure units. The minimum fee payable may not be less than 36,00 clinical procedures units", 7, "ASSISTANT:THEFEEFORANASSISTANTIS20%OFTHEFEEFORTHESPECIALISTSURGEON,WITHAMINIMUMOF36,00CLINICALPROCEDUREUNITS.THEMINIMUMFEEPAYABLEMAYNOTBELESSTHAN36,00CLINICALPROCEDURESUNITS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 19, "Except where otherwise specified, in cases of compound fractures, 77,00 clinical procedure units (specialists) and 77,00 clinical procedure units (general practitioners) are to be added to the units for the fractures including debridement", 19, "EXCEPTWHEREOTHERWISESPECIFIED,INCASESOFCOMPOUNDFRACTURES,77,00CLINICALPROCEDUREUNITS(SPECIALISTS)AND77,00CLINICALPROCEDUREUNITS(GENERALPRACTITIONERS)ARETOBEADDEDTOTHEUNITSFORTHEFRACTURESINCLUDINGDEBRIDEMENT", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 32, "When endoscopic instruments are used during intranasal surgery: Add 10% of the fee of the procedure performed. Only applicable to items 1025, 1027, 1030, 1033, 1035, 1036, 1039, 1047, 1054 and 1083", 32, "WHENENDOSCOPICINSTRUMENTSAREUSEDDURINGINTRANASALSURGERY:ADD10%OFTHEFEEOFTHEPROCEDUREPERFORMED.ONLYAPPLICABLETOITEMS1025,1027,1030,1033,1035,1036,1039,1047,1054AND1083", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 18, "Where in the treatment of a fracture or dislocation, an initial closed reduction is followed within one month by further closed reductions under general anaesthesia, the fee for such subsequent reductions will be 27,00 clinical procedure units (not including after-care)", 18, "WHEREINTHETREATMENTOFAFRACTUREORDISLOCATION,ANINITIALCLOSEDREDUCTIONISFOLLOWEDWITHINONEMONTHBYFURTHERCLOSEDREDUCTIONSUNDERGENERALANAESTHESIA,THEFEEFORSUCHSUBSEQUENTREDUCTIONSWILLBE27,00CLINICALPROCEDUREUNITS(NOTINCLUDINGAFTER-CARE)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 31, "Microsurgery of the larynx: Add 25% to the fee of the operation performed (for other operations requiring the use of an operation microscope, the fee include the use of the microscope, except where otherwise specified elsewhere in the Tariff)", 31, "MICROSURGERYOFTHELARYNX:ADD25%TOTHEFEEOFTHEOPERATIONPERFORMED(FOROTHEROPERATIONSREQUIRINGTHEUSEOFANOPERATIONMICROSCOPE,THEFEEINCLUDETHEUSEOFTHEMICROSCOPE,EXCEPTWHEREOTHERWISESPECIFIEDELSEWHEREINTHETARIFF)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 30, "Microsurgery of the fallopian-tubes and ovaries: Where micro-surgical techniques are used, with the aid of a microscope, 25% may be added to the fee", 30, "MICROSURGERYOFTHEFALLOPIAN-TUBESANDOVARIES:WHEREMICRO-SURGICALTECHNIQUESAREUSED,WITHTHEAIDOFAMICROSCOPE,25%MAYBEADDEDTOTHEFEE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 29, "Additional operative procedures by same surgeon, under section 3.8.6: Spinal deformities, within a period of 12 months: 75% of scheduled fee for the lesser procedure, except where otherwise specified elsewhere", 29, "ADDITIONALOPERATIVEPROCEDURESBYSAMESURGEON,UNDERSECTION3.8.6:SPINALDEFORMITIES,WITHINAPERIODOF12MONTHS:75%OFSCHEDULEDFEEFORTHELESSERPROCEDURE,EXCEPTWHEREOTHERWISESPECIFIEDELSEWHERE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 28, "Where the replantation is unsuccessful, no further surgical fee is payable for amputation of the non-viable parts", 28, "WHERETHEREPLANTATIONISUNSUCCESSFUL,NOFURTHERSURGICALFEEISPAYABLEFORAMPUTATIONOFTHENON-VIABLEPARTS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 33, "Add 45,00 clinical procedure units to procedure(s) performed through a thorascope", 33, "ADD45,00CLINICALPROCEDUREUNITSTOPROCEDURE(S)PERFORMEDTHROUGHATHORASCOPE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 27, "Where two specialists work together on a replantation procedure, each shall be entitled to two-thirds of the fee for the procedure", 27, "WHERETWOSPECIALISTSWORKTOGETHERONAREPLANTATIONPROCEDURE,EACHSHALLBEENTITLEDTOTWO-THIRDSOFTHEFEEFORTHEPROCEDURE", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 25, "Revision operation for total joint replacement and immediate re-substitution (infected or non-infected): per fee for total joint replacement + 100%", 25, "REVISIONOPERATIONFORTOTALJOINTREPLACEMENTANDIMMEDIATERE-SUBSTITUTION(INFECTEDORNON-INFECTED):PERFEEFORTOTALJOINTREPLACEMENT+100%", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 24, "Multiple procedures on feet: In multiple procedures on feet, fees for the first foot are calculated according to Modifier 0005: Multiple procedures/operations under the same anaesthetic. Calculate fees for the second foot in the same way, reduce the total to 75% and add to the total for the first foot", 24, "MULTIPLEPROCEDURESONFEET:INMULTIPLEPROCEDURESONFEET,FEESFORTHEFIRSTFOOTARECALCULATEDACCORDINGTOMODIFIER0005:MULTIPLEPROCEDURES/OPERATIONSUNDERTHESAMEANAESTHETIC.CALCULATEFEESFORTHESECONDFOOTINTHESAMEWAY,REDUCETHETOTALTO75%ANDADDTOTHETOTALFORTHEFIRSTFOOT", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 23, "Dislocation requiring open reduction: Units for the specific joint plus 77,00 clinical procedure units for specialists. General practitioners add 77,00 clinical procedure units", 23, "DISLOCATIONREQUIRINGOPENREDUCTION:UNITSFORTHESPECIFICJOINTPLUS77,00CLINICALPROCEDUREUNITSFORSPECIALISTS.GENERALPRACTITIONERSADD77,00CLINICALPROCEDUREUNITS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 22, "Fracture requiring percutaneous internal fixation [insertion and removal of fixatives (wires) in respect of fingers and toes included]: Specialists and general practitioners add 32,00 clinical procedure units", 22, "FRACTUREREQUIRINGPERCUTANEOUSINTERNALFIXATION[INSERTIONANDREMOVALOFFIXATIVES(WIRES)INRESPECTOFFINGERSANDTOESINCLUDED]:SPECIALISTSANDGENERALPRACTITIONERSADD32,00CLINICALPROCEDUREUNITS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 21, "Fractures requiring open reduction, internal fixation, external skeletal fixation and/or bone grafting: Specialists add 77,00 clinical procedure units. General practitioners add 77,00 clinical procedure units", 21, "FRACTURESREQUIRINGOPENREDUCTION,INTERNALFIXATION,EXTERNALSKELETALFIXATIONAND/ORBONEGRAFTING:SPECIALISTSADD77,00CLINICALPROCEDUREUNITS.GENERALPRACTITIONERSADD77,00CLINICALPROCEDUREUNITS", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 20, "In cases of a compound fracture where a debridement is followed by internal fixation (excluding fixation with Kirschner wires, as well as  fractures of hands and feet), the full amount according to either Modifier 0049:  Cases of compound fractures, or Modifier 0051:  Fractures requiring open reduction, internal fixation, external skeletal fixation and/or bone grafting, may be added to the fee for the procedure involved, plus half of the amount according to the second modifier (either Modifier 0049: Cases of compound fractures or Modifier 0051: Fractures requiring open reduction, internal fixation, external skeletal fixation and/or bone grafting, as applicable) ", 20, "INCASESOFACOMPOUNDFRACTUREWHEREADEBRIDEMENTISFOLLOWEDBYINTERNALFIXATION(EXCLUDINGFIXATIONWITHKIRSCHNERWIRES,ASWELLASFRACTURESOFHANDSANDFEET),THEFULLAMOUNTACCORDINGTOEITHERMODIFIER0049:CASESOFCOMPOUNDFRACTURES,ORMODIFIER0051:FRACTURESREQUIRINGOPENREDUCTION,INTERNALFIXATION,EXTERNALSKELETALFIXATIONAND/ORBONEGRAFTING,MAYBEADDEDTOTHEFEEFORTHEPROCEDUREINVOLVED,PLUSHALFOFTHEAMOUNTACCORDINGTOTHESECONDMODIFIER(EITHERMODIFIER0049:CASESOFCOMPOUNDFRACTURESORMODIFIER0051:FRACTURESREQUIRINGOPENREDUCTION,INTERNALFIXATION,EXTERNALSKELETALFIXATIONAND/ORBONEGRAFTING,ASAPPLICABLE)", 2 });

            migrationBuilder.InsertData(
                table: "MedicalItemPublications",
                columns: new[] { "Id", "Description", "MedicalItemId", "NormalizedDescription", "PublicationId" },
                values: new object[] { 26, "Combined procedures on the spine: In cases of combined procedures on the spine, both the orthopaedic surgeon and the neurosurgeon are entitled to the full fee for the relevant part of the operation performed", 26, "COMBINEDPROCEDURESONTHESPINE:INCASESOFCOMBINEDPROCEDURESONTHESPINE,BOTHTHEORTHOPAEDICSURGEONANDTHENEUROSURGEONAREENTITLEDTOTHEFULLFEEFORTHERELEVANTPARTOFTHEOPERATIONPERFORMED", 2 });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(629), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(718), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(722), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(726), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(730), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(737), new DateTime(2019, 9, 21, 3, 51, 58, 680, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9080), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9165), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9169), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9176), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9176), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9180), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9184), new DateTime(2019, 9, 21, 3, 51, 58, 763, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1492), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1573), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1577), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1581), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1585), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1588), new DateTime(2019, 9, 21, 3, 51, 58, 751, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1464), new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1530), new DateTime(2019, 9, 21, 3, 51, 58, 577, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(6966), new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(9923), new DateTime(2019, 9, 21, 3, 51, 58, 601, DateTimeKind.Local).AddTicks(9931) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MedicalItemPublications",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DropColumn(
                name: "NormalizedDescription",
                table: "MedicalItemPublications");

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 906, DateTimeKind.Local).AddTicks(4327), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7617), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7647), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7655), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7663), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7667), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "FileStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7674), new DateTime(2019, 9, 19, 4, 34, 54, 911, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6108), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6170), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6174), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6182), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6189), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6193), new DateTime(2019, 9, 19, 4, 34, 54, 917, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9287), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9364), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9368), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9376), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9376), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "MedicalItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9380), new DateTime(2019, 9, 19, 4, 34, 54, 996, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5412), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5516), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5524), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5528), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5528), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5536), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "PractitionerGroupTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5539), new DateTime(2019, 9, 19, 4, 34, 55, 85, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4625), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4691), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4698), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4702), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4706), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "PractitionerTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4710), new DateTime(2019, 9, 19, 4, 34, 55, 69, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7412), new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "TariffTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7470), new DateTime(2019, 9, 19, 4, 34, 54, 922, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 944, DateTimeKind.Local).AddTicks(4580), new DateTime(2019, 9, 19, 4, 34, 54, 944, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "VatTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 9, 19, 4, 34, 54, 945, DateTimeKind.Local).AddTicks(1921), new DateTime(2019, 9, 19, 4, 34, 54, 945, DateTimeKind.Local).AddTicks(1929) });
        }
    }
}
