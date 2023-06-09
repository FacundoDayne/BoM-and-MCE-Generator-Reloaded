using System;
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
    public partial class generateTextBox : TextBox
    {
        public generateTextBox(string name)
        {
            InitializeComponent();
            this.Name = name;
            MainPanel_GenerateMCE.generateMCEInstance.applyChangesClicked += applyChangesClicked;
            this.ForeColor = Color.Black;
        }
        public generateTextBox()
        {
            InitializeComponent();
            this.ForeColor = Color.Black;
            MainPanel_GenerateMCE.generateMCEInstance.applyChangesClicked += applyChangesClicked;
        }
        
        
        private void applyChangesClicked(object sender, EventArgs e)
        {
            this.Text = MainPanel_GenerateMCE.generateMCEInstance.markUp.ToString();
        }
    }
}
