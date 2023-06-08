using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded.Forms_and_Panels
{
    public partial class DescriptionForm : Form
    {
        public DescriptionForm(string name)
        {
            InitializeComponent();
            this.Text = name + " Description";
            this.btnReturn.Click += returns;
        }

        private void returns(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
