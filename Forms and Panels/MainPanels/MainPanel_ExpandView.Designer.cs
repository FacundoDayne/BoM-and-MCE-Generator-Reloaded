using System.Drawing;

namespace BoM_and_MCE_Generator_Reloaded.Forms_and_Panels.MainPanels
{
    partial class MainPanel_ExpandView
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCost = new Label();
            lblDate = new Label();
            lblID = new Label();
            lblName = new Label();
            dataSet = new DataGridView();
            colMaterialID = new DataGridViewTextBoxColumn();
            colMaterialName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPricePerUnit = new DataGridViewTextBoxColumn();
            colTotalPrice = new DataGridViewTextBoxColumn();
            btnDescription = new RoundButton();
            btnGenerate = new RoundButton();
            btnEditCell = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)dataSet).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 25);
            label3.TabIndex = 4;
            label3.Text = "View Bill of Material";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 18);
            label1.TabIndex = 5;
            label1.Text = "Project Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 6;
            label2.Text = "Project ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(329, 77);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 7;
            label4.Text = "Date Submitted";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(329, 130);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 18);
            label5.TabIndex = 8;
            label5.Text = "Project Cost";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCost.Location = new Point(354, 154);
            lblCost.Margin = new Padding(4, 0, 4, 0);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(54, 18);
            lblCost.TabIndex = 12;
            lblCost.Text = "lblCost";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(354, 101);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(53, 18);
            lblDate.TabIndex = 11;
            lblDate.Text = "lblDate";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(46, 154);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(36, 18);
            lblID.TabIndex = 10;
            lblID.Text = "lblID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(46, 101);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 18);
            lblName.TabIndex = 9;
            lblName.Text = "lblName";
            // 
            // dataSet
            // 
            dataSet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSet.Columns.AddRange(new DataGridViewColumn[] { colMaterialID, colMaterialName, colQuantity, colPricePerUnit, colTotalPrice });
            dataSet.Location = new Point(12, 198);
            dataSet.Margin = new Padding(4, 3, 4, 3);
            dataSet.Name = "dataSet";
            dataSet.Size = new Size(673, 389);
            dataSet.TabIndex = 13;
            // 
            // colMaterialID
            // 
            colMaterialID.HeaderText = "Material ID";
            colMaterialID.Name = "colMaterialID";
            colMaterialID.ReadOnly = true;
            // 
            // colMaterialName
            // 
            colMaterialName.HeaderText = "Material Name";
            colMaterialName.Name = "colMaterialName";
            colMaterialName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colPricePerUnit
            // 
            colPricePerUnit.HeaderText = "Price Per Unit";
            colPricePerUnit.Name = "colPricePerUnit";
            colPricePerUnit.ReadOnly = true;
            // 
            // colTotalPrice
            // 
            colTotalPrice.HeaderText = "Total Price";
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.ReadOnly = true;
            // 
            // btnDescription
            // 
            btnDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDescription.BackColor = Color.FromArgb(112, 70, 97);
            btnDescription.FlatAppearance.BorderColor = Color.White;
            btnDescription.FlatAppearance.BorderSize = 3;
            btnDescription.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnDescription.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnDescription.FlatStyle = FlatStyle.Flat;
            btnDescription.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDescription.ForeColor = Color.White;
            btnDescription.Location = new Point(529, 12);
            btnDescription.Margin = new Padding(4, 3, 4, 3);
            btnDescription.Name = "btnDescription";
            btnDescription.Size = new Size(156, 54);
            btnDescription.TabIndex = 18;
            btnDescription.Text = "Inspect Cell";
            btnDescription.UseVisualStyleBackColor = false;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.BackColor = Color.FromArgb(112, 70, 97);
            btnGenerate.FlatAppearance.BorderColor = Color.White;
            btnGenerate.FlatAppearance.BorderSize = 3;
            btnGenerate.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnGenerate.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(529, 130);
            btnGenerate.Margin = new Padding(4, 3, 4, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(156, 54);
            btnGenerate.TabIndex = 17;
            btnGenerate.Text = "Generate MCE";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnEditCell
            // 
            btnEditCell.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditCell.BackColor = Color.FromArgb(112, 70, 97);
            btnEditCell.FlatAppearance.BorderColor = Color.White;
            btnEditCell.FlatAppearance.BorderSize = 3;
            btnEditCell.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnEditCell.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnEditCell.FlatStyle = FlatStyle.Flat;
            btnEditCell.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditCell.ForeColor = Color.White;
            btnEditCell.Location = new Point(529, 72);
            btnEditCell.Margin = new Padding(4, 3, 4, 3);
            btnEditCell.Name = "btnEditCell";
            btnEditCell.Size = new Size(156, 54);
            btnEditCell.TabIndex = 16;
            btnEditCell.Text = "Edit Cell";
            btnEditCell.UseVisualStyleBackColor = false;
            // 
            // MainPanel_ExpandView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDescription);
            Controls.Add(btnGenerate);
            Controls.Add(btnEditCell);
            Controls.Add(dataSet);
            Controls.Add(lblCost);
            Controls.Add(lblDate);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "MainPanel_ExpandView";
            Size = new Size(698, 603);
            ((System.ComponentModel.ISupportInitialize)dataSet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataSet;
        private RoundButton btnEditCell;
        private RoundButton btnGenerate;
        private RoundButton btnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
    }
}
