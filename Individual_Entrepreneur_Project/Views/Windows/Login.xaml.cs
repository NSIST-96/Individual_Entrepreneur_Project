using Individual_Entrepreneur_Project.Views.Windows;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Individual_Entrepreneur_Project.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click (object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnGetRegistration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            Login login = this;
            
            registration.Show();
            registration.Focus();
            login.Close();
        }
    }
}
