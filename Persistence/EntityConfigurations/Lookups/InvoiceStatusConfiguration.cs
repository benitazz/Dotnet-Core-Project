using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Common;
using System;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Lookups
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
                   NormalizedName = Constants.Pending.ToUpper(),
                   Description = Constants.Pending,
                   NormalizedDescription = Constants.Pending.ToUpper(),
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 2,
                   Name = Constants.Approved,
                   NormalizedName = Constants.Approved.ToUpper(),
                   Description = Constants.Approved,
                   NormalizedDescription = Constants.Approved.ToUpper(),
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 3,
                   Name = Constants.Rejected,
                   NormalizedName = Constants.Rejected.ToUpper(),
                   Description = "Payment rejected",
                   NormalizedDescription = "PAYMENTREJECTED",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 4,
                   Name = Constants.Submitted,
                   NormalizedName = Constants.Submitted.ToUpper(),
                   Description = "Invoice submitted to the fund",
                   NormalizedDescription = "INVOICESUBMITTEDTOTHEFUND",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 5,
                   Name = Constants.Paid,
                   NormalizedName = Constants.Paid.ToUpper(),
                   Description = "Invoice paid",
                   NormalizedDescription = "INVOICEPAID",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               },
               new InvoiceStatus
               {
                   Id = 6,
                   Name = Constants.Overdue,
                   NormalizedName = Constants.Overdue.ToUpper(),
                   Description = "Invoice Overdue",
                   NormalizedDescription = "INVOICEOVERDUE",
                   CreatedBy = Constants.Administrator,
                   CreatedDate = DateTime.Now,
                   UpdatedBy = Constants.Administrator,
                   UpdatedDate = DateTime.Now
               }
           );
        }
    }
}