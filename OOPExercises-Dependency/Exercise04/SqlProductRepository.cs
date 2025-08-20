using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise04
{
    internal class SqlProductRepository : IProductRepository
    {
        List<string> _products = new List<string>();

        // This class simulates a SQL database repository for products, but instead I am just using a list.
        public void AddProduct(string product)
        {
            Console.WriteLine("Adding product to SQL database: " + product);
            _products.Add(product);
        }

        public List<string> GetAllProducts()
        {
            Console.WriteLine("Retrieving products from SQL database.");
            foreach (var product in _products)
            {
                Console.WriteLine("Item in SQL DB: " + product);
            }
            
            return _products;
        }
    }
}
