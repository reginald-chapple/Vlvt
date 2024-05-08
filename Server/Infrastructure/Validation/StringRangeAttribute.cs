﻿using System.ComponentModel.DataAnnotations;

namespace Server.Infrastructure.Validation
{
    public class StringRangeAttribute : ValidationAttribute
    {
        public string[]? AllowedValues { get; set; }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (AllowedValues?.Contains(value?.ToString()) == true)
            {
                return ValidationResult.Success;
            }
            var msg = $"Please enter one of the allowable values: {string.Join(", ", (AllowedValues ?? new string[] { "No allowable values found" }))}.";
            return new ValidationResult(msg);
        }
    }
}
