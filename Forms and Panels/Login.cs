﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded
{
    public partial class Login : UserControl
    {
        Login login;
        public Login()
        {
            InitializeComponent();
            this.SizeChanged += AccomodateSizeChange;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            login = this;
            this.SetStyle(
            System.Windows.Forms.ControlStyles.UserPaint |
            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
            this.txtUsername.KeyPress += keyPress;
            this.txtPassword.KeyPress += keyPress;
            this.VisibleChanged += Login_Load;
            this.btnForget.Click += forgetPassword;
            this.btnSignUp.Click += BtnSignUp_Click;
        }

        private void BtnSignUp_Click(object? sender, EventArgs e)
        {
            LandingForm.landingForm.maskChange(new MainPanel_Account());
            this.Hide();
        }

        private void forgetPassword(object sender, EventArgs e)
        {
            Debug.WriteLine("Forgot Password");
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            using (SolidBrush brush1 = new SolidBrush(Color.FromArgb(152, 136, 146)))
            using (SolidBrush brush2 = new SolidBrush(Color.FromArgb(134, 106, 124)))
            {
                Rectangle rect1 = new Rectangle(control.ClientRectangle.X, control.ClientRectangle.Y,
                                                control.ClientRectangle.Width / 2, control.ClientRectangle.Height);
                Rectangle rect2 = new Rectangle(control.ClientRectangle.Width / 2, control.ClientRectangle.Y,
                                                control.ClientRectangle.Width / 2, control.ClientRectangle.Height);

                e.Graphics.FillRectangle(brush1, rect1);
                e.Graphics.FillRectangle(brush2, rect2);
            }
        }
        private void CenterPanel()
        {
            pnlLogin.Size = new Size(this.Width / 3, this.Height / 2);
            pnlLogin.Location = new Point((this.Width - pnlLogin.Width) / 2, (this.Height - pnlLogin.Height) / 2);
        }

        private void RaisePaintEvent(Control control)
        {
            control.Invalidate();
        }

        private void AccomodateSizeChange(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            RaisePaintEvent(control);
            CenterPanel();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterPanel();
            txtUsername.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LandingForm.landingForm.username = txtUsername.Text.ToString();
            LandingForm.landingForm.userData.Username = txtUsername.Text;
            LandingForm.landingForm.changeText();
            LandingForm.landingForm.maskChange(new MainPanel_LandingPanel());
            this.Hide();
        }

    }
}
