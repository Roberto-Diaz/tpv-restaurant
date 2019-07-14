﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Restaurant.Validation
{
    public class ValueIsNotNull : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;

            if (!string.IsNullOrEmpty(str))
            {   
                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, $"El campo es obligatorio");
            }
        }
    }
}
