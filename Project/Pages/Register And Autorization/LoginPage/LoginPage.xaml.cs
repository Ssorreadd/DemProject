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

namespace Project.Register_And_Autorization.LoginPage
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e) => FrameManager.MainFrame.GoBack();

        private TextBoxInfo[] boxInfos = new TextBoxInfo[]
        {
            new TextBoxInfo("LoginBox", "email"),
            new TextBoxInfo("PasswordTextBox", "пароль")
        };

        private async void SetDefaultBoxes(object sender)
        {
            await Task.Run(() =>
            {
                Dispatcher.Invoke(() =>
                {
                    BoxesManager.CheckForDefaultBoxes(sender, LoginPageGrid, boxInfos);
                });
            });
        }
        private void Boxes_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string defaults = "email пароль";

                SetDefaultBoxes(sender);

                if (sender is TextBox && defaults.Contains(((TextBox)sender).Text.ToLower()))
                {
                    if (((TextBox)sender).Text.Equals("пароль"))
                    {
                        PasswordTextBox.Visibility = Visibility.Hidden;
                        PasswordBox.Focus();
                    }
                    else if (!(sender is PasswordBox) && string.IsNullOrWhiteSpace(this.PasswordBox.Password))
                    {
                        PasswordTextBox.Visibility = Visibility.Visible;
                    }

                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                }
            }
            catch (Exception)
            {
            }
        }

        private void ClearBoxes()
        {
            PasswordBox.Clear();
            LoginBox.Clear();

            Boxes_PreviewMouseLeftButtonDown(LoginBox, new MouseButtonEventArgs(Mouse.PrimaryDevice, 2, MouseButton.Left));
            LoginBox.Focus();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            bool userFind = false;

            foreach (var user in Base.admins)
            {
                if (user.Login.Equals(LoginBox.Text) && user.Password.Equals(PasswordBox.Password))
                {
                    userFind = true;
                    ClearBoxes();
                    FrameManager.MainFrame.Navigate(new Pages.Admin_Page.AdminPage());
                }
            }

            if (!userFind)
            {
                MessageBox.Show("Пользователь не найден");

                ClearBoxes();
            }
        }
    }
}
