namespace BoM_and_MCE_Generator_Reloaded.Forms_and_Panels
{
    partial class DescriptionForm
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
            picBrand = new PictureBox();
            label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblBrand = new Label();
            lblName = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblDimensions = new Label();
            labl5 = new Label();
            label4 = new Label();
            lblPrice = new Label();
            btnReturn = new RoundButton();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            rtxtDescription = new RichTextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picBrand).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // picBrand
            // 
            picBrand.Dock = DockStyle.Fill;
            picBrand.Image = Properties.Resources.sample_logo;
            picBrand.Location = new Point(6, 6);
            picBrand.Margin = new Padding(0);
            picBrand.Name = "picBrand";
            picBrand.Size = new Size(167, 142);
            picBrand.SizeMode = PictureBoxSizeMode.Zoom;
            picBrand.TabIndex = 1;
            picBrand.TabStop = false;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(4, 14);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(58, 21);
            label.TabIndex = 2;
            label.Text = "Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.63385F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.36615F));
            tableLayoutPanel1.Controls.Add(picBrand, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(6);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(618, 154);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblBrand, 0, 3);
            tableLayoutPanel2.Controls.Add(label, 0, 0);
            tableLayoutPanel2.Controls.Add(lblName, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(173, 6);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(439, 142);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrand.Location = new Point(4, 105);
            lblBrand.Margin = new Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(431, 21);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "brand###";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(4, 35);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(431, 21);
            lblName.TabIndex = 3;
            lblName.Text = "name###";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 4;
            label2.Text = "Brand / Manufacturer";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.92429F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.07571F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel3.Location = new Point(4, 157);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(610, 149);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(lblDimensions, 0, 3);
            tableLayoutPanel4.Controls.Add(labl5, 0, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 2);
            tableLayoutPanel4.Controls.Add(lblPrice, 0, 1);
            tableLayoutPanel4.Controls.Add(btnReturn, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(438, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.Size = new Size(172, 149);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // lblDimensions
            // 
            lblDimensions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDimensions.AutoSize = true;
            lblDimensions.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDimensions.Location = new Point(4, 72);
            lblDimensions.Margin = new Padding(4, 0, 4, 0);
            lblDimensions.Name = "lblDimensions";
            lblDimensions.Size = new Size(164, 21);
            lblDimensions.TabIndex = 6;
            lblDimensions.Text = "dimensions###";
            lblDimensions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labl5
            // 
            labl5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labl5.AutoSize = true;
            labl5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labl5.Location = new Point(4, 3);
            labl5.Margin = new Padding(4, 0, 4, 0);
            labl5.Name = "labl5";
            labl5.Size = new Size(110, 21);
            labl5.TabIndex = 3;
            labl5.Text = "Price Per Unit";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 51);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 5;
            label4.Text = "Dimensions";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(4, 24);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(164, 21);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "price###";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(112, 70, 97);
            btnReturn.Dock = DockStyle.Fill;
            btnReturn.FlatAppearance.BorderColor = Color.White;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 136, 146);
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 38, 52);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(4, 99);
            btnReturn.Margin = new Padding(4, 3, 4, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(164, 47);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Controls.Add(rtxtDescription, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 18.04878F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 81.95122F));
            tableLayoutPanel6.Size = new Size(438, 149);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 4;
            label1.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.BackColor = SystemColors.Control;
            rtxtDescription.Dock = DockStyle.Fill;
            rtxtDescription.Location = new Point(14, 40);
            rtxtDescription.Margin = new Padding(14);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.ReadOnly = true;
            rtxtDescription.Size = new Size(410, 95);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "Sample Description";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(618, 309);
            tableLayoutPanel5.TabIndex = 14;
            // 
            // DescriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(152, 136, 146);
            ClientSize = new Size(618, 309);
            Controls.Add(tableLayoutPanel5);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(779, 450);
            MinimumSize = new Size(634, 348);
            Name = "DescriptionForm";
            Text = "DescriptionForm";
            ((System.ComponentModel.ISupportInitialize)picBrand).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox picBrand;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label labl5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private RoundButton btnReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDescription;
    }
}