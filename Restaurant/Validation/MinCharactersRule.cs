using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Restaurant.Validation
{
    public class MinCharactersRule : ValidationRule
    {
        public int MinimumCharacters { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (charString.Length < MinimumCharacters)
                return new ValidationResult(false, $"Tiene que ser mayor que {MinimumCharacters} caracteres.");

            return new ValidationResult(true, null);
        }   
    }
}
