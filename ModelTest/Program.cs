using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksLibrary;

namespace ModelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AWLTEntities awlt = new AWLTEntities();
            var products = awlt.Products
                .Where(p => p.Name.StartsWith("F"))
                .OrderBy(s => s.Name);

            Console.WriteLine("Selected Products:");
            Console.WriteLine("==================");

            foreach (Product product in products)
            {
                Console.WriteLine("{0}, {1}", product.Name, product.ListPrice.ToString("#,##0.00"));
            }

            Console.Write("<Enter> para continuar...");
            Console.ReadLine();
        }
    }
}
