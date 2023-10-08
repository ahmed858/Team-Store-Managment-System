namespace Team_Store
{
    partial class DashboardForm
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
            TopPanel = new Panel();
            pictureBox9 = new PictureBox();
            LogoutPictureBox = new PictureBox();
            pictureBox8 = new PictureBox();
            headlineLabel = new Label();
            LeftPanal = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            panel6 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ProductPanel = new Panel();
            ProductLabel = new Label();
            ProductPictureBox = new PictureBox();
            panel5 = new Panel();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            PruchBillpanel = new Panel();
            label5 = new Label();
            PruchBillpictureBox = new PictureBox();
            BillOfSalePanel = new Panel();
            label4 = new Label();
            billpictureBox = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            FillPanel = new Panel();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            LeftPanal.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            PruchBillpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PruchBillpictureBox).BeginInit();
            BillOfSalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billpictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.MenuHighlight;
            TopPanel.Controls.Add(pictureBox9);
            TopPanel.Controls.Add(LogoutPictureBox);
            TopPanel.Controls.Add(pictureBox8);
            TopPanel.Controls.Add(headlineLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Margin = new Padding(3, 4, 3, 4);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1541, 155);
            TopPanel.TabIndex = 0;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = SystemColors.Highlight;
            pictureBox9.Image = APP.Properties.Resources.IconManageStaff;
            pictureBox9.Location = new Point(43, 4);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(41, 39);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // LogoutPictureBox
            // 
            LogoutPictureBox.Image = APP.Properties.Resources.IconLogOut;
            LogoutPictureBox.Location = new Point(3, 4);
            LogoutPictureBox.Margin = new Padding(3, 4, 3, 4);
            LogoutPictureBox.Name = "LogoutPictureBox";
            LogoutPictureBox.Size = new Size(35, 39);
            LogoutPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutPictureBox.TabIndex = 17;
            LogoutPictureBox.TabStop = false;
            LogoutPictureBox.Click += LogoutPictureBox_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Image = APP.Properties.Resources.PersonIcon1;
            pictureBox8.Location = new Point(91, 4);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 39);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // headlineLabel
            // 
            headlineLabel.AutoSize = true;
            headlineLabel.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            headlineLabel.ForeColor = Color.White;
            headlineLabel.Location = new Point(788, 19);
            headlineLabel.Name = "headlineLabel";
            headlineLabel.Size = new Size(470, 91);
            headlineLabel.TabIndex = 2;
            headlineLabel.Text = "الصفحة الرئيسة";
            // 
            // LeftPanal
            // 
            LeftPanal.BackColor = Color.FromArgb(0, 0, 64);
            LeftPanal.Controls.Add(panel7);
            LeftPanal.Controls.Add(panel6);
            LeftPanal.Controls.Add(panel1);
            LeftPanal.Controls.Add(ProductPanel);
            LeftPanal.Controls.Add(panel5);
            LeftPanal.Controls.Add(PruchBillpanel);
            LeftPanal.Controls.Add(BillOfSalePanel);
            LeftPanal.Controls.Add(panel2);
            LeftPanal.Dock = DockStyle.Right;
            LeftPanal.Location = new Point(1043, 155);
            LeftPanal.Margin = new Padding(3, 4, 3, 4);
            LeftPanal.Name = "LeftPanal";
            LeftPanal.Size = new Size(498, 690);
            LeftPanal.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox7);
            panel7.Dock = DockStyle.Top;
            panel7.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(0, 657);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(498, 95);
            panel7.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(235, 16);
            label7.Name = "label7";
            label7.Size = new Size(136, 54);
            label7.TabIndex = 2;
            label7.Text = "المخزن";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = APP.Properties.Resources.IconHome1;
            pictureBox7.Location = new Point(413, 16);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(62, 55);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(pictureBox2);
            panel6.Dock = DockStyle.Top;
            panel6.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(0, 562);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(498, 95);
            panel6.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(250, 16);
            label2.Name = "label2";
            label2.Size = new Size(116, 54);
            label2.TabIndex = 2;
            label2.Text = "تقارير";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = APP.Properties.Resources.IconHome1;
            pictureBox2.Location = new Point(413, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 467);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 95);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(189, 16);
            label1.Name = "label1";
            label1.Size = new Size(183, 54);
            label1.TabIndex = 2;
            label1.Text = "مصروفات";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = APP.Properties.Resources.IconHome1;
            pictureBox1.Location = new Point(413, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ProductPanel
            // 
            ProductPanel.Controls.Add(ProductLabel);
            ProductPanel.Controls.Add(ProductPictureBox);
            ProductPanel.Dock = DockStyle.Top;
            ProductPanel.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            ProductPanel.Location = new Point(0, 372);
            ProductPanel.Margin = new Padding(3, 4, 3, 4);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(498, 95);
            ProductPanel.TabIndex = 13;
            ProductPanel.Click += ProductPanel_Click;
            // 
            // ProductLabel
            // 
            ProductLabel.AutoSize = true;
            ProductLabel.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            ProductLabel.ForeColor = Color.White;
            ProductLabel.Location = new Point(71, 16);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(304, 54);
            ProductLabel.TabIndex = 2;
            ProductLabel.Text = "المنتجات/الأصناف";
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Image = APP.Properties.Resources.IconHome1;
            ProductPictureBox.Location = new Point(413, 16);
            ProductPictureBox.Margin = new Padding(3, 4, 3, 4);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(62, 55);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPictureBox.TabIndex = 1;
            ProductPictureBox.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox6);
            panel5.Dock = DockStyle.Top;
            panel5.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(0, 277);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(498, 95);
            panel5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(214, 16);
            label6.Name = "label6";
            label6.Size = new Size(159, 54);
            label6.TabIndex = 2;
            label6.Text = "الموظفين";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = APP.Properties.Resources.IconHome1;
            pictureBox6.Location = new Point(413, 29);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(62, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // PruchBillpanel
            // 
            PruchBillpanel.Controls.Add(label5);
            PruchBillpanel.Controls.Add(PruchBillpictureBox);
            PruchBillpanel.Dock = DockStyle.Top;
            PruchBillpanel.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            PruchBillpanel.Location = new Point(0, 182);
            PruchBillpanel.Margin = new Padding(3, 4, 3, 4);
            PruchBillpanel.Name = "PruchBillpanel";
            PruchBillpanel.Size = new Size(498, 95);
            PruchBillpanel.TabIndex = 16;
            PruchBillpanel.Click += PruchBillpanel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(98, 29);
            label5.Name = "label5";
            label5.Size = new Size(265, 54);
            label5.TabIndex = 2;
            label5.Text = "فاتورة مشتريات";
            // 
            // PruchBillpictureBox
            // 
            PruchBillpictureBox.Image = APP.Properties.Resources.IconHome1;
            PruchBillpictureBox.Location = new Point(413, 29);
            PruchBillpictureBox.Margin = new Padding(3, 4, 3, 4);
            PruchBillpictureBox.Name = "PruchBillpictureBox";
            PruchBillpictureBox.Size = new Size(62, 55);
            PruchBillpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PruchBillpictureBox.TabIndex = 1;
            PruchBillpictureBox.TabStop = false;
            // 
            // BillOfSalePanel
            // 
            BillOfSalePanel.Controls.Add(label4);
            BillOfSalePanel.Controls.Add(billpictureBox);
            BillOfSalePanel.Dock = DockStyle.Top;
            BillOfSalePanel.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            BillOfSalePanel.Location = new Point(0, 95);
            BillOfSalePanel.Margin = new Padding(3, 4, 3, 4);
            BillOfSalePanel.Name = "BillOfSalePanel";
            BillOfSalePanel.Size = new Size(498, 87);
            BillOfSalePanel.TabIndex = 15;
            BillOfSalePanel.Click += BillOfSalePanel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(189, 15);
            label4.Name = "label4";
            label4.Size = new Size(174, 54);
            label4.TabIndex = 2;
            label4.Text = " بيع جديدة";
            // 
            // billpictureBox
            // 
            billpictureBox.Image = APP.Properties.Resources.IconHome1;
            billpictureBox.Location = new Point(413, 24);
            billpictureBox.Margin = new Padding(3, 4, 3, 4);
            billpictureBox.Name = "billpictureBox";
            billpictureBox.Size = new Size(62, 55);
            billpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            billpictureBox.TabIndex = 1;
            billpictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 95);
            panel2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 16);
            label3.Name = "label3";
            label3.Size = new Size(277, 54);
            label3.TabIndex = 2;
            label3.Text = "الصفحة الرئيسية";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = APP.Properties.Resources.IconHome1;
            pictureBox3.Location = new Point(413, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // FillPanel
            // 
            FillPanel.Dock = DockStyle.Fill;
            FillPanel.Location = new Point(0, 155);
            FillPanel.Margin = new Padding(3, 4, 3, 4);
            FillPanel.Name = "FillPanel";
            FillPanel.Size = new Size(1043, 690);
            FillPanel.TabIndex = 2;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 845);
            Controls.Add(FillPanel);
            Controls.Add(LeftPanal);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            LeftPanal.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ProductPanel.ResumeLayout(false);
            ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            PruchBillpanel.ResumeLayout(false);
            PruchBillpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PruchBillpictureBox).EndInit();
            BillOfSalePanel.ResumeLayout(false);
            BillOfSalePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)billpictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label headlineLabel;
        private Panel LeftPanal;
        private PictureBox pictureBox8;
        private PictureBox LogoutPictureBox;



        private Panel panel5;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel PruchBillpanel;
        private Label label5;
        private PictureBox PruchBillpictureBox;
        private Panel BillOfSalePanel;
        private Label label4;
        private PictureBox billpictureBox;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel ProductPanel;
        private Label ProductLabel;
        private PictureBox ProductPictureBox;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Label label7;
        private PictureBox pictureBox7;
        private Panel panel6;
        private Label label2;
        private PictureBox pictureBox2;
        public Panel FillPanel;
        private PictureBox pictureBox9;
    }
}