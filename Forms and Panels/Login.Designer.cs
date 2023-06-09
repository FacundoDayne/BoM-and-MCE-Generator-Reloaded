using BoM_and_MCE_Generator_Reloaded;

namespace BoM_and_MCE_Generator_Reloaded
{
    partial class Login
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogin = new Panel();
            btnForget = new LinkLabel();
            btnSignUp = new RoundButton();
            btnLogin = new RoundButton();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            label1 = new Label();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(btnForget);
            pnlLogin.Controls.Add(btnSignUp);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Location = new Point(288, 38);
            pnlLogin.Margin = new Padding(4, 3, 4, 3);
            pnlLogin.MinimumSize = new Size(400, 507);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(418, 546);
            pnlLogin.TabIndex = 2;
            // 
            // btnForget
            // 
            btnForget.Anchor = AnchorStyles.None;
            btnForget.AutoSize = true;
            btnForget.LinkColor = Color.Black;
            btnForget.Location = new Point(259, 287);
            btnForget.Margin = new Padding(4, 0, 4, 0);
            btnForget.Name = "btnForget";
            btnForget.Size = new Size(100, 15);
            btnForget.TabIndex = 7;
            btnForget.TabStop = true;
            btnForget.Text = "Forgot Password?";
            btnForget.Visible = false;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Bottom;
            btnSignUp.BackColor = Color.FromArgb(152, 136, 146);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.Location = new Point(57, 426);
            btnSignUp.Margin = new Padding(4, 3, 4, 3);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(304, 51);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.BackColor = Color.FromArgb(152, 136, 146);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(57, 358);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(304, 51);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(67, 226);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(284, 38);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top;
            txtUsername.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(67, 159);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 38);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(54, 205);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 18);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(54, 138);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(77, 18);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(159, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 27);
            label1.TabIndex = 0;
            label1.Text = "Account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            Controls.Add(pnlLogin);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Size = new Size(1010, 642);
            Load += Login_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private RoundButton btnLogin;
        private RoundButton btnSignUp;
        private System.Windows.Forms.LinkLabel btnForget;
    }
}
