using CSharpTipsAndTricks2.Logic;
using FluentValidation;

namespace CShartpTipsAndTricks2.FluentValidation;

public class ProductValidator: AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p).NotNull();
        RuleFor(p => p.Title).NotEmpty();
        RuleFor(p => p).Must(ValidStock).WithMessage("The stock and the availibility don't add up");
    }

    private bool ValidStock(Product product)
    {
        if (product.Available && product.Stock == 0)
            return false;

        return true;
    }
}
