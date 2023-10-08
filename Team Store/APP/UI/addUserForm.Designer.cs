namespace APP.UI
{
    partial class AddUserForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(428, 17);
            label1.Name = "label1";
            label1.Size = new Size(81, 40);
            label1.TabIndex = 1;
            label1.Text = "الاسم";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(206, 300);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 2;
            button1.Text = "اضاقة";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(376, 132);
            label2.Name = "label2";
            label2.Size = new Size(133, 40);
            label2.TabIndex = 4;
            label2.Text = "كلمة السر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(331, 72);
            label3.Name = "label3";
            label3.Size = new Size(178, 40);
            label3.TabIndex = 5;
            label3.Text = "اسم المستخدم";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 27);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(12, 300);
            label4.Name = "label4";
            label4.Size = new Size(131, 23);
            label4.TabIndex = 7;
            label4.Text = "تمت الاضافة بنجاح";
            label4.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 28);
            comboBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 27);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(431, 194);
            label5.Name = "label5";
            label5.Size = new Size(78, 40);
            label5.TabIndex = 10;
            label5.Text = "النوع";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(362, 252);
            label6.Name = "label6";
            label6.Size = new Size(147, 40);
            label6.TabIndex = 12;
            label6.Text = "الصلاحيات";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 252);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(292, 28);
            comboBox2.TabIndex = 11;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 366);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AddUserForm";
            Text = "addSupplierForm";
            Load += addSupplierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
    }
}