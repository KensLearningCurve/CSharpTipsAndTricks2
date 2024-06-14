using CSharpTipsAndTricks2.Logic;

Create(null);

void Create(Product product)
{
    ArgumentNullException.ThrowIfNull(product, nameof(product));

    ProductList.Products.Add(product);
}