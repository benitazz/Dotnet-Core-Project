using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class TariffBaseUnitCostTypeConfiguration : IEntityTypeConfiguration<TariffBaseUnitCostType> {
        public void Configure (EntityTypeBuilder<TariffBaseUnitCostType> builder) {
            builder.ConfigureLookup ();
            this.SeedTariffBaseUnitCostType (builder);
        }

        private void SeedTariffBaseUnitCostType (EntityTypeBuilder<TariffBaseUnitCostType> modelBuilder) {
            modelBuilder.HasData (
                new TariffBaseUnitCostType { Id = 1, Name = "CONS", NormalizedName = "CONS", Description = "CONSULTATION", NormalizedDescription = "CONSULTATION" },
                new TariffBaseUnitCostType { Id = 2, Name = "ANA", NormalizedName = "ANA", Description = "ANAESTHETIC", NormalizedDescription = "ANAESTHETIC" },
                new TariffBaseUnitCostType { Id = 3, Name = "CLIN", NormalizedName = "CLIN", Description = "CLINICAL PROCEDURES", NormalizedDescription = "CLINICALPROCEDURES" },
                new TariffBaseUnitCostType { Id = 4, Name = "RAD", NormalizedName = "RAD", Description = "RADIOLOGY", NormalizedDescription = "RADIOLOGY" },
                new TariffBaseUnitCostType { Id = 5, Name = "PATH", NormalizedName = "PATH", Description = "PATHOLOGY", NormalizedDescription = "PATHOLOGY" },
                new TariffBaseUnitCostType { Id = 6, Name = "RADONC", NormalizedName = "RADONC", Description = "RADIATION ONCOLOGY", NormalizedDescription = "RADIATIONONCOLOGY" },
                new TariffBaseUnitCostType { Id = 7, Name = "DENTAL", NormalizedName = "DENTAL", Description = "DENTAL PROCEDURES", NormalizedDescription = "DENTALPROCEDURES" },
                new TariffBaseUnitCostType { Id = 8, Name = "OCC", NormalizedName = "OCC", Description = "OCCUPATIONAL AND ART THERAPY", NormalizedDescription = "OCCUPATIONALANDARTTHERAPY" },
                new TariffBaseUnitCostType { Id = 9, Name = "CHI", NormalizedName = "CHI", Description = "CHIROPRACTOR", NormalizedDescription = "CHIROPRACTOR" },
                new TariffBaseUnitCostType { Id = 10, Name = "PHYSIO", NormalizedName = "PHYSIO", Description = "PHYSIOTHERAPY", NormalizedDescription = "PHYSIOTHERAPY" },
                new TariffBaseUnitCostType { Id = 11, Name = "AMB", NormalizedName = "AMB", Description = "AMBULANCE", NormalizedDescription = "AMBULANCE" },
                new TariffBaseUnitCostType { Id = 12, Name = "ORTPRO", NormalizedName = "ORTPRO", Description = "ORTHOTIST AND PROSTHETISTS", NormalizedDescription = "ORTHOTISTANDPROSTHETISTS" },
                new TariffBaseUnitCostType { Id = 13, Name = "NAPPI", NormalizedName = "NAPPI", Description = "NAPPI", NormalizedDescription = "NAPPI" },
                new TariffBaseUnitCostType { Id = 14, Name = "PRIHOSP", NormalizedName = "PRIHOSP", Description = "PRIVATE HOSPITAL", NormalizedDescription = "PRIVATEHOSPITAL" },
                new TariffBaseUnitCostType { Id = 15, Name = "SUBACUTE", NormalizedName = "SUBACUTE", Description = "SUBACUTE FACILITY", NormalizedDescription = "SUBACUTEFACILITY" },
                new TariffBaseUnitCostType { Id = 16, Name = "REHAB", NormalizedName = "REHAB", Description = "REHABILITATION HOSPITAL", NormalizedDescription = "REHABILITATIONHOSPITAL" },
                new TariffBaseUnitCostType { Id = 17, Name = "PHAR", NormalizedName = "PHAR", Description = "PHARMACY", NormalizedDescription = "PHARMACY" },
                new TariffBaseUnitCostType { Id = 18, Name = "ORTH", NormalizedName = "ORTH", Description = "ORTHOTIST", NormalizedDescription = "ORTHOTIST" },
                new TariffBaseUnitCostType { Id = 19, Name = "NURSE", NormalizedName = "NURSE", Description = "REGISTERED NURSE", NormalizedDescription = "REGISTEREDNURSE" },
                new TariffBaseUnitCostType { Id = 20, Name = "NHN", NormalizedName = "NHN", Description = "NHN", NormalizedDescription = "NHN" },
                new TariffBaseUnitCostType { Id = 21, Name = "NETCARE", NormalizedName = "NETCARE", Description = "NETCARE", NormalizedDescription = "NETCARE" },
                new TariffBaseUnitCostType { Id = 22, Name = "MENTAL", NormalizedName = "MENTAL", Description = "MENTAL HEALTH", NormalizedDescription = "MENTALHEALTH" },
                new TariffBaseUnitCostType { Id = 23, Name = "MEDI", NormalizedName = "MEDI", Description = "MEDICLINIC", NormalizedDescription = "MEDICLINIC" },
                new TariffBaseUnitCostType { Id = 24, Name = "TEBA", NormalizedName = "TEBA", Description = "TEBA", NormalizedDescription = "TEBA" },
                new TariffBaseUnitCostType { Id = 25, Name = "ACU", NormalizedName = "ACU", Description = "ACUPUNCTURE", NormalizedDescription = "ACUPUNCTURE" },
                new TariffBaseUnitCostType { Id = 26, Name = "ART", NormalizedName = "ART", Description = "ART THERAPY", NormalizedDescription = "ARTTHERAPY" },
                new TariffBaseUnitCostType { Id = 27, Name = "BIOK", NormalizedName = "BIOK", Description = "BIOKINETICS", NormalizedDescription = "BIOKINETICS" },
                new TariffBaseUnitCostType { Id = 28, Name = "BRUNS", NormalizedName = "BRUNS", Description = "BRUNS", NormalizedDescription = "BRUNS" },
                new TariffBaseUnitCostType { Id = 29, Name = "CDT", NormalizedName = "CDT", Description = "DENTAL CDT", NormalizedDescription = "DENTALCDT" },
                new TariffBaseUnitCostType { Id = 30, Name = "CTEC", NormalizedName = "CTEC", Description = "CLINICAL TECHNOLOGY", NormalizedDescription = "CLINICALTECHNOLOGY" },
                new TariffBaseUnitCostType { Id = 31, Name = "DIET", NormalizedName = "DIET", Description = "DIETICIAN", NormalizedDescription = "DIETICIAN" },
                new TariffBaseUnitCostType { Id = 32, Name = "DTEC", NormalizedName = "DTEC", Description = "DENTAL TECHNICIAN", NormalizedDescription = "DENTALTECHNICIAN" },
                new TariffBaseUnitCostType { Id = 33, Name = "GENC", NormalizedName = "GENC", Description = "GENETIC COUNCELLOR", NormalizedDescription = "GENETICCOUNCELLOR" },
                new TariffBaseUnitCostType { Id = 34, Name = "HAAC", NormalizedName = "HAAC", Description = "HEARING AID ACOUSTICIAN", NormalizedDescription = "HEARINGAIDACOUSTICIAN" },
                new TariffBaseUnitCostType { Id = 35, Name = "HOMEO", NormalizedName = "HOMEO", Description = "HOMEOPATHY", NormalizedDescription = "HOMEOPATHY" },
                new TariffBaseUnitCostType { Id = 36, Name = "MTEC", NormalizedName = "MTEC", Description = "MEDICAL TECHNOLOGY", NormalizedDescription = "MEDICALTECHNOLOGY" },
                new TariffBaseUnitCostType { Id = 37, Name = "NATURO", NormalizedName = "NATURO", Description = "NATUROPATHY", NormalizedDescription = "NATUROPATHY" },
                new TariffBaseUnitCostType { Id = 38, Name = "NURSAG", NormalizedName = "NURSAG", Description = "NURSING AGENCY", NormalizedDescription = "NURSINGAGENCY" },
                new TariffBaseUnitCostType { Id = 39, Name = "OPTO", NormalizedName = "OPTO", Description = "OPTOMETRY", NormalizedDescription = "OPTOMETRY" },
                new TariffBaseUnitCostType { Id = 40, Name = "ORTHOP", NormalizedName = "ORTHOP", Description = "ORTHOPTISTS", NormalizedDescription = "ORTHOPTISTS" },
                new TariffBaseUnitCostType { Id = 41, Name = "OSTEO", NormalizedName = "OSTEO", Description = "OSTEOPATHY", NormalizedDescription = "OSTEOPATHY" },
                new TariffBaseUnitCostType { Id = 42, Name = "PAT", NormalizedName = "PAT", Description = "PATOLOGY", NormalizedDescription = "PATOLOGY" },
                new TariffBaseUnitCostType { Id = 43, Name = "PHYTO", NormalizedName = "PHYTO", Description = "PHYTOTHERAPY", NormalizedDescription = "PHYTOTHERAPY" },
                new TariffBaseUnitCostType { Id = 44, Name = "PODIAT", NormalizedName = "PODIAT", Description = "PODIATRY", NormalizedDescription = "PODIATRY" },
                new TariffBaseUnitCostType { Id = 45, Name = "PSYCHO", NormalizedName = "PSYCHO", Description = "PSYCHOLOGY", NormalizedDescription = "PSYCHOLOGY" },
                new TariffBaseUnitCostType { Id = 46, Name = "PSYCME", NormalizedName = "PSYCME", Description = "PSYCHOMETRY", NormalizedDescription = "PSYCHOMETRY" },
                new TariffBaseUnitCostType { Id = 47, Name = "RADIO", NormalizedName = "RADIO", Description = "RADIOLOGY NHRPL", NormalizedDescription = "RADIOLOGYNHRPL" },
                new TariffBaseUnitCostType { Id = 48, Name = "RADIOGR", NormalizedName = "RADIOGR", Description = "RADIOGRAPHY", NormalizedDescription = "RADIOGRAPHY" },
                new TariffBaseUnitCostType { Id = 49, Name = "SOCIAL", NormalizedName = "SOCIAL", Description = "SOCIAL WORKERS", NormalizedDescription = "SOCIALWORKERS" },
                new TariffBaseUnitCostType { Id = 50, Name = "SPEECH", NormalizedName = "SPEECH", Description = "SPEECH THERAPY AND AUDIOLOGY", NormalizedDescription = "SPEECHTHERAPYANDAUDIOLOGY" },
                new TariffBaseUnitCostType { Id = 51, Name = "TISSUE", NormalizedName = "TISSUE", Description = "TISSUE TRANSPLANT", NormalizedDescription = "TISSUETRANSPLANT" },
                new TariffBaseUnitCostType { Id = 52, Name = "UNATTACH", NormalizedName = "UNATTACH", Description = "UNATTACHED OPERATING THEATRE", NormalizedDescription = "UNATTACHEDOPERATINGTHEATRE" },
                new TariffBaseUnitCostType { Id = 53, Name = "UNIT", NormalizedName = "UNIT", Description = "COID UNIT", NormalizedDescription = "COIDUNIT" },
                new TariffBaseUnitCostType { Id = 54, Name = "UPFS", NormalizedName = "UPFS", Description = "UPFS", NormalizedDescription = "UPFS" },
                new TariffBaseUnitCostType { Id = 55, Name = "DENTT", NormalizedName = "DENTT", Description = "DENTAL THERAPY", NormalizedDescription = "DENTALTHERAPY" },
                new TariffBaseUnitCostType { Id = 56, Name = "NONE", NormalizedName = "NONE", Description = "NONE", NormalizedDescription = "NONE" },
                new TariffBaseUnitCostType { Id = 57, Name = "Blood", NormalizedName = "BLOOD", Description = "Blood Transfusion", NormalizedDescription = "BLOODTRANSFUSION" },
                new TariffBaseUnitCostType { Id = 58, Name = "Renal", NormalizedName = "RENAL", Description = "Renal Care", NormalizedDescription = "RENALCARE" }
            );
        }
    }
}