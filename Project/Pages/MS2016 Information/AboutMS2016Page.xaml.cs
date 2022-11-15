using System.Windows;
using System.Windows.Controls;

namespace Project.Pages.MS2016_Information
{
    /// <summary>
    /// Логика взаимодействия для AboutMS2016Page.xaml
    /// </summary>
    public partial class AboutMS2016Page : Page
    {
        public AboutMS2016Page()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.GoBack();
        }

        private void Label_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("Картинок-то нам не дали", "Опаньки");
        }
    }
}
