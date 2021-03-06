﻿using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class RentalValidator :AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.RentDate).Must(RentalDateCannotBeLessThanTodayDate).WithMessage("Verilen tarih bugünün tarihinden küçük olmalıdır!");
            
        }
        private bool RentalDateCannotBeLessThanTodayDate(DateTime arg)
        {
            return arg.Date < DateTime.Today;
        }

    }
}
