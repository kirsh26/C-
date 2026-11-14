Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Name: ");
string? customerName = Console.ReadLine();
Console.Write("City: ");
string? customerCity = Console.ReadLine();
Console.Write("Favourite language: ");
string? FavouriteLanguage = Console.ReadLine();

Console.Write("====================\n\tBUSINESS CARD\n====================");
Console.WriteLine("Name" + customerName);
Console.WriteLine("City" + customerCity);
Console.WriteLine("Favourite language" + "\"" + FavouriteLanguage + "\"");
Console.WriteLine("====================");

Console.WriteLine("Press any key...");
Console.ReadKey();


