using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class FacebookNotifierDecorator : NotifierDecorator
    {
        public FacebookNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending Facebook message: {message}");
        }
    }
}
