using System;
using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class PublicationTypeConfiguration : IEntityTypeConfiguration<PublicationType> {
        public void Configure (EntityTypeBuilder<PublicationType> builder) {
            builder.ConfigureLookup ();

            builder.Property (t => t.PublicationNo)
                .IsRequired ()
                .HasMaxLength (15);

            this.SeedPublications (builder);
        }

        private void SeedPublications (EntityTypeBuilder<PublicationType> modelBuilder) {
            modelBuilder.HasData (
                new PublicationType {
                    Id = 1,
                        Name = Constants.Chiropractor,
                        NormalizedName = Constants.Chiropractor.ToUpper (),
                        Description = "Chiropractor Tariffs",
                        NormalizedDescription = "CHIROPRACTORTARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 2,
                        Name = Constants.Radiologist,
                        NormalizedName = Constants.Radiologist.ToUpper (),
                        Description = "Radiologists Tariffs",
                        NormalizedDescription = "RADIOLOGISTSTARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 3,
                        Name = Constants.Dentist,
                        NormalizedName = Constants.Dentist.ToUpper (),
                        Description = "Dentists tarrifs",
                        NormalizedDescription = "DENTISTSTARRIFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 4,
                        Name = Constants.Physiotherapist,
                        NormalizedName = Constants.Physiotherapist.ToUpper (),
                        Description = "Physiotherapist tariffs",
                        NormalizedDescription = "PHYSIOTHERAPISTTARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 5,
                        Name = Constants.PrivateAmbulance,
                        NormalizedName = "PRIVATEAMBULANCE",
                        Description = "Private Ambulance Tariffs",
                        NormalizedDescription = "PRIVATEAMBULANCETARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 6,
                        Name = Constants.GeneralPractioner,
                        NormalizedName = "GENERALPRACTIONER",
                        Description = "General Practioner Tariffs",
                        NormalizedDescription = "GENERALPRACTIONERTARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 7,
                        Name = Constants.RenalCare,
                        NormalizedName = "RENALCARE",
                        Description = "Renal Care Tariffs",
                        NormalizedDescription = "RENALCARETARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 8,
                        Name = Constants.SocialWorker,
                        NormalizedName = "SOCIALWORKER",
                        Description = "Social Worker Tariffs",
                        NormalizedDescription = "SOCIALWORKERTARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                },
                new PublicationType {
                    Id = 9,
                        Name = Constants.WoundCare,
                        NormalizedName = "WOUNDCARE",
                        Description = "Wound Care Tariffs",
                        NormalizedDescription = "WOUNDCARETARIFFS",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now,
                        PublicationNo = "11111"
                }
            );
        }
    }
}