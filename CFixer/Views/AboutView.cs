using CrapFixer;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Views
{
    public partial class AboutView : UserControl

    {
        public AboutView()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Update version label
            this.lblVersionInfo.Text = $"v{Program.GetAppVersion()} ";

            // Populate amount choices
            comboBoxAmount.Items.AddRange(new object[] { "3.50", "5", "10",
                                                          "12", "15", "16",
                                                          "17", "18","20",
                                                          "25", "30", "35",
                                                          "40", "50", "60",
                                                          "70", "80", "100"});
            comboBoxAmount.SelectedIndex = 2;

            // Populate currency options
            comboBoxCurrency.Items.AddRange(new object[] { "EUR", "USD", "GBP", "CAD", "AUD", "CHF" });
            comboBoxCurrency.SelectedIndex = 0;
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/builtbybel/CrapFixer/releases");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            string amount = comboBoxAmount.SelectedItem?.ToString();
            string currency = comboBoxCurrency.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(currency))
            {
                MessageBox.Show(Properties.Resources.ResourceManager.GetString("AboutView.SelectAmountCurrency"));
                return;
            }

            string email = "belim@builtbybel.com";
            string purpose = Uri.EscapeDataString("Support Development of the CrapFixer app.");

            string returnUrl = Uri.EscapeDataString("https://github.com/Belim/support");
            string cancelUrl = Uri.EscapeDataString("https://github.com/builtbybel/CrapFixer");

            string url = $"https://www.paypal.com/cgi-bin/webscr?cmd=_donations" +
                         $"&business={Uri.EscapeDataString(email)}" +
                         $"&amount={amount}" +
                         $"&currency_code={currency}" +
                         $"&item_name={purpose}" +
                         $"&return={returnUrl}" +
                         $"&cancel_return={cancelUrl}";

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}