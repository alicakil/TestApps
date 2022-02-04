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
        public List<int> FindDublicatesInList(List<int> list)
        {
            List<int> dublicates = list;//.GroupBy(x=>x.Key)
            //foreach (var i in dublicates) Console.WriteLine(i);
            return dublicates;
        }
    }


    public class Products
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; } = "";
        public int Category { get; set; }
        public int UnitPrice { get; set; }
    }


    public class Category
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; } = "";
    }
}
