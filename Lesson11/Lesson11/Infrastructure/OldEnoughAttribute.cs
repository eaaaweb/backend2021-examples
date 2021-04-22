using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace lesson11.Infrastructure
{
    namespace ModelValidation.Infrastructure
    {
        public class OldEnoughAttribute : Attribute, IModelValidator
        {
            public bool IsRequired => true;
            public string ErrorMessage { get; set; } = "Please enter a vaid date";

            public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
            {
                DateTime? value = context.Model as DateTime?;

                if (value != null && (DateTime)value < DateTime.Now
                    && ((DateTime)value).AddYears(120) > DateTime.Now)
                {
                    return new List<ModelValidationResult> {
                        new ModelValidationResult("", ErrorMessage)
                    };
                }
                else
                {
                    return Enumerable.Empty<ModelValidationResult>();
                }
            }
        }
    }
}