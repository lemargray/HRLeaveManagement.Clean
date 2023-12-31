﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            foreach (var error in validationResult.Errors)
            {
                ValidationErrors.Add(error.ErrorMessage);

            }
        }

        public List<string> ValidationErrors { get; set; } = new();
    }
}
