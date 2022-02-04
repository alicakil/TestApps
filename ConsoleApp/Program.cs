using ConsoleApp;

//Console.WriteLine("This Ali ÇAKIL!\nSenior Software Engineer!");
//MyCollectionMethods c = new MyCollectionMethods();
//List<int> list = new List<int>() { 1,2,2,3,4,5,5,5,6,7,8,6,9 };
//c.FindDublicatesInList(list);

List<Category> categories = new List<Category>();
categories.Add(new Category() { id=1, Name="Cars" });
categories.Add(new Category() { id =2, Name = "MotoBikes" });

List<Products> products = new List<Products>();
products.Add(new Products { id=1, Category=1, Name="Toyota", UnitPrice=60000});
products.Add(new Products { id=2, Category=1, Name="Wolswagen", UnitPrice=70000});
products.Add(new Products { id=3, Category=1, Name="Dacia", UnitPrice=20000});
products.Add(new Products { id=4, Category=1, Name="Renoult", UnitPrice=30000});
products.Add(new Products { id=5, Category=2, Name="Harley Davidson", UnitPrice=80000});
products.Add(new Products { id=6, Category=2 , Name="Suzuki", UnitPrice=50000});

var filtered = products.Where(x=>x.id>4 && x.UnitPrice > 10000).OrderByDescending(x=>x.Name);
Console.WriteLine("\n\n Where Clause Results: ");
foreach (var p in filtered) Console.WriteLine(p.Name + " " + p.UnitPrice);

Console.WriteLine("\n\n Linq query Results: ");
var filtered2 = from x in products where x.Name.Contains("yo") select x;
foreach (var p in filtered2) Console.WriteLine(p.Name + " " + p.UnitPrice);


var TotalPrice = products.Sum(x => x.UnitPrice);
Console.WriteLine("\nTotalPrice: " + TotalPrice);





Console.WriteLine("\n\n Distinct Results: ");
var filtered3 = products.Distinct();
foreach (var p in filtered3) Console.WriteLine(p.Name + " " + p.UnitPrice);






Console.ReadKey();