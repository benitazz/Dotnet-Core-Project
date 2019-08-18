using System.Text.RegularExpressions;

namespace MedicalEngineMicroService.Common.Extensions
{
    public static class StringExtension
    {
        public static string RemoveWhiteSpace(this string value)
        {
            return Regex.Replace(value, @"\s+", string.Empty);
        }

        public static string ToUpperCaseRemoveWhiteSpace(this string value)
        {
            var results = Regex.Replace(value, @"\s+", "");
            results = results.Trim();
            return results.ToUpper();
        }
    }
}