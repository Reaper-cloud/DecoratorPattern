using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class EmailNotifier : INotifier
    {
        private readonly List<string> _admins;

        public EmailNotifier(List<string> admins)
        {
            _admins = admins;
        }

        public void Send(string message)
        {
            foreach (var admin in _admins)
            {
                Console.WriteLine($"Sending email to {admin}: {message}");
            }
        }
    }
}
