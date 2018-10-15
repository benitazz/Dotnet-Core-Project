using System;

namespace MedicalBilingBackEnd.Resources.ApiToDomainResource.FileUploads
{
    public class TariffFileResource: FileUploadResource
    {
        public DateTime From { get; set; }

        public int VatId { get; set; }
    }
}