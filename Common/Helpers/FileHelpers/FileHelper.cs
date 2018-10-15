using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace MedicalBilingBackEnd.Common.Helpers.FileHelpers
{
    public class FileHelper : IFileHelper
    {
        public string DecodeBase64String(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            var startingIndex = 0;
            return Encoding.UTF8.GetString(base64EncodedBytes, startingIndex, base64EncodedBytes.Length);

            /*var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);*/
        }

        public string CalculateCrypto(string fileContent)
        {
            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] fileBytes = Encoding.ASCII.GetBytes(fileContent);
                byte[] hashBytes = md5.ComputeHash(fileBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }

            /* var hash = new StringBuilder();
             var md5provider = new MD5CryptoServiceProvider();
             byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(fileContent));

             for (int i = 0; i < bytes.Length; i++)
             {
                 hash.Append(bytes[i].ToString("x2"));
             }
             return hash.ToString();*/
        }


        /*public void GetFileList<T, W>() where T : CsvMapping<T>
        {
              var csvParserOptions = new CsvParserOptions(true, ',');
            var csvReaderOptions = new CsvReaderOptions(new[] { Environment.NewLine });
            var csvMapper = new T();
            var csvParser = new CsvParser<W>(csvParserOptions, csvMapper);

           /* await Task.Run(() =>
            {
                var result = csvParser
                   .ReadFromString(csvReaderOptions, fileContent).ToList();
            });

        }*/
    }
}