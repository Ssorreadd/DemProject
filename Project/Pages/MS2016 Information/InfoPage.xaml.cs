using System.Windows;
using System.Windows.Controls;

namespace Project.Pages.MS2016_Information
{
    /// <summary>
    /// Логика взаимодействия для InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void ToMS2016PageButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new AboutMS2016Page());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.GoBack();
        }
    }
}
