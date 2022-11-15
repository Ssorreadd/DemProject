using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Threading;
using Project.Register_And_Autorization;
using Project.Register_And_Autorization.LoginPage;

namespace Project.MainPage
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DateController();
        }

        private int HoursToTheEndOfTheDay()
        {
            // получение значения, через сколько миллисекунд будет следующий день

            DateTime timeNow = DateTime.Now;
            return 86400000 - (timeNow.Millisecond + (timeNow.Second * 1000) + (timeNow.Minute * 60000) + (timeNow.Hour * 3600000));
        }

        private async void DateController()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Dispatcher.Invoke(() =>
                    {
                        TimeBlock.Text = DateTime.Now.ToString($"Москва, Россия\ndddd dd MMMM yyyy");
                    });

                    Thread.Sleep(HoursToTheEndOfTheDay());
                }
            });
        }

        private void RegisterRunnerButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Register_And_Autorization.RegisterRunner.AlreadyRunnerPage());
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new LoginPage());
        }

        private void EventInfoButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Pages.MS2016_Information.InfoPage());
        }
    }
}
