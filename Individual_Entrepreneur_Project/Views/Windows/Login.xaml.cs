using System.Windows;
using System.Windows.Input;

namespace Individual_Entrepreneur_Project.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
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
    }
}
