using System;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using MedicalBilingBackEnd.Persistence.EntityConfigurations.Lookups;
using MedicalBilingMicroservice.Persistence.EntityConfigurations.Users;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingBackEnd.Common.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new FileStatusConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceStatusConfiguration());
            // modelBuilder.ApplyConfiguration(new LookupConfiguration<FileStatus>());

            // SeedFileStatus(modelBuilder);
            // SeedInvoiceStatus(modelBuilder);
        }

        /*private static void SeedFileStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileStatus>().HasData(
               new FileStatus
               {
                   Id = 1,
                   Name = Constants.Uploaded,
                   Description = "Successfully uploaded the file",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.UtcNow,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.UtcNow
               },
               new FileStatus
               {
                   Id = 2,
                   Name = Constants.Rejected,
                   Description = "The manager rejected the file",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.UtcNow,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.UtcNow
               },
               new FileStatus
               {
                   Id = 3,
                   Name = Constants.Approved,
                   Description = "Ready to submit to the Fund",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.UtcNow,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.UtcNow
               },
               new FileStatus
               {
                   Id = 4,
                   Name = Constants.Submitted,
                   Description = "File successfully submitted to the Fund",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.UtcNow,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.UtcNow
               },
               new FileStatus
               {
                   Id = 5,
                   Name = Constants.PartiallyPaid,
                   Description = "Not all invoices were paid",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.UtcNow,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.UtcNow
               },
               new FileStatus
               {
                   Id = 6,
                   Name = Constants.Paid,
                   Description = "All invoices were successfully paid",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.UtcNow,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.UtcNow
               },
               new FileStatus
               {
                   Id = 7,
                   Name = Constants.Overdue,
                   Description = "File Overdue",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.UtcNow,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.UtcNow
               }
           );
        }*/

        /* private static void SeedInvoiceStatus(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<InvoiceStatus>().HasData(
                new InvoiceStatus { Id = 1, Name = "Pending", Description = "Pending" },
                new InvoiceStatus { Id = 2, Name = "Approved", Description = "Approved" },
                new InvoiceStatus { Id = 3, Name = "Rejected", Description = "Payment rejected" },
                new InvoiceStatus { Id = 4, Name = "Submitted", Description = "Invoice submitted to the fund" },
                new InvoiceStatus { Id = 5, Name = "Paid", Description = "Invoice paid" }
            );
         }*/
    }
}