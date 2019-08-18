using System;

namespace MedicalEngineMicroService.Core.Models.Entities.Invoices
{
    public class BulkInvoice
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime ActionedDate { get; set; }
    }
}