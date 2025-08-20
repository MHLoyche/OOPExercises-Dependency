using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise02
{
    internal class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }
}
