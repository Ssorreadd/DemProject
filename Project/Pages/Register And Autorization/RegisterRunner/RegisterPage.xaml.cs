using Microsoft.Win32;
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


namespace Project.Register_And_Autorization.RegisterRunner
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
            
            CountryComboBox.Items.Add("Страна");

            CountryComboBox.SelectedIndex = 0;
            GenderComboBox.SelectedIndex = 0;
        }

        private void BrowseImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg)|*.jpg";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                ImageSource image = new BitmapImage(new Uri($"{fileDialog.FileName}", UriKind.Absolute));
                ImagePrev.Source = image;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string defaults = "email пароль имя фамилия дд/мм/гггг --выберите пол--";

                StringBuilder builder = new StringBuilder();

                if (string.IsNullOrWhiteSpace(EmailBox.Text) || defaults.Contains(EmailBox.Text.ToLower()))
                    builder.AppendLine("Введите: Email");
                if (string.IsNullOrWhiteSpace(PasswordBox.Password)) //!!!!!!!!
                    builder.AppendLine("Введите: Пароль");
                if (string.IsNullOrWhiteSpace(GenderComboBox.Text) || defaults.Contains(GenderComboBox.Text.ToLower()))
                    builder.AppendLine("Введите: Пол");

                if (builder.Length > 0)
                {
                    MessageBox.Show(builder.ToString());
                    return;
                }

                Base.runners.Add(new Runners()
                {
                    FirstName = FirstNameBox.Text,
                    SecondName = SecondNameBox.Text,
                    Birthday = BirthBox.Text,
                    Country = CountryComboBox.Text,
                    Email = EmailBox.Text,
                    Password = PasswordBox.Password,
                    Gender = GenderComboBox.Text,
                    Photo = ImagePrev.Source
                });

                MessageBox.Show("Добавлен");
                FrameManager.MainFrame.RemoveBackEntry();
                FrameManager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void CheckForDefaultBoxes(object sender)
        {
            //string boxesNames = "EmailBox PasswordBox FirstNameBox SecondNameBox";

            await Task.Run(() =>
            {
                Dispatcher.Invoke(() =>
                {
                    BoxesManager.CheckForDefaultBoxes(sender, RegisterRannerPageGrid, boxInfos);
                });
            });
        }
        private TextBoxInfo[] boxInfos = new TextBoxInfo[]
        {
            new TextBoxInfo("EmailBox", "email"),
            new TextBoxInfo("PasswordTextBox", "пароль"),
            new TextBoxInfo("FirstNameBox", "имя"),
            new TextBoxInfo("SecondNameBox", "фамилия"),
            new TextBoxInfo("BirthBox", "дд/мм/гггг")
        };

        private void Boxes_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string defaults = "email пароль имя фамилия дд/мм/гггг --выберите пол-- страна";

                CheckForDefaultBoxes(sender);

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

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.GoBack();
        }
    }
}
