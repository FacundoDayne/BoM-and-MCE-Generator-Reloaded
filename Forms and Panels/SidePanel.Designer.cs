using System;
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded
{
    partial class SidePanel
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
            btnGenerateBOM = new Button();
            btnGenerateMCE = new Button();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            btnDropdown = new Button();
            DropDownMenuPanel = new TableLayoutPanel();
            btnLogout = new Button();
            btnAccount = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnViewBOM = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DropDownMenuPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerateBOM
            // 
            btnGenerateBOM.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerateBOM.BackColor = Color.FromArgb(112, 70, 97);
            btnGenerateBOM.FlatAppearance.BorderSize = 3;
            btnGenerateBOM.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnGenerateBOM.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnGenerateBOM.FlatStyle = FlatStyle.Flat;
            btnGenerateBOM.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateBOM.ForeColor = Color.White;
            btnGenerateBOM.Location = new Point(3, 148);
            btnGenerateBOM.Margin = new Padding(0);
            btnGenerateBOM.Name = "btnGenerateBOM";
            btnGenerateBOM.Size = new Size(288, 48);
            btnGenerateBOM.TabIndex = 2;
            btnGenerateBOM.Text = "Generate BOM";
            btnGenerateBOM.UseVisualStyleBackColor = false;
            // 
            // btnGenerateMCE
            // 
            btnGenerateMCE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerateMCE.BackColor = Color.FromArgb(112, 70, 97);
            btnGenerateMCE.FlatAppearance.BorderSize = 3;
            btnGenerateMCE.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnGenerateMCE.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnGenerateMCE.FlatStyle = FlatStyle.Flat;
            btnGenerateMCE.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateMCE.ForeColor = Color.White;
            btnGenerateMCE.Location = new Point(3, 286);
            btnGenerateMCE.Margin = new Padding(0);
            btnGenerateMCE.Name = "btnGenerateMCE";
            btnGenerateMCE.Size = new Size(288, 48);
            btnGenerateMCE.TabIndex = 3;
            btnGenerateMCE.Text = "Generate MCE";
            btnGenerateMCE.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ImageAlign = ContentAlignment.MiddleLeft;
            lblUsername.Location = new Point(92, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(93, 37);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "USERNAME";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.PersonIcon;
            pictureBox1.Location = new Point(70, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnDropdown
            // 
            btnDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDropdown.FlatAppearance.BorderSize = 0;
            btnDropdown.FlatStyle = FlatStyle.Flat;
            btnDropdown.Image = Properties.Resources.DropDownIcon;
            btnDropdown.Location = new Point(192, 3);
            btnDropdown.Margin = new Padding(4, 3, 4, 3);
            btnDropdown.Name = "btnDropdown";
            btnDropdown.Size = new Size(15, 31);
            btnDropdown.TabIndex = 6;
            btnDropdown.Text = "\r\n";
            btnDropdown.UseVisualStyleBackColor = true;
            btnDropdown.Click += btnDropdown_Click;
            // 
            // DropDownMenuPanel
            // 
            DropDownMenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DropDownMenuPanel.AutoSize = true;
            DropDownMenuPanel.BackColor = Color.FromArgb(134, 106, 124);
            DropDownMenuPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            DropDownMenuPanel.ColumnCount = 1;
            DropDownMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DropDownMenuPanel.Controls.Add(btnLogout, 0, 1);
            DropDownMenuPanel.Controls.Add(btnAccount, 0, 0);
            DropDownMenuPanel.Location = new Point(187, 35);
            DropDownMenuPanel.Name = "DropDownMenuPanel";
            DropDownMenuPanel.RowCount = 2;
            DropDownMenuPanel.RowStyles.Add(new RowStyle());
            DropDownMenuPanel.RowStyles.Add(new RowStyle());
            DropDownMenuPanel.Size = new Size(103, 75);
            DropDownMenuPanel.TabIndex = 7;
            DropDownMenuPanel.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightGray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(5, 41);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(93, 30);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.LightGray;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnAccount.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.Location = new Point(5, 4);
            btnAccount.Margin = new Padding(4, 3, 4, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(93, 30);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.Controls.Add(btnDropdown, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(lblUsername, 1, 0);
            tableLayoutPanel1.Location = new Point(81, 3);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(211, 37);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnViewBOM
            // 
            btnViewBOM.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnViewBOM.BackColor = Color.FromArgb(112, 70, 97);
            btnViewBOM.FlatAppearance.BorderSize = 3;
            btnViewBOM.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnViewBOM.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnViewBOM.FlatStyle = FlatStyle.Flat;
            btnViewBOM.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewBOM.ForeColor = Color.White;
            btnViewBOM.Location = new Point(3, 217);
            btnViewBOM.Margin = new Padding(4, 3, 4, 3);
            btnViewBOM.Name = "btnViewBOM";
            btnViewBOM.Size = new Size(288, 48);
            btnViewBOM.TabIndex = 10;
            btnViewBOM.Text = "View BOMS";
            btnViewBOM.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnHome.BackColor = Color.FromArgb(112, 70, 97);
            btnHome.FlatAppearance.BorderSize = 3;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(3, 79);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(288, 48);
            btnHome.TabIndex = 11;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // SidePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(152, 136, 146);
            Controls.Add(btnViewBOM);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(DropDownMenuPanel);
            Controls.Add(btnGenerateMCE);
            Controls.Add(btnGenerateBOM);
            Controls.Add(btnHome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SidePanel";
            Size = new Size(294, 592);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DropDownMenuPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion
        private System.Windows.Forms.Button btnGenerateBOM;
        private System.Windows.Forms.Button btnGenerateMCE;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDropdown;
        private System.Windows.Forms.TableLayoutPanel DropDownMenuPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SidePanel sidePanel;
        private Button btnViewBOM;
        private Button btnHome;
    }
}
