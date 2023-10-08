namespace APP.UI
{
    partial class AddStockForm
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
            stockNametextBox = new TextBox();
            Savebutton = new Button();
            LocationtextBox = new TextBox();
            label2 = new Label();
            DesctextBox = new TextBox();
            label3 = new Label();
            HappyLabel = new Label();
            Nameerrorlabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 28);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم المخزن";
            // 
            // stockNametextBox
            // 
            stockNametextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            stockNametextBox.Location = new Point(78, 38);
            stockNametextBox.Margin = new Padding(3, 2, 3, 2);
            stockNametextBox.Name = "stockNametextBox";
            stockNametextBox.Size = new Size(280, 27);
            stockNametextBox.TabIndex = 1;
            // 
            // Savebutton
            // 
            Savebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Savebutton.Location = new Point(269, 201);
            Savebutton.Margin = new Padding(3, 2, 3, 2);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(89, 29);
            Savebutton.TabIndex = 2;
            Savebutton.Text = "اضافة ";
            Savebutton.UseVisualStyleBackColor = true;
            Savebutton.Click += Savebutton_Click;
            // 
            // LocationtextBox
            // 
            LocationtextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LocationtextBox.Location = new Point(78, 99);
            LocationtextBox.Margin = new Padding(3, 2, 3, 2);
            LocationtextBox.Name = "LocationtextBox";
            LocationtextBox.Size = new Size(280, 27);
            LocationtextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(418, 90);
            label2.Name = "label2";
            label2.Size = new Size(97, 37);
            label2.TabIndex = 3;
            label2.Text = "العنوان";
            // 
            // DesctextBox
            // 
            DesctextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DesctextBox.Location = new Point(78, 156);
            DesctextBox.Margin = new Padding(3, 2, 3, 2);
            DesctextBox.Name = "DesctextBox";
            DesctextBox.Size = new Size(280, 27);
            DesctextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(418, 147);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 5;
            label3.Text = "الوصف";
            // 
            // HappyLabel
            // 
            HappyLabel.AutoSize = true;
            HappyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HappyLabel.ForeColor = Color.Lime;
            HappyLabel.Location = new Point(125, 201);
            HappyLabel.Name = "HappyLabel";
            HappyLabel.Size = new Size(92, 21);
            HappyLabel.TabIndex = 7;
            HappyLabel.Text = "تمت الاضافة";
            HappyLabel.Visible = false;
            // 
            // Nameerrorlabel
            // 
            Nameerrorlabel.AutoSize = true;
            Nameerrorlabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Nameerrorlabel.ForeColor = Color.Red;
            Nameerrorlabel.Location = new Point(8, 38);
            Nameerrorlabel.Name = "Nameerrorlabel";
            Nameerrorlabel.Size = new Size(64, 13);
            Nameerrorlabel.TabIndex = 8;
            Nameerrorlabel.Text = "حقل مطلوب";
            Nameerrorlabel.Visible = false;
            // 
            // AddStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 250);
            Controls.Add(Nameerrorlabel);
            Controls.Add(HappyLabel);
            Controls.Add(DesctextBox);
            Controls.Add(label3);
            Controls.Add(LocationtextBox);
            Controls.Add(label2);
            Controls.Add(Savebutton);
            Controls.Add(stockNametextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddStockForm";
            Text = "AddStockForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox stockNametextBox;
        private Button Savebutton;
        private TextBox LocationtextBox;
        private Label label2;
        private TextBox DesctextBox;
        private Label label3;
        private Label HappyLabel;
        private Label Nameerrorlabel;
    }
}