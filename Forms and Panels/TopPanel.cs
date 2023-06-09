﻿namespace BoM_and_MCE_Generator_Reloaded.Forms_and_Panels
{
    public partial class TopPanel : UserControl
    {
        public TopPanel()
        {
            InitializeComponent();
            btnGenerateBOM.Click += hideDropDown;
            btnGenerateMCE.Click += hideDropDown;
            btnAccount.Click += hideDropDown;
            this.Click += hideDropDown;
            btnLogout.Click += logOut;
            btnLogout.Click += hideDropDown;
            btnGenerateBOM.Click += requestChange;
            btnGenerateMCE.Click += requestChange;
            btnViewBOM.Click += requestChange;
            btnHome.Click += requestChange;
        }
        private void btnDropdown_Click(object sender, EventArgs e)
        {
            DropDownMenuPanel.Visible = !DropDownMenuPanel.Visible;
        }

        private void hideDropDown(object sender, EventArgs e)
        {
            DropDownMenuPanel.Hide();
        }

        private void logOut(object sender, EventArgs e)
        {
            LandingForm.landingForm.isLoggedIn = false;
            LandingForm.landingForm.showLogin();
        }

        private void requestChange(object sender, EventArgs e)
        {
            Button check = (Button)sender;
            switch (check.Name.ToString())
            {
                case "btnGenerateBOM":
                    LandingForm.landingForm.maskChange(new MainPanel_GenerateBOM());
                    break;
                case "btnGenerateMCE":
                    LandingForm.landingForm.maskChange(new MainPanel_GenerateMCE());
                    break;
                case "btnViewBOM":
                    LandingForm.landingForm.maskChange(new MainPanel_ViewBOM());
                    break;
                case "btnHome":
                    LandingForm.landingForm.maskChange(new MainPanel_LandingPanel());
                    break;
            }
        }
    }
}
