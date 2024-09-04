using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDIPImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer businessLayer = new BusinessLayer();

            var products = businessLayer.GetProducts();

            foreach (var item in products)
            {
                Console.WriteLine($"ID:{item.Id} Ad:{item.Name} Fiyat:{item.Price} Stok:{item.Stock}");
            }
            Console.ReadLine();
        }
    }
}
