using CSharpTipsAndTricks2.Logic;

List<string> products = SearchTitles("ea").ToList();

foreach (string product in products)
{
    Console.WriteLine(product);
}

IEnumerable<string> SearchTitles(string query)
{
    IEnumerable<string> search = from p in ProductList.Products
                                 let title = p.Title.ToLower()
                                 where title.Contains(query)
                                 select title;

    return search;
}