using BoM_and_MCE_Generator_Reloaded.Forms_and_Panels.MainPanels;
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
    public partial class generateLabel : Label
    {
        int index = 0;
        public generateLabel(float text, int index)
        {
            this.index = index;
            InitializeComponent();
            this.Text = text.ToString();
            MainPanel_GenerateMCE.generateMCEInstance.getTotal += getTotal;
        }
        private void getTotal(object sender, EventArgs e)
        {
            if (MainPanel_GenerateMCE.generateMCEInstance.index == index)
            {                
                int quantity = MainPanel_GenerateMCE.generateMCEInstance.billOfMaterials.getQuantity()[index];
                float price = MainPanel_GenerateMCE.generateMCEInstance.billOfMaterials.getPrice()[index];
                float total = quantity * price;
                float markedUp = total * MainPanel_GenerateMCE.generateMCEInstance.markUp;
                float trueValue = (markedUp / 100F) + markedUp;
                this.Text = trueValue.ToString("F2");                
                Debug.WriteLine(trueValue);
            }
        }
        public generateLabel(string text)
        {
            InitializeComponent();
            this.Text = text;
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }

        public generateLabel(float text)
        {
            InitializeComponent();
            this.Text = text.ToString();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }

        public generateLabel(int text)
        {
            InitializeComponent();
            this.Text = text.ToString();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }
        public generateLabel(double text)
        {
            InitializeComponent();
            this.Text = text.ToString();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }
    }
}
