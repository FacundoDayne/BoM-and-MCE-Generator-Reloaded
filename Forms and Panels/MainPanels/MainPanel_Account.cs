using BoM_and_MCE_Generator_Reloaded.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded
{
    public partial class MainPanel_Account : UserControl
    {
        //For new users
        public MainPanel_Account()
        {
            InitializeComponent();
            tableLayoutPanel2.Controls.Add(dtpBirthDate, 1, 1);
            tableLayoutPanel2.Controls.Add(txtName, 1, 0);
            label2.Text = "Enter User Credentials";
            txtUsername.ReadOnly = false;
            lblCurrentPassword.Text = "Password";
            tableLayoutPanel1.Controls.Add(lblConfirmPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(txtConfirmPassword, 1, 2);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(472, 135);
            lblBoMs.Text = "0";
            btnDiscard.Text = "Return to Login";
            btnSave.Text = "Sign up";
            btnSave.Click += signUp;
            btnDiscard.Click += returnToLogin;
            lblTitle.Text = "Sign up";
        }

        private void returnToLogin(object? sender, EventArgs e)
        {
            LandingForm.landingForm.showLogin();
        }

        private void signUp(object? sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                LandingForm.landingForm.userData.Username = txtUsername.Text;
                LandingForm.landingForm.userData.Password = txtConfirmPassword.Text;
                LandingForm.landingForm.userData.Birthdate = dtpBirthDate.Value;
                LandingForm.landingForm.userData.Access = lblAccess.Text;
                LandingForm.landingForm.userData.BoMs = 0;
                MessageBox.Show("Sign up Successful!");
                LandingForm.landingForm.showLogin();
            }
            else
            {
                MessageBox.Show("Passwords do not match");
                txtPassword.Select();
            }
            
        }

        //For existing users
        public MainPanel_Account(string Username)
        {
            InitializeComponent();
            txtUsername.Text = Username;
            tableLayoutPanel2.Controls.Add(lblBirthdate, 1, 1);
            tableLayoutPanel2.Controls.Add(lblName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtNewPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(lblNewPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(lblConfirmPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(txtConfirmPassword, 1, 3);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(472, 135); 
            btnSave.Click += save;
            btnDiscard.Click += returnToMain;
        }

        private void returnToMain(object? sender, EventArgs e)
        {
            LandingForm.landingForm.maskChange(new MainPanel_LandingPanel());
        }

        private void save(object? sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                LandingForm.landingForm.userData.Password = txtConfirmPassword.Text;
            }
        }
    }
}
