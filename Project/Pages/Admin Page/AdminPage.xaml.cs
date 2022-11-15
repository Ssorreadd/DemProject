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

namespace Project.Pages.Admin_Page
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AllUsersButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new AllUsersPage());

        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.GoBack();
        }
    }
}
