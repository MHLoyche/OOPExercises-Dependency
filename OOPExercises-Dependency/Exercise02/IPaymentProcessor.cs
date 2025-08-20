using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise02
{
    internal interface IPaymentProcessor
    {
        void Process(decimal amount);
    }
}
