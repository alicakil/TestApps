using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class MyCollectionMethods
    {
        public IList<int> FindDublicatesInList(IList<int> list)
        {
            Console.WriteLine("Dublicated Items are");
            var dublicates = list.GroupBy(x => x).SelectMany(grp=>grp.Skip(1)).Distinct();
            foreach (var i in dublicates) Console.WriteLine(i);
            return dublicates.ToList();

            // or:
            //return list.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
        }
    }


    public class Products
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; } = "";
        public string Category { get; set; }
        public int UnitPrice { get; set; }
    }


    public class Category
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; } = "";
    }
}
