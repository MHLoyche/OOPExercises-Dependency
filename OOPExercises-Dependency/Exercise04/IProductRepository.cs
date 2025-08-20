using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise04
{
    internal interface IProductRepository
    {
        List<string> GetAllProducts();

        void AddProduct(string product);
    }
}
