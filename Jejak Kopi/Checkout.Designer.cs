namespace Jejak_Kopi
{
    partial class Checkout
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
            Email = new TextBox();
            label7 = new Label();
            No_Telp = new TextBox();
            label4 = new Label();
            Password = new TextBox();
            label2 = new Label();
            Kembali1 = new Button();
            Register2 = new Button();
            Username = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 19);
            label1.Name = "label1";
            label1.Size = new Size(289, 34);
            label1.TabIndex = 27;
            label1.Text = "Konfirmasi Pemesanan";
            // 
            // Email
            // 
            Email.Location = new Point(62, 255);
            Email.Name = "Email";
            Email.Size = new Size(323, 27);
            Email.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 235);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 37;
            label7.Text = "Kabupaten:";
            // 
            // No_Telp
            // 
            No_Telp.Location = new Point(62, 203);
            No_Telp.Name = "No_Telp";
            No_Telp.Size = new Size(323, 27);
            No_Telp.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 183);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 35;
            label4.Text = "Kecamatan:";
            // 
            // Password
            // 
            Password.Location = new Point(62, 146);
            Password.Name = "Password";
            Password.Size = new Size(323, 27);
            Password.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 126);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 33;
            label2.Text = "Jalan:";
            // 
            // Kembali1
            // 
            Kembali1.BackColor = Color.Peru;
            Kembali1.BackgroundImageLayout = ImageLayout.Stretch;
            Kembali1.Font = new Font("Times New Roman", 9F);
            Kembali1.ForeColor = SystemColors.ControlLightLight;
            Kembali1.Location = new Point(24, 387);
            Kembali1.Name = "Kembali1";
            Kembali1.Size = new Size(94, 29);
            Kembali1.TabIndex = 39;
            Kembali1.Text = "Kembali";
            Kembali1.UseVisualStyleBackColor = false;
            // 
            // Register2
            // 
            Register2.BackColor = Color.Peru;
            Register2.BackgroundImageLayout = ImageLayout.Stretch;
            Register2.Font = new Font("Times New Roman", 9F);
            Register2.ForeColor = SystemColors.ControlLightLight;
            Register2.Location = new Point(329, 387);
            Register2.Name = "Register2";
            Register2.Size = new Size(94, 29);
            Register2.TabIndex = 40;
            Register2.Text = "Checkout";
            Register2.UseVisualStyleBackColor = false;
            // 
            // Username
            // 
            Username.Location = new Point(62, 94);
            Username.Name = "Username";
            Username.Size = new Size(323, 27);
            Username.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 74);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 31;
            label3.Text = "No Alamat:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 28);
            comboBox1.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 308);
            label5.Name = "label5";
            label5.Size = new Size(134, 17);
            label5.TabIndex = 42;
            label5.Text = "Metode Pembayaran:";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(450, 428);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(Email);
            Controls.Add(label7);
            Controls.Add(No_Telp);
            Controls.Add(label4);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(Kembali1);
            Controls.Add(Register2);
            Controls.Add(Username);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Checkout";
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Email;
        private Label label7;
        private TextBox No_Telp;
        private Label label4;
        private TextBox Password;
        private Label label2;
        private Button Kembali1;
        private Button Register2;
        private TextBox Username;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
    }
}