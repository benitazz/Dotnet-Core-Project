using System;
using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Medical {
    public class PractitionerTypeConfiguration : IEntityTypeConfiguration<PractitionerType> {
        public void Configure (EntityTypeBuilder<PractitionerType> builder) {
            builder.ConfigureLookup ();
            SeedPractitionerType (builder);
        }


        private void SeedPractitionerType (EntityTypeBuilder<PractitionerType> modelBuilder) {
            modelBuilder.HasData (
                new PractitionerType {
                    Id = 1,
                        Name = "Hospital",
                        Description = "Hospital",
                        NormalizedName = "HOSPITAL",
                        NormalizedDescription = "HOSPITAL",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerType {
                    Id = 2,
                        Name = "Dentist",
                        Description = "Dentist",
                        NormalizedName = "DENTIST",
                        NormalizedDescription = "DENTIST",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerType {
                    Id = 3,
                        Name = "Ambulance",
                        Description = "Ambulance",
                        NormalizedName = "AMBULANCE",
                        NormalizedDescription = "AMBULANCE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerType {
                    Id = 4,
                        Name = "Specialist",
                        Description = "Specialist",
                        NormalizedName = "SPECIALIST",
                        NormalizedDescription = "SPECIALIST",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerType {
                    Id = 5,
                        Name = "Anaesthetist",
                        Description = "Anaesthetist",
                        NormalizedName = "ANAESTHETIST",
                        NormalizedDescription = "ANAESTHETIST",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerType {
                    Id = 6,
                        Name = "GP",
                        Description = "General Practitioner",
                        NormalizedName = "GP",
                        NormalizedDescription = "GENERALPRACTITIONER",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                }
            );
        }
    }
}