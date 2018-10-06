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
                    NormalizedName = Constants.Uploaded.ToUpper(),
                    Description = "Successfully uploaded the file",
                    NormalizedDescription = "SUCCESSFULLYUPLOADEDTHEFILE",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 2,
                    Name = Constants.Rejected,
                    NormalizedName = Constants.Rejected.ToUpper(),
                    Description = "The manager rejected the file",
                    NormalizedDescription = "THEMANAGERREJECTEDTHEFILE",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 3,
                    Name = Constants.Approved,
                    NormalizedName = Constants.Approved.ToUpper(),
                    Description = "Ready to submit to the Fund",
                    NormalizedDescription = "READYTOSUBMITTOTHEFUND",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 4,
                    Name = Constants.Submitted,
                    NormalizedName = Constants.Submitted.ToUpper(),
                    Description = "File successfully submitted to the Fund",
                    NormalizedDescription = "FILESUCCESSFULLYSUBMITTEDTOTHEFUND",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 5,
                    Name = Constants.PartiallyPaid,
                    NormalizedName = Constants.PartiallyPaid.ToUpper(),
                    Description = "Not all invoices were paid",
                    NormalizedDescription = "NOTALLINVOICESWEREPAID",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 6,
                    Name = Constants.Paid,
                    NormalizedName = Constants.Paid.ToUpper(),
                    Description = "All invoices were successfully paid",
                    NormalizedDescription = "ALLINVOICESWERESUCCESSFULLYPAID",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new FileStatus
                {
                    Id = 7,
                    Name = Constants.Overdue,
                    NormalizedName = Constants.Overdue.ToUpper(),
                    Description = "File Overdue",
                    NormalizedDescription = "FILEOVERDUE",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                }
            );
        }

    }
}