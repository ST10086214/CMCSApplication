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
using Microsoft.Win32;

namespace CMCSApplication
{
    public partial class LecturersPage : UserControl
    {
        public LecturersPage()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Perform calculations and submit the claim
            double hoursWorked = double.Parse(txtHoursWorked.Text);
            double hourlyRate = double.Parse(txtHourlyRate.Text);
            double totalAmount = hoursWorked * hourlyRate;

            MessageBox.Show($"Claim Submitted!\nTotal Amount: R{totalAmount}", "Success");
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            // Open file dialog to select document
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"Document Uploaded: {filePath}", "Upload Success");
            }
        }
    }
}

