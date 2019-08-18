using System;

namespace MedicalEngineMicroService.Core.Models.Entities.Invoices
{
    public class InvoiceTransaction
    {
        public int Id { get; set; }

        // public BulkInvoice BulkInvoice { get; set; }

        public int BulkInvoiceId { get; set; }

        public string PracticeNo { get; set; }

        public DateTime InvoiceDate { get; set; }

        public DateTime ProcedureDate { get; set; }

        public DateTime DateOfInjury { get; set; }

        public DateTime TreatmentDateFrom { get; set; }

        public DateTime TreatmentDateTo { get; set; }

        public string TreatmentTimeFrom { get; set; }

        public string TreatmentTimeTo { get; set; }

        public string ClaimReferenceNumber { get; set; }

        public string InvoiceNumber { get; set; }

        public Double Amount { get; set; }

    }
}