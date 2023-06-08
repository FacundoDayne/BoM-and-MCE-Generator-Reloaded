
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded
{
    partial class LandingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            _current = new MainPanel_LandingPanel();
            login1 = new Login();
            sidePanel1 = new SidePanel();
            SuspendLayout();
            // 
            // _current
            // 
            _current.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _current.BackColor = SystemColors.Control;
            _current.BackgroundImage = (Image)resources.GetObject("_current.BackgroundImage");
            _current.BackgroundImageLayout = ImageLayout.Stretch;
            _current.Location = new Point(-2, 0);
            _current.Margin = new Padding(0);
            _current.Name = "_current";
            _current.Size = new Size(819, 696);
            _current.TabIndex = 4;
            // 
            // login1
            // 
            login1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login1.AutoSize = true;
            login1.BackColor = Color.FromArgb(255, 192, 192);
            login1.Location = new Point(0, 0);
            login1.Margin = new Padding(5, 3, 5, 3);
            login1.Name = "login1";
            login1.Size = new Size(1332, 704);
            login1.TabIndex = 4;
            login1.Visible = false;
            // 
            // sidePanel1
            // 
            sidePanel1.BackColor = Color.FromArgb(152, 136, 146);
            sidePanel1.Dock = DockStyle.Right;
            sidePanel1.Location = new Point(817, 0);
            sidePanel1.Margin = new Padding(0);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new Size(343, 696);
            sidePanel1.TabIndex = 5;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1160, 696);
            Controls.Add(sidePanel1);
            Controls.Add(login1);
            Controls.Add(_current);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1176, 735);
            Name = "LandingForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Login login1;
        private SidePanel sidePanel1;
        private UserControl _current;
    }
}

