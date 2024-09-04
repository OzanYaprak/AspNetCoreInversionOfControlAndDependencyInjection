using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer businessLayer = new BusinessLayer(new DataAccessLayer());

            var products = businessLayer.GetProducts();

            foreach (var item in products)
            {
                Console.WriteLine($"ID:{item.Id} Ad:{item.Name} Fiyat:{item.Price} Stok:{item.Stock}");
            }
            Console.ReadLine();
        }
    }
}
