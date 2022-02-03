Console.WriteLine("This Ali ÇAKIL!\nSenior Software Engineer!");


// This app will have some test codes such as Collections.Generics.

List<string> list = new List<string>() { "ali", "veli", "deli" };

foreach (var s in list)
    Console.WriteLine(s);


list.Remove("veli");

Console.WriteLine("\n\nAfter Removal:");
foreach (var s in list)
    Console.WriteLine(s);
