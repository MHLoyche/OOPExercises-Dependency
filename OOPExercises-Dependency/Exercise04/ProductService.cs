using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise04
{
    internal class ProductService : IProductRepository
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(string product)
        {
            _productRepository.AddProduct(product);
        }

        public List<string> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
