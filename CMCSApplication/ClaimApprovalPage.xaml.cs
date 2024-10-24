using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
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

namespace CMCSApplication
{
    /// <summary>
    /// Interaction logic for ClaimApprovalPage.xaml
    /// </summary>
    public partial class ClaimApprovalPage : Page
    {
        public ClaimApprovalPage()
        {
            InitializeComponent();
            LoadPendingClaims();
        }
        private List<Claim> pendingClaims = new List<Claim>
        {
            new Claim {LecturerName = "Micheal Wayne", HoursWorked = 10, HourlyRate = 200},
            new Claim {LecturerName = "Jane Smith", HoursWorked = 8, HourlyRate = 150 }
        };
        // Load claims into the ListView
        private void LoadPendingClaims()
        {
            PendingClaimsList.ItemsSource = pendingClaims;
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender; 
            Claim selectedClaim = (Claim)button.DataContext;
            selectedClaim.Status = "Approved";
            MessageBox.Show($"Claim by {selectedClaim.LecturerName} Approved!");
            PendingClaimsList.Items.Refresh();
            //update the claim status in data here
        }

        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Claim selectedClaim = (Claim)button.DataContext;
            selectedClaim.Status = "Rejected";
            MessageBox.Show($"Claim by {selectedClaim.LecturerName} Rejected.");
            PendingClaimsList.Items.Refresh();

        }
    }

    // Simple class to represent a claim
    public class Claim
    {
        public string LecturerName { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string Status { get; set; } = "Pending";


    }
}

