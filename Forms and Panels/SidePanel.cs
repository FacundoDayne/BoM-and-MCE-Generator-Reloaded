﻿
using BoM_and_MCE_Generator_Reloaded.Forms_and_Panels.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded
{
    public partial class SidePanel : UserControl
    {

        public SidePanel()
        {
            InitializeComponent(); sidePanel = this;
            btnGenerateBOM.Click += hideDropDown;
            btnGenerateMCE.Click += hideDropDown;
            btnAccount.Click += hideDropDown;
            sidePanel.Click += hideDropDown;
            btnLogout.Click += logOut;
            btnLogout.Click += hideDropDown;
            btnGenerateBOM.Click += requestChange;
            btnGenerateMCE.Click += requestChange;
            btnViewBOM.Click += requestChange;
            btnHome.Click += requestChange;
            btnAccount.Click += requestChange;
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
                case "btnAccount":
                    LandingForm.landingForm.maskChange(new MainPanel_Account(LandingForm.landingForm.userData.Username));
                    break;
            }
        }
    }
}
