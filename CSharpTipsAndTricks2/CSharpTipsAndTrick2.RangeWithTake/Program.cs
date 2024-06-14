using CSharpTipsAndTricks2.Logic;

List<Product> products = GetProducts(2).ToList();

IEnumerable<Product> GetProducts(int page)
{
    int productsPerPage = 4;

    List<Product> productsForPage = ProductList.Products
        .Take((page * productsPerPage)..((page * productsPerPage) + productsPerPage))
        .ToList();

    return productsForPage;
}