namespace Jejak_Kopi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            label4 = new Label();
            Login1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            Register1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 183);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // Username
            // 
            Username.Location = new Point(32, 145);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Name = "Username";
            Username.Size = new Size(243, 23);
            Username.TabIndex = 3;
            // 
            // Password
            // 
            Password.Location = new Point(32, 198);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Size = new Size(243, 23);
            Password.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(55, 234);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 6;
            label4.Text = "Belum Punya Akun?";
            // 
            // Login1
            // 
            Login1.BackgroundImage = (Image)resources.GetObject("Login1.BackgroundImage");
            Login1.BackgroundImageLayout = ImageLayout.Stretch;
            Login1.Font = new Font("Times New Roman", 9F);
            Login1.ForeColor = SystemColors.ControlLightLight;
            Login1.Location = new Point(205, 273);
            Login1.Margin = new Padding(3, 2, 3, 2);
            Login1.Name = "Login1";
            Login1.Size = new Size(82, 22);
            Login1.TabIndex = 8;
            Login1.Text = "Login";
            Login1.UseVisualStyleBackColor = true;
            Login1.Click += Login1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(69, 36);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 77);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 36);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 9;
            label5.Text = "Sistem Pengelolaan Biji Kopi";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(80, 7);
            label6.Name = "label6";
            label6.Size = new Size(140, 31);
            label6.TabIndex = 10;
            label6.Text = "Jejak Kopi: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 130);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // Register1
            // 
            Register1.BackgroundImage = (Image)resources.GetObject("Register1.BackgroundImage");
            Register1.BackgroundImageLayout = ImageLayout.Stretch;
            Register1.Font = new Font("Times New Roman", 9F);
            Register1.ForeColor = SystemColors.ControlLightLight;
            Register1.Location = new Point(173, 230);
            Register1.Margin = new Padding(3, 2, 3, 2);
            Register1.Name = "Register1";
            Register1.Size = new Size(82, 22);
            Register1.TabIndex = 12;
            Register1.Text = "Register";
            Register1.UseVisualStyleBackColor = true;
            Register1.Click += Register1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(314, 304);
            Controls.Add(Register1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Login1);
            Controls.Add(label4);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox Username;
        private TextBox Password;
        private Label label4;
        private Button Login1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Button Register1;
    }
}
