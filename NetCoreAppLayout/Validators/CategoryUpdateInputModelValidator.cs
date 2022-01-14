using FluentValidation;
using NetCoreAppLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAppLayout.Validators
{
    public class CategoryUpdateInputModelValidator:AbstractValidator<CategoryUpdateInputModel>
    {
        public CategoryUpdateInputModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş geçilemez");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("En fazla 200 karakter uzunluğunda bir değer giriniz.");
        }
    }
}
