using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
    
namespace Restaurant.Utility
{
    public static class Helpers
    {       
        public static bool WebFileExists(string url, bool isTls12)
        {
            var result = false;
            if (isTls12)    
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }

            var request = WebRequest.Create(new Uri(url)) as HttpWebRequest;
            request.Method = "HEAD";
            using (var response = request.GetResponse())
            {
                result = true;
            }
            return result;
        }
            
        public static int IsInteger(string val)
        {
            int number;
            int.TryParse(val, out number);      
            return number;
        }       
            
        public static float IsFloat(string val)
        {
            float number;
            float.TryParse(val, out number);
            return number;
        }

        public static double IsDouble(string val)
        {
            double number;
            double.TryParse(val, out number);
            return number;
        }

        public static decimal IsDecimal(string val)
        {
            decimal number;
            decimal.TryParse(val, out number);
            return number;
        }

        public static bool IsBool(string val)
        {
            bool flag;
            bool.TryParse(val, out flag);
            return flag;
        }

        public static DateTime ValidateStringDateWithTypeData(string val)
        {
            DateTime date;
            DateTime.TryParse(val, out date);
            return date;
        }

        public static bool ValidateEmail(string email, string Optionalregex = "")
        {
            var patter = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!string.IsNullOrEmpty(Optionalregex))
                patter = new Regex(Optionalregex);

            return patter.IsMatch(email);
        }

        public static bool ValidateNameUser(string name)
        {
            var patter = new Regex(@"^([A-Za-z ÑÁÉÍÓÚñáéíóú]{2,200})$", RegexOptions.IgnoreCase);
            return patter.IsMatch(name);
        }

        public static string GetSiteCountryCode(string domain)
        {
            domain = domain.ToUpper();
            string countryCode = "MX";
            try
            {
                var code = domain.Substring(domain.Length - 2);
                CountryCodes countryCodeType = (CountryCodes)Enum.Parse(typeof(CountryCodes), code);
                if (Enum.IsDefined(typeof(CountryCodes), countryCodeType))
                    countryCode = countryCodeType.ToString();
            }
            catch (Exception)   
            {
                return countryCode;
            }

            return countryCode;
        }

        private enum CountryCodes
        {
            MX,
            CO, PE, PA,
            CR, GT, HN, SV,
            EU, IN, ET, ES, BR
        }

        public static bool IsValidExtension(string extension, List<string> listValidExtension)
        {
            return listValidExtension.Contains(extension);
        }

        public static bool IsValidUrl(string url, string optionalRegex = "")
        {
            return Regex.IsMatch(url, string.IsNullOrEmpty(optionalRegex) ? @"((http|https)(:\/\/))?([a-zA-Z0-9]+[.]{1}){2}[a-zA-z0-9]+(\/{1}[a-zA-Z0-9]+)*\/?" : optionalRegex);
        }

        public static bool ValidateStringDate(string date, string optionalRegex = "")
        {
            Regex re = new Regex(string.IsNullOrEmpty(optionalRegex) ? "^(0?[1-9]|1[0-9]|2|2[0-9]|3[0-1])/(0?[1-9]|1[0-2])/(d{2}|d{4})$" : optionalRegex);
            return re.IsMatch(date);
        }

        public static bool IsLetter(string text, string optionalRegex = "")
        {
            return Regex.IsMatch(text, string.IsNullOrEmpty(optionalRegex) ?
                @"^[a-zA-Z ÉÚÓéúóíÍÑñÜü]+$" : optionalRegex);
        }

        public static bool IsValidCredidCard(string text, string optionalRegex = "")
        {
            return Regex.IsMatch(text, string.IsNullOrEmpty(optionalRegex) ? @"^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$" : optionalRegex);
        }

        public static bool ValidateNumbers(string text, string optionalRegex = "")
        {
            return Regex.IsMatch(text, string.IsNullOrEmpty(optionalRegex) ? @"[0-9]{1,9}(\.[0-9]{0,2})?$" : optionalRegex);
        }

        public static bool ValidateExistFile(string pathFile)
        {
            return File.Exists(pathFile);
        }

        public static bool ValidateExistDirectory(string path)
        {
            return Directory.Exists(path);
        }
    }
}
