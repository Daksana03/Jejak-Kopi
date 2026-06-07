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
            this.Kabupaten = new TextBox();
            label7 = new Label();
            Kecamatan = new TextBox();
            label4 = new Label();
            Jalan = new TextBox();
            label2 = new Label();
            Kembali1 = new Button();
            Register2 = new Button();
            NoJalan = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 14);
            label1.Name = "label1";
            label1.Size = new Size(234, 27);
            label1.TabIndex = 27;
            label1.Text = "Konfirmasi Pemesanan";
            // 
            // Kabupaten
            // 
            this.Kabupaten.Location = new Point(54, 191);
            this.Kabupaten.Margin = new Padding(3, 2, 3, 2);
            this.Kabupaten.Name = "Kabupaten";
            this.Kabupaten.Size = new Size(283, 23);
            this.Kabupaten.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 176);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 37;
            label7.Text = "Kabupaten:";
            // 
            // Kecamatan
            // 
            Kecamatan.Location = new Point(54, 152);
            Kecamatan.Margin = new Padding(3, 2, 3, 2);
            Kecamatan.Name = "Kecamatan";
            Kecamatan.Size = new Size(283, 23);
            Kecamatan.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 137);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 35;
            label4.Text = "Kecamatan:";
            // 
            // Jalan
            // 
            Jalan.Location = new Point(54, 110);
            Jalan.Margin = new Padding(3, 2, 3, 2);
            Jalan.Name = "Jalan";
            Jalan.Size = new Size(283, 23);
            Jalan.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 94);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 33;
            label2.Text = "Jalan:";
            // 
            // Kembali1
            // 
            Kembali1.BackColor = Color.Peru;
            Kembali1.BackgroundImageLayout = ImageLayout.Stretch;
            Kembali1.Font = new Font("Times New Roman", 9F);
            Kembali1.ForeColor = SystemColors.ControlLightLight;
            Kembali1.Location = new Point(21, 290);
            Kembali1.Margin = new Padding(3, 2, 3, 2);
            Kembali1.Name = "Kembali1";
            Kembali1.Size = new Size(82, 22);
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
            Register2.Location = new Point(288, 290);
            Register2.Margin = new Padding(3, 2, 3, 2);
            Register2.Name = "Register2";
            Register2.Size = new Size(82, 22);
            Register2.TabIndex = 40;
            Register2.Text = "Checkout";
            Register2.UseVisualStyleBackColor = false;
            Register2.Click += Register2_Click;
            // 
            // NoJalan
            // 
            NoJalan.Location = new Point(54, 70);
            NoJalan.Margin = new Padding(3, 2, 3, 2);
            NoJalan.Name = "NoJalan";
            NoJalan.Size = new Size(283, 23);
            NoJalan.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 56);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 31;
            label3.Text = "No Alamat:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 246);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(135, 231);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 42;
            label5.Text = "Metode Pembayaran:";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(394, 321);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(this.Kabupaten);
            Controls.Add(label7);
            Controls.Add(Kecamatan);
            Controls.Add(label4);
            Controls.Add(Jalan);
            Controls.Add(label2);
            Controls.Add(Kembali1);
            Controls.Add(Register2);
            Controls.Add(NoJalan);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Checkout";
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Email;
        private Label label7;
        private TextBox Kecamatan;
        private Label label4;
        private TextBox Jalan;
        private Label label2;
        private Button Kembali1;
        private Button Register2;
        private TextBox NoJalan;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox Kabupaten;
    }
}