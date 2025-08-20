using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPExercises_Dependency.Exercise01;

namespace OOPExercises_Dependency.Exercise03
{
    internal class NotificationService : IEmailSender
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        public NotificationService(IEmailSender emailSender, ILogger logger)
        {
            _emailSender = emailSender;
            _logger = logger;
        }
        public void SendEmail(string to, string subject, string body)
        {
            _emailSender.SendEmail(to, subject, body);
            _logger.Log($"Email sent to: {to}, Subject: {subject}, Body: {body}");
        }

    }   
}
