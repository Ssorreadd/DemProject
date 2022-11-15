using System.Windows;
using System.Windows.Controls;

namespace Project.Register_And_Autorization.RegisterRunner
{
    /// <summary>
    /// Логика взаимодействия для AlreadyRunnerPage.xaml
    /// </summary>
    public partial class AlreadyRunnerPage : Page
    {
        public AlreadyRunnerPage()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.GoBack();
        }

        private void INewRunnerButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new RegisterPage());
        }

        private void IAlreadyRunnerButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new LoginPage.LoginPage());
        }
    }
}
