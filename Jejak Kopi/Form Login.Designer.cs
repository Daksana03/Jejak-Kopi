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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            label4 = new Label();
            Register1 = new Button();
            Login1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            //contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 244);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // Username
            // 
            Username.Location = new Point(37, 193);
            Username.Name = "Username";
            Username.Size = new Size(277, 27);
            Username.TabIndex = 3;
            Username.KeyDown += Pindah;
            Username.PreviewKeyDown += _PreviewKeyDown;
            // 
            // Password
            // 
            Password.Location = new Point(37, 264);
            Password.Name = "Password";
            Password.Size = new Size(277, 27);
            Password.TabIndex = 4;
            Password.KeyDown += Pindah;
            Password.PreviewKeyDown += _PreviewKeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(63, 312);
            label4.Name = "label4";
            label4.Size = new Size(129, 17);
            label4.TabIndex = 6;
            label4.Text = "Belum Punya Akun?";
            // 
            // Register1
            // 
            Register1.BackColor = Color.Peru;
            Register1.BackgroundImageLayout = ImageLayout.Stretch;
            Register1.Font = new Font("Times New Roman", 9F);
            Register1.ForeColor = SystemColors.ControlLightLight;
            Register1.Location = new Point(198, 307);
            Register1.Name = "Register1";
            Register1.Size = new Size(94, 29);
            Register1.TabIndex = 12;
            Register1.Text = "Register";
            Register1.UseVisualStyleBackColor = false;
            Register1.Click += Register1_Click;
            // 
            // Login1
            // 
            Login1.BackColor = Color.Peru;
            Login1.BackgroundImageLayout = ImageLayout.Stretch;
            Login1.Font = new Font("Times New Roman", 9F);
            Login1.ForeColor = SystemColors.ControlLightLight;
            Login1.Location = new Point(234, 364);
            Login1.Name = "Login1";
            Login1.Size = new Size(94, 29);
            Login1.TabIndex = 13;
            Login1.Text = "Login";
            Login1.UseVisualStyleBackColor = false;
            Login1.Click += Login1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(79, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 48);
            label5.Name = "label5";
            label5.Size = new Size(177, 17);
            label5.TabIndex = 9;
            label5.Text = "Sistem Pengelolaan Biji Kopi";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(91, 9);
            label6.Name = "label6";
            label6.Size = new Size(176, 39);
            label6.TabIndex = 10;
            label6.Text = "Jejak Kopi: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 173);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // contextMenuStrip1
            // 
            //contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            //contextMenuStrip1.Name = "contextMenuStrip1";
            //contextMenuStrip1.Size = new Size(61, 4);
            //// 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(359, 405);
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
        private Button Register1;
        private Button Login1;
        //private Button button2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label3;
        //private ContextMenuStrip contextMenuStrip1; ???
    }
}
