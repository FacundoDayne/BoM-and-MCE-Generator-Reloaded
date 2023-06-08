namespace BoM_and_MCE_Generator_Reloaded.Forms_and_Panels.MainPanels
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new RoundButton();
            btnDiscard = new RoundButton();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(112, 70, 97);
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(559, 97);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 65);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDiscard
            // 
            btnDiscard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDiscard.BackColor = Color.FromArgb(112, 70, 97);
            btnDiscard.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnDiscard.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnDiscard.FlatStyle = FlatStyle.Flat;
            btnDiscard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscard.ForeColor = Color.White;
            btnDiscard.Location = new Point(559, 189);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(119, 65);
            btnDiscard.TabIndex = 1;
            btnDiscard.Text = "Discard Changes";
            btnDiscard.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 25);
            label3.TabIndex = 5;
            label3.Text = "View Bill of Material";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.670433F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.32957F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(22, 97);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(531, 79);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(22, 4);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(29, 44);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left;
            txtUsername.Location = new Point(134, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 35);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            txtPassword.Location = new Point(134, 42);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 35);
            txtPassword.TabIndex = 5;
            // 
            // MainPanel_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(btnDiscard);
            Controls.Add(btnSave);
            Name = "MainPanel_Account";
            Size = new Size(698, 603);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundButton btnSave;
        private RoundButton btnDiscard;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}
