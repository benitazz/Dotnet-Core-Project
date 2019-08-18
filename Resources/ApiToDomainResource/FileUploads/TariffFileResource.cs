using System;

namespace MedicalEngineMicroService.Resources.ApiToDomainResource.FileUploads
{
    public class TariffFileResource: FileUploadResource
    {
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int VatId { get; set; }
        public int TariffTypeId { get; set; }
    }
}