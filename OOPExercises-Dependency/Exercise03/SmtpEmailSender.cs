using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise03
{
    internal class SmtpEmailSender : IEmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email via SMTP to: {to}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
        }
    }
}
