namespace Team_Store
{
    partial class LoginForm
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
            login_btn = new Button();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.White;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.Location = new Point(106, 463);
            login_btn.Margin = new Padding(3, 4, 3, 4);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(197, 56);
            login_btn.TabIndex = 0;
            login_btn.Text = "Log-in";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // username_textBox
            // 
            username_textBox.BorderStyle = BorderStyle.FixedSingle;
            username_textBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_textBox.Location = new Point(18, 252);
            username_textBox.Margin = new Padding(3, 4, 3, 4);
            username_textBox.Multiline = true;
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(387, 59);
            username_textBox.TabIndex = 2;
            // 
            // password_textBox
            // 
            password_textBox.BorderStyle = BorderStyle.FixedSingle;
            password_textBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_textBox.Location = new Point(18, 370);
            password_textBox.Margin = new Padding(3, 4, 3, 4);
            password_textBox.Multiline = true;
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(387, 59);
            password_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 206);
            label1.Name = "label1";
            label1.Size = new Size(97, 27);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 325);
            label2.Name = "label2";
            label2.Size = new Size(93, 27);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = APP.Properties.Resources.login;
            pictureBox1.Location = new Point(122, 56);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(106, 9);
            label3.Name = "label3";
            label3.Size = new Size(185, 43);
            label3.TabIndex = 7;
            label3.Text = "Team Store";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(417, 563);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(login_btn);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Team Store System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}

