namespace Jejak_Kopi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Kembali1 = new Button();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            Register2 = new Button();
            Password = new TextBox();
            Username = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Kembali1
            // 
            Kembali1.BackgroundImage = (Image)resources.GetObject("Kembali1.BackgroundImage");
            Kembali1.BackgroundImageLayout = ImageLayout.Stretch;
            Kembali1.Font = new Font("Times New Roman", 9F);
            Kembali1.ForeColor = SystemColors.ControlLightLight;
            Kembali1.Location = new Point(37, 364);
            Kembali1.Name = "Kembali1";
            Kembali1.Size = new Size(94, 29);
            Kembali1.TabIndex = 22;
            Kembali1.Text = "Kembali";
            Kembali1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 173);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 21;
            label3.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 9);
            label6.Name = "label6";
            label6.Size = new Size(176, 39);
            label6.TabIndex = 20;
            label6.Text = "Jejak Kopi: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 48);
            label5.Name = "label5";
            label5.Size = new Size(177, 17);
            label5.TabIndex = 19;
            label5.Text = "Sistem Pengelolaan Biji Kopi";
            // 
            // Register2
            // 
            Register2.BackgroundImage = (Image)resources.GetObject("Register2.BackgroundImage");
            Register2.BackgroundImageLayout = ImageLayout.Stretch;
            Register2.Font = new Font("Times New Roman", 9F);
            Register2.ForeColor = SystemColors.ControlLightLight;
            Register2.Location = new Point(234, 364);
            Register2.Name = "Register2";
            Register2.Size = new Size(94, 29);
            Register2.TabIndex = 18;
            Register2.Text = "Register";
            Register2.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            Password.Location = new Point(37, 264);
            Password.Name = "Password";
            Password.Size = new Size(277, 27);
            Password.TabIndex = 16;
            // 
            // Username
            // 
            Username.Location = new Point(37, 193);
            Username.Name = "Username";
            Username.Size = new Size(277, 27);
            Username.TabIndex = 15;
            Username.TextChanged += Username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 244);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(79, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 103);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(364, 403);
            Controls.Add(Kembali1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Register2);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form Registrasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Kembali1;
        private Label label3;
        private Label label6;
        private Label label5;
        private Button Register2;
        private TextBox Password;
        private TextBox Username;
        private Label label2;
        private PictureBox pictureBox1;
    }
}