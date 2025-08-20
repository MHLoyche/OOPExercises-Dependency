using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise03
{
    internal interface IEmailSender
    {
        void SendEmail(string to, string subject, string body);
    }
}
