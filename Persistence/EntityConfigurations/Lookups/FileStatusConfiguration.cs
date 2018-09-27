using System;
using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Lookups
{
    public class FileStatusConfiguration : IEntityTypeConfiguration<FileStatus>
    {
        public void Configure(EntityTypeBuilder<FileStatus> builder)
        {
            builder.ConfigureLookup();
            this.SeedFileStatus(builder);
        }

        private void SeedFileStatus(EntityTypeBuilder<FileStatus> modelBuilder)
        {
            modelBuilder.HasData(
                new FileStatus
                {
                    Id = 1,
                    Name = Constants.Uploaded,
                    Description = "Successfully uploaded the file",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 2,
                    Name = Constants.Rejected,
                    Description = "The manager rejected the file",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 3,
                    Name = Constants.Approved,
                    Description = "Ready to submit to the Fund",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 4,
                    Name = Constants.Submitted,
                    Description = "File successfully submitted to the Fund",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 5,
                    Name = Constants.PartiallyPaid,
                    Description = "Not all invoices were paid",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 6,
                    Name = Constants.Paid,
                    Description = "All invoices were successfully paid",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 7,
                    Name = Constants.Overdue,
                    Description = "File Overdue",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                }
            );
        }

    }
}