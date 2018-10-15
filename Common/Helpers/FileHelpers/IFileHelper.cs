namespace MedicalBilingBackEnd.Common.Helpers.FileHelpers
{
    public interface IFileHelper
    {
         string DecodeBase64String(string fileContent);

         string CalculateCrypto(string fileContent);
    }
}