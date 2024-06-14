using CSharpTipsAndTricks2.Logic;
using CShartpTipsAndTricks2.FluentValidation;
using FluentValidation.Results;


Create(new()
{
    Available = true
});


void Create(Product product)
{
    ProductValidator validator = new();
    ValidationResult result = validator.Validate(product);

    if (result.IsValid)
    {
        // Save it to the data source
    }
    else
    {
        foreach (var error in result.Errors)
        {
            Console.WriteLine($"Error on the property {error.PropertyName}: {error.ErrorMessage}");
        }
    }
}