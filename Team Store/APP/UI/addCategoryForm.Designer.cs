namespace APP.UI
{
    partial class AddCategoryForm
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
            label1 = new Label();
            NametextBox = new TextBox();
            DesctextBox = new TextBox();
            label2 = new Label();
            Savebutton = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(358, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 40);
            label1.TabIndex = 0;
            label1.Text = "الفئة";
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(53, 19);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(260, 27);
            NametextBox.TabIndex = 1;
            // 
            // DesctextBox
            // 
            DesctextBox.Location = new Point(53, 83);
            DesctextBox.Name = "DesctextBox";
            DesctextBox.Size = new Size(260, 27);
            DesctextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(319, 71);
            label2.Name = "label2";
            label2.Size = new Size(102, 40);
            label2.TabIndex = 2;
            label2.Text = "الوصف";
            // 
            // Savebutton
            // 
            Savebutton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Savebutton.Location = new Point(215, 128);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(98, 34);
            Savebutton.TabIndex = 4;
            Savebutton.Text = "اضافة";
            Savebutton.UseVisualStyleBackColor = true;
            Savebutton.Click += Savebutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(53, 132);
            label3.Name = "label3";
            label3.Size = new Size(136, 27);
            label3.TabIndex = 5;
            label3.Text = "تمت الاضافة بنجاح";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(16, 19);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 6;
            label4.Text = "مطلوب";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 196);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Savebutton);
            Controls.Add(DesctextBox);
            Controls.Add(label2);
            Controls.Add(NametextBox);
            Controls.Add(label1);
            Name = "AddCategoryForm";
            Text = "addCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NametextBox;
        private TextBox DesctextBox;
        private Label label2;
        private Button Savebutton;
        private Label label3;
        private Label label4;
    }
}