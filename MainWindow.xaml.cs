using System;
using System.Collections.Generic;
using System.Windows;

namespace NotificationApp
{
    public partial class MainWindow : Window
    {
        private readonly INotifier _notifier;

        public MainWindow()
        {
            InitializeComponent();

            // Настройка списка администраторов
            var admins = new List<string> { "admin1@example.com", "admin2@example.com" };

            // Создание основного компонента
            _notifier = new EmailNotifier(admins);

            // Обертывание в SMS декоратор
            _notifier = new SMSNotifierDecorator(_notifier);

            // Обертывание в Facebook декоратор
            _notifier = new FacebookNotifierDecorator(_notifier);
        }

        private void SendNotification_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageTextBox.Text;
            _notifier.Send(message);
        }
    }
}