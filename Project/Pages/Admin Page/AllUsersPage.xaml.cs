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
    /// Логика взаимодействия для AllUsersPage.xaml
    /// </summary>
    public partial class AllUsersPage : Page
    {
        public AllUsersPage()
        {
            InitializeComponent();

            DGridUsers.ItemsSource = Base.runners;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.GoBack();
        }
    }
}
