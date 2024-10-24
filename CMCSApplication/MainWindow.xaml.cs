using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMCSApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContentFrame.Navigate(new HomePage());
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new HomePage());
        }

        private void ClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new ClaimsPage());
        }

        private void LecturersButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new LecturersPage());
        }

        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new StaffPage());
        }
    }
}