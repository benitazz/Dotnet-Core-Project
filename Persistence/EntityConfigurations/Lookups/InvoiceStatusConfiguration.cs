using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Common;
using System;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Lookups
{
    public class InvoiceStatusConfiguration : IEntityTypeConfiguration<InvoiceStatus>
    {
        public void Configure(EntityTypeBuilder<InvoiceStatus> builder)
        {
            builder.ConfigureLookup();
            this.SeedInvoiceStatus(builder);
        }

        private void SeedInvoiceStatus(EntityTypeBuilder<InvoiceStatus> modelBuilder)
        {
            modelBuilder.HasData(
               new InvoiceStatus
               {
                   Id = 1,
                   Name = Constants.Pending,
                   Description = Constants.Pending,
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 2,
                   Name = Constants.Approved,
                   Description = Constants.Approved,
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 3,
                   Name = Constants.Rejected,
                   Description = "Payment rejected",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 4,
                   Name = Constants.Submitted,
                   Description = "Invoice submitted to the fund",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 5,
                   Name = Constants.Paid,
                   Description = "Invoice paid",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 6,
                   Name = Constants.Overdue,
                   Description = "Invoice Overdue",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               }
           );
        }
    }
}