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
            if (pictureBox1.BackgroundImage != null)
            {
                pictureBox1.BackgroundImage.Dispose();
                pictureBox1.BackgroundImage = null;
                //Kembali1.Dispose();
                //label3.Dispose();
                //label6.Dispose();
                //label5.Dispose();
                //Register2.Dispose();
                //Username.Dispose();
                //Nama.Dispose();
                //label2.Dispose();
                //pictureBox1.Dispose();
                //Password.Dispose();
                //label1.Dispose();
                //No_Telp.Dispose();
                //label4.Dispose();
                //Email.Dispose();
                //label7.Dispose();
            }

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
            Username = new TextBox();
            Nama = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Password = new TextBox();
            label1 = new Label();
            No_Telp = new TextBox();
            label4 = new Label();
            Email = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Kembali1
            // 
            Kembali1.BackColor = Color.Peru;
            Kembali1.BackgroundImageLayout = ImageLayout.Stretch;
            Kembali1.Font = new Font("Times New Roman", 9F);
            Kembali1.ForeColor = SystemColors.ControlLightLight;
            Kembali1.Location = new Point(37, 435);
            Kembali1.Name = "Kembali1";
            Kembali1.Size = new Size(94, 29);
            Kembali1.TabIndex = 29;
            Kembali1.Text = "Kembali";
            Kembali1.UseVisualStyleBackColor = false;
            Kembali1.Click += Kembali1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 148);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 21;
            label3.Text = "Nama Lengkap";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(123, 5);
            label6.Name = "label6";
            label6.Size = new Size(176, 39);
            label6.TabIndex = 20;
            label6.Text = "Jejak Kopi: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(117, 44);
            label5.Name = "label5";
            label5.Size = new Size(177, 17);
            label5.TabIndex = 19;
            label5.Text = "Sistem Pengelolaan Biji Kopi";
            // 
            // Register2
            // 
            Register2.BackColor = Color.Peru;
            Register2.BackgroundImageLayout = ImageLayout.Stretch;
            Register2.Font = new Font("Times New Roman", 9F);
            Register2.ForeColor = SystemColors.ControlLightLight;
            Register2.Location = new Point(280, 435);
            Register2.Name = "Register2";
            Register2.Size = new Size(94, 29);
            Register2.TabIndex = 30;
            Register2.Text = "Register";
            Register2.UseVisualStyleBackColor = false;
            Register2.Click += Register2_Click_1;
            // 
            // Username
            // 
            Username.Location = new Point(42, 227);
            Username.Name = "Username";
            Username.Size = new Size(323, 27);
            Username.TabIndex = 16;
            Username.KeyDown += Pindah;
            Username.PreviewKeyDown += _PreviewKeyDown;
            // 
            // Nama
            // 
            Nama.Location = new Point(42, 168);
            Nama.Name = "Nama";
            Nama.Size = new Size(323, 27);
            Nama.TabIndex = 15;
            Nama.TextChanged += Username_TextChanged;
            Nama.KeyDown += Pindah;
            Nama.PreviewKeyDown += _PreviewKeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 207);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 14;
            label2.Text = "Buat Username:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(110, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 103);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Password
            // 
            Password.Location = new Point(42, 279);
            Password.Name = "Password";
            Password.Size = new Size(323, 27);
            Password.TabIndex = 24;
            Password.KeyDown += Pindah;
            Password.PreviewKeyDown += _PreviewKeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 259);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 23;
            label1.Text = "Buat Password:";
            // 
            // No_Telp
            // 
            No_Telp.Location = new Point(42, 336);
            No_Telp.Name = "No_Telp";
            No_Telp.Size = new Size(323, 27);
            No_Telp.TabIndex = 26;
            No_Telp.KeyDown += Pindah;
            No_Telp.PreviewKeyDown += _PreviewKeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 316);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 25;
            label4.Text = "No Telpon:";
            // 
            // Email
            // 
            Email.Location = new Point(42, 388);
            Email.Name = "Email";
            Email.Size = new Size(323, 27);
            Email.TabIndex = 28;
            Email.KeyDown += Pindah;
            Email.PreviewKeyDown += _PreviewKeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 368);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 27;
            label7.Text = "Email:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(405, 475);
            Controls.Add(Email);
            Controls.Add(label7);
            Controls.Add(No_Telp);
            Controls.Add(label4);
            Controls.Add(Password);
            Controls.Add(label1);
            Controls.Add(Kembali1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Register2);
            Controls.Add(Username);
            Controls.Add(Nama);
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
        private TextBox Username;
        private TextBox Nama;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox Password;
        private Label label1;
        private TextBox No_Telp;
        private Label label4;
        private TextBox Email;
        private Label label7;
    }
}