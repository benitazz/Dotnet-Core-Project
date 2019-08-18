namespace MedicalEngineMicroService.Resources.ApiToDomainResource.FileUploads
{
    public class FileUploadResource
    {
        public string Filename { get; set; }
        public string Base64EncodedData { get; set; }
    }
}