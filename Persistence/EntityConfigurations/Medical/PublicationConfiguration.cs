using System;
using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Medical {
    public class PublicationTypeConfiguration : IEntityTypeConfiguration<Publication> {
        public void Configure (EntityTypeBuilder<Publication> builder) {
            builder.ConfigureLookupDescription ();

            builder.Property (t => t.PublicationNo)
                .IsRequired ()
                .HasMaxLength (15);

            this.SeedPublications (builder);
        }

        private void SeedPublications (EntityTypeBuilder<Publication> modelBuilder) {
            modelBuilder.HasData (
                new Publication { Id = 1, Description = "Unknown Type of Publication", NormalizedDescription = "UNKNOWNTYPEOFPUBLICATION", PublicationNo = "" },
                new Publication { Id = 2, Description = "MEDICAL PRACTITIONERS", NormalizedDescription = "MEDICALPRACTITIONERS", PublicationNo = "P01" },
                new Publication { Id = 3, Description = "DENTAL", NormalizedDescription = "DENTAL", PublicationNo = "P02" },
                new Publication { Id = 4, Description = "AMBULANCE SERVICES", NormalizedDescription = "AMBULANCESERVICES", PublicationNo = "P03" },
                new Publication { Id = 5, Description = "OCCUPATIONAL AND ART THERAPY", NormalizedDescription = "OCCUPATIONALANDARTTHERAPY", PublicationNo = "P04" },
                new Publication { Id = 6, Description = "CHIROPRACTORS", NormalizedDescription = "CHIROPRACTORS", PublicationNo = "P05" },
                new Publication { Id = 7, Description = "CLINICAL TECHNOLOGY", NormalizedDescription = "CLINICALTECHNOLOGY", PublicationNo = "P06" },
                new Publication { Id = 8, Description = "DIETICIANS", NormalizedDescription = "DIETICIANS", PublicationNo = "P07" },
                new Publication { Id = 9, Description = "DENTAL THERAPY", NormalizedDescription = "DENTALTHERAPY", PublicationNo = "P08" },
                new Publication { Id = 10, Description = "HEARING AID ACCOUSTICIANS", NormalizedDescription = "HEARINGAIDACCOUSTICIANS", PublicationNo = "P09" },
                new Publication { Id = 11, Description = "HOMOEOPATHS", NormalizedDescription = "HOMOEOPATHS", PublicationNo = "P10" },
                new Publication { Id = 12, Description = "REGISTERED NURSES IN PRIVATE PRACTICE", NormalizedDescription = "REGISTEREDNURSESINPRIVATEPRACTICE", PublicationNo = "P11" },
                new Publication { Id = 13, Description = "PHYSIOTHERAPY", NormalizedDescription = "PHYSIOTHERAPY", PublicationNo = "P12" },
                new Publication { Id = 14, Description = "PODIATRY", NormalizedDescription = "PODIATRY", PublicationNo = "P13" },
                new Publication { Id = 15, Description = "PSYCHOLOGY", NormalizedDescription = "PSYCHOLOGY", PublicationNo = "P14" },
                new Publication { Id = 16, Description = "RADIOGRAPHY", NormalizedDescription = "RADIOGRAPHY", PublicationNo = "P15" },
                new Publication { Id = 17, Description = "SOCIAL WORKERS IN PRIVATE PRACTICE", NormalizedDescription = "SOCIALWORKERSINPRIVATEPRACTICE", PublicationNo = "P16" },
                new Publication { Id = 18, Description = "SPEECH THERAPISTS AND AUDIOLOGISTS", NormalizedDescription = "SPEECHTHERAPISTSANDAUDIOLOGISTS", PublicationNo = "P17" },
                new Publication { Id = 19, Description = "PRIVATE HOSPITALS", NormalizedDescription = "PRIVATEHOSPITALS", PublicationNo = "P20" },
                new Publication { Id = 20, Description = "ORTHOPTISTS", NormalizedDescription = "ORTHOPTISTS", PublicationNo = "P21" },
                new Publication { Id = 21, Description = "BIOKINETICS", NormalizedDescription = "BIOKINETICS", PublicationNo = "P22" },
                new Publication { Id = 22, Description = "MEDICAL TECHNOLOGY", NormalizedDescription = "MEDICALTECHNOLOGY", PublicationNo = "P23" },
                new Publication { Id = 23, Description = "NURSING AGENCIES", NormalizedDescription = "NURSINGAGENCIES", PublicationNo = "P24" },
                new Publication { Id = 24, Description = "MEDICAL SCIENTISTS", NormalizedDescription = "MEDICALSCIENTISTS", PublicationNo = "P25" },
                new Publication { Id = 25, Description = "ART THERAPY", NormalizedDescription = "ARTTHERAPY", PublicationNo = "P26" },
                new Publication { Id = 26, Description = "DENTAL TECHNICIANS", NormalizedDescription = "DENTALTECHNICIANS", PublicationNo = "P18" },
                new Publication { Id = 27, Description = "PATHOLOGY", NormalizedDescription = "PATHOLOGY", PublicationNo = "P27" },
                new Publication { Id = 28, Description = "DENTAL - CDT", NormalizedDescription = "DENTAL-CDT", PublicationNo = "P28" },
                new Publication { Id = 29, Description = "RADIOLOGY", NormalizedDescription = "RADIOLOGY", PublicationNo = "P29" },
                new Publication { Id = 30, Description = "PHARMACISTS", NormalizedDescription = "PHARMACISTS", PublicationNo = "P30" },
                new Publication { Id = 31, Description = "ORTHOTISTS AND PROSTHETISTS", NormalizedDescription = "ORTHOTISTSANDPROSTHETISTS", PublicationNo = "P31" },
                new Publication { Id = 32, Description = "PHYSICAL REHABILITATION HOSPITALS", NormalizedDescription = "PHYSICALREHABILITATIONHOSPITALS", PublicationNo = "P32" },
                new Publication { Id = 33, Description = "MENTAL HEALTH INSTITUTIONS", NormalizedDescription = "MENTALHEALTHINSTITUTIONS", PublicationNo = "P33" },
                new Publication { Id = 34, Description = "UNATTACHED OPERATING THEATRE UNITS", NormalizedDescription = "UNATTACHEDOPERATINGTHEATREUNITS", PublicationNo = "P34" },
                new Publication { Id = 35, Description = "HOSPICES", NormalizedDescription = "HOSPICES", PublicationNo = "P35" },
                new Publication { Id = 36, Description = "SUB ACUTE FACILITIES", NormalizedDescription = "SUBACUTEFACILITIES", PublicationNo = "P36" },
                new Publication { Id = 37, Description = "OPTOMETRISTS", NormalizedDescription = "OPTOMETRISTS", PublicationNo = "P37" },
                new Publication { Id = 38, Description = "UNIFORM PATIENT FEE SCHEDULE", NormalizedDescription = "UNIFORMPATIENTFEESCHEDULE", PublicationNo = "P38" },
                new Publication { Id = 39, Description = "PSYCHOMETRY AND REGISTERED COUNCELLORS", NormalizedDescription = "PSYCHOMETRYANDREGISTEREDCOUNCELLORS", PublicationNo = "P39" },
                new Publication { Id = 40, Description = "OSTEOPATHY", NormalizedDescription = "OSTEOPATHY", PublicationNo = "P40" },
                new Publication { Id = 41, Description = "PHYTOTHERAPY", NormalizedDescription = "PHYTOTHERAPY", PublicationNo = "P41" },
                new Publication { Id = 42, Description = "TISSUE TRANSPORTATION", NormalizedDescription = "TISSUETRANSPORTATION", PublicationNo = "P42" },
                new Publication { Id = 43, Description = "NATUROPATHS", NormalizedDescription = "NATUROPATHS", PublicationNo = "P43" },
                new Publication { Id = 44, Description = "ACUPUNCTURE AND CHINESE MEDICINE", NormalizedDescription = "ACUPUNCTUREANDCHINESEMEDICINE", PublicationNo = "P44" },
                new Publication { Id = 45, Description = "THERAPEUTIC REFLEXOLOGY", NormalizedDescription = "THERAPEUTICREFLEXOLOGY", PublicationNo = "P45" },
                new Publication { Id = 46, Description = "MEDICAL PHYSICISTS", NormalizedDescription = "MEDICALPHYSICISTS", PublicationNo = "P46" },
                new Publication { Id = 47, Description = "MEDICLINIC", NormalizedDescription = "MEDICLINIC", PublicationNo = "P47" },
                new Publication { Id = 48, Description = "TEBA", NormalizedDescription = "TEBA", PublicationNo = "P48" },
                new Publication { Id = 49, Description = "NHN", NormalizedDescription = "NHN", PublicationNo = "P49" },
                new Publication { Id = 50, Description = "NETCARE", NormalizedDescription = "NETCARE", PublicationNo = "P50" },
                new Publication { Id = 51, Description = "UNKNOWN / COIDA NORMALISED", NormalizedDescription = "UNKNOWN/COIDANORMALISED", PublicationNo = "P51" },
                new Publication { Id = 52, Description = "NAPPI", NormalizedDescription = "NAPPI", PublicationNo = "P52" },
                new Publication { Id = 53, Description = "COID UNIT RATE", NormalizedDescription = "COIDUNITRATE", PublicationNo = "P53" },
                new Publication { Id = 54, Description = "DR BRUNS", NormalizedDescription = "DRBRUNS", PublicationNo = "P54" },
                new Publication { Id = 55, Description = "RMA ORTHOTIST", NormalizedDescription = "RMAORTHOTIST", PublicationNo = "P55" },
                new Publication { Id = 56, Description = "UNKNOWN", NormalizedDescription = "UNKNOWN", PublicationNo = "P56" },
                new Publication { Id = 57, Description = "Blood Transfusion", NormalizedDescription = "BLOODTRANSFUSION", PublicationNo = "P57" },
                new Publication { Id = 58, Description = "Renal Care", NormalizedDescription = "RENALCARE", PublicationNo = "P58" });
        }
    }
}