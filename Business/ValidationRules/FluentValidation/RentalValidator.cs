﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            //RuleFor(p => p.CarId).GreaterThan(0);
            //RuleFor(p => p.CarId).NotEmpty();
            //RuleFor(p => p.CustomerId).GreaterThan(0);
            //RuleFor(p => p.CustomerId).NotEmpty();
            //RuleFor(p => p.RentDate).Equals(DateTime.Now);
            //RuleFor(p => p.RentDate).NotEmpty();

            RuleFor(r => r.RentDate).NotNull();
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate);

           // RuleFor(p => p.ReturnDate).GreaterThan(DateTime.Now);
          //  RuleFor(r => r.ReturnDate).Must(CheckReturnDate).WithMessage("Araba Şuan Başkası Tarafından Kiralanmış!");
        }

        //private bool CheckReturnDate(DateTime arg)
        //{
        //    return arg.GetValueOrDefault() != null;
        //}
    }
}
