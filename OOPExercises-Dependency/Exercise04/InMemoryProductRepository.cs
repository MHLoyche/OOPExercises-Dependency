using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise04
{
    internal class InMemoryProductRepository : IProductRepository
    {
        List<string> _products = new List<string>();

        public void AddProduct(string product)
        {
            _products.Add(product);
        }

        public List<string> GetAllProducts()
        {
            Console.WriteLine("Retrieving products from in-memory repository.");
            foreach (var product in _products)
            {
                Console.WriteLine("Item in in-memory repo: " + product);
            }

            return _products;
        }
    }
}
