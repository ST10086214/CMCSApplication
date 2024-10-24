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

using System.Windows;

namespace CMCSApplication
{
    public partial class StaffPage : UserControl
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void AddStaff_Click(object sender, RoutedEventArgs e)
        {
            string staffName = txtStaffName.Text;
            string staffPosition = txtStaffPosition.Text;

            MessageBox.Show($"Staff Added: {staffName}, Position: {staffPosition}", "Success");
        }
    }
}
