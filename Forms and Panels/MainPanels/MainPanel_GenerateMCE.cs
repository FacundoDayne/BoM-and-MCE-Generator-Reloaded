﻿
using BoM_and_MCE_Generator_Reloaded.Forms_and_Panels.MainPanels;
using BoM_and_MCE_Generator_Reloaded.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BoM_and_MCE_Generator_Reloaded
{
    public partial class MainPanel_GenerateMCE : UserControl
    {
        PreviousBOM slotted;
        public BillOfMaterials billOfMaterials;
        public static MainPanel_GenerateMCE generateMCEInstance;
        public event EventHandler applyChangesClicked;
        public event EventHandler getTotal;
        public int markUp = 0;
        public int index = 0;

        public MainPanel_GenerateMCE()
        {
            InitializeComponent();
            generateMCEInstance = this;
        }
        public MainPanel_GenerateMCE(PreviousBOM slotted)
        {
            generateMCEInstance = this;
            InitializeComponent();
            this.slotted = slotted;
            lblCost.Text = "Php " + slotted.getTotal().ToString("F2");
            lblDate.Text = slotted.getDate().ToString();
            lblID.Text = slotted.getID().ToString();
            lblName.Text = slotted.getProject().ToString();
            this.billOfMaterials = slotted.getBillOfMaterials();
            populateDataSet();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
            btnApply.Click += (sender, e) => applyChanges();
        }
        private void applyChanges()
        {
            index = 0;
            try
            {
                markUp = int.Parse(txtMarkUp.Text);
                applyChangesClicked?.Invoke(this, EventArgs.Empty);
                for(; index < slotted.getBillOfMaterials().getName().Count; index++)
                {
                    getTotal.Invoke(this, EventArgs.Empty);
                }
            }
            catch (FormatException v)
            {
                MessageBox.Show("Please input the correct information");
            }            
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        private void populateDataSet()
        {
            tableLayoutPanel1.SuspendLayout();
            for (int i = 0; i < slotted.getBillOfMaterials().getName().Count; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getName()[i].ToString()));
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getQuantity()[i].ToString()));
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getPrice()[i].ToString()));
                tableLayoutPanel1.Controls.Add(new generateTextBox("txtMarkup" + i));
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getQuantity()[i] * billOfMaterials.getPrice()[i], i));
            }
            tableLayoutPanel1.ResumeLayout();
        }

    }
}
