using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise02
{
    internal class CheckoutService : IPaymentProcessor
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public CheckoutService(IPaymentProcessor paymentProcessor) 
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Process(decimal amount)
        {
            _paymentProcessor.Process(amount);
        }
    }
}
