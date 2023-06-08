using System.Drawing;

namespace BoM_and_MCE_Generator_Reloaded
{
    partial class MainPanel_Account
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

        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            lblCurrentPassword = new Label();
            btnDiscard = new RoundButton();
            btnSave = new RoundButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblAccess = new Label();
            lblBoMs = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAccess = new TextBox();
            dtpBirthDate = new DateTimePicker();
            txtName = new TextBox();
            lblBirthdate = new Label();
            lblName = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 4;
            label3.Text = "Account";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.Anchor = AnchorStyles.Right;
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentPassword.Location = new Point(21, 92);
            lblCurrentPassword.Margin = new Padding(4, 0, 4, 0);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(128, 18);
            lblCurrentPassword.TabIndex = 9;
            lblCurrentPassword.Text = "Current Password";
            // 
            // btnDiscard
            // 
            btnDiscard.Anchor = AnchorStyles.None;
            btnDiscard.BackColor = Color.FromArgb(112, 70, 97);
            btnDiscard.FlatAppearance.BorderColor = Color.White;
            btnDiscard.FlatAppearance.BorderSize = 3;
            btnDiscard.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnDiscard.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnDiscard.FlatStyle = FlatStyle.Flat;
            btnDiscard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscard.ForeColor = Color.White;
            btnDiscard.Location = new Point(526, 521);
            btnDiscard.Margin = new Padding(4, 3, 4, 3);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(156, 54);
            btnDiscard.TabIndex = 17;
            btnDiscard.Text = "Discard Changes";
            btnDiscard.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(112, 70, 97);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(362, 519);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 54);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.6271172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.37288F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCurrentPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Location = new Point(23, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(472, 135);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left;
            txtUsername.Location = new Point(156, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(313, 23);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            txtPassword.Location = new Point(156, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(313, 23);
            txtPassword.TabIndex = 11;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Right;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPassword.Location = new Point(17, 95);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(132, 18);
            lblConfirmPassword.TabIndex = 15;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Left;
            txtConfirmPassword.Location = new Point(156, 97);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(313, 23);
            txtConfirmPassword.TabIndex = 14;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Left;
            txtNewPassword.Location = new Point(156, 97);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(313, 23);
            txtNewPassword.TabIndex = 13;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Anchor = AnchorStyles.Right;
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewPassword.Location = new Point(40, 95);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(109, 18);
            lblNewPassword.TabIndex = 12;
            lblNewPassword.Text = "New Password";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.26271F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73729F));
            tableLayoutPanel2.Controls.Add(lblAccess, 1, 2);
            tableLayoutPanel2.Controls.Add(lblBoMs, 1, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label8, 0, 3);
            tableLayoutPanel2.Location = new Point(23, 248);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(472, 151);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // lblAccess
            // 
            lblAccess.Anchor = AnchorStyles.Left;
            lblAccess.AutoSize = true;
            lblAccess.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccess.Location = new Point(160, 83);
            lblAccess.Margin = new Padding(4, 0, 4, 0);
            lblAccess.Name = "lblAccess";
            lblAccess.Size = new Size(74, 18);
            lblAccess.TabIndex = 24;
            lblAccess.Text = "Employee";
            // 
            // lblBoMs
            // 
            lblBoMs.Anchor = AnchorStyles.Left;
            lblBoMs.AutoSize = true;
            lblBoMs.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBoMs.Location = new Point(160, 122);
            lblBoMs.Margin = new Padding(4, 0, 4, 0);
            lblBoMs.Name = "lblBoMs";
            lblBoMs.Size = new Size(62, 18);
            lblBoMs.TabIndex = 25;
            lblBoMs.Text = "lblBoMs";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(79, 46);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 20;
            label6.Text = "Birth Date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(104, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 6;
            label5.Text = "Name";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(57, 83);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 18);
            label7.TabIndex = 21;
            label7.Text = "Access Level";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(31, 122);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 18);
            label8.TabIndex = 22;
            label8.Text = "BoMs Generated";
            // 
            // txtAccess
            // 
            txtAccess.Anchor = AnchorStyles.Left;
            txtAccess.Enabled = false;
            txtAccess.Location = new Point(159, 81);
            txtAccess.Name = "txtAccess";
            txtAccess.ReadOnly = true;
            txtAccess.Size = new Size(310, 23);
            txtAccess.TabIndex = 24;
            txtAccess.Text = "Employee";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.Left;
            dtpBirthDate.Location = new Point(159, 44);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.Location = new Point(159, 7);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 23);
            txtName.TabIndex = 22;
            // 
            // lblBirthdate
            // 
            lblBirthdate.Anchor = AnchorStyles.Left;
            lblBirthdate.AutoSize = true;
            lblBirthdate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthdate.Location = new Point(160, 46);
            lblBirthdate.Margin = new Padding(4, 0, 4, 0);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(80, 18);
            lblBirthdate.TabIndex = 23;
            lblBirthdate.Text = "lblBirthdate";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(160, 9);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 18);
            lblName.TabIndex = 20;
            lblName.Text = "lblName";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 18);
            label2.TabIndex = 12;
            label2.Text = "Change Account Credentials";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 204);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 19;
            label4.Text = "User Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 433);
            panel1.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.BackColor = Color.Black;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2F));
            tableLayoutPanel3.Controls.Add(panel1, 1, 1);
            tableLayoutPanel3.Location = new Point(76, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel3.Size = new Size(524, 443);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // MainPanel_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(btnDiscard);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Name = "MainPanel_Account";
            Size = new Size(696, 601);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentPassword;
        private RoundButton btnSave;
        private RoundButton btnDiscard;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label lblBoMs;
        private Label lblAccess;
        private Label lblBirthdate;
        private Label lblName;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblConfirmPassword;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtName;
        private TextBox txtAccess;
        private DateTimePicker dtpBirthDate;
    }
}
