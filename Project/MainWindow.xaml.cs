using System.Windows;

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Base.admins.Add(new Admin { Login = "admin1", Password = "1234" });

            FrameManager.MainFrame = MainWindowFrame;
            
            FrameManager.MainFrame.Navigate(new MainPage.MainPage());
        }
    }
}
