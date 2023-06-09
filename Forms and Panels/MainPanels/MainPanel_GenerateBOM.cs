using BoM_and_MCE_Generator_Reloaded.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded
{
    public partial class MainPanel_GenerateBOM : UserControl
    {
        Label width, height;
        UserControl userControl;


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LandingForm.landingForm.maskChange(new MainPanel_ViewBOM());
        }

        public MainPanel_GenerateBOM()
        {
            InitializeComponent();
            userControl = this;
            this.btnGenerate.Click += btnGenerate_Click;
        }

    }
}
