string products = "Sugar, Biscuits, Sugar, , Coffee ";

string[] entries = products.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

foreach (string entry in entries)
{
    Console.WriteLine(entry + "|");
}
