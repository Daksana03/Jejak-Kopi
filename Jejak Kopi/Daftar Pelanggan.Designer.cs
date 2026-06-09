namespace Jejak_Kopi
{
    partial class Daftar_Pelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daftar_Pelanggan));
            label2 = new Label();
            panel2 = new Panel();
            edit_pelanggan_btn = new Button();
            data_pelanggan = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Logout_btn = new Button();
            Laporan_btn = new Button();
            Pesanan_btn = new Button();
            Daftar_pelanggan_btn = new Button();
            Data_btn = new Button();
            Dashboard_btn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_pelanggan).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(475, 13);
            label2.Name = "label2";
            label2.Size = new Size(141, 27);
            label2.TabIndex = 8;
            label2.Text = "Lorem Ipsum";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(edit_pelanggan_btn);
            panel2.Controls.Add(data_pelanggan);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(219, 58);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 280);
            panel2.TabIndex = 9;
            // 
            // edit_pelanggan_btn
            // 
            edit_pelanggan_btn.BackColor = Color.Peru;
            edit_pelanggan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            edit_pelanggan_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_pelanggan_btn.ForeColor = SystemColors.ControlLightLight;
            edit_pelanggan_btn.Location = new Point(336, 236);
            edit_pelanggan_btn.Margin = new Padding(3, 2, 3, 2);
            edit_pelanggan_btn.Name = "edit_pelanggan_btn";
            edit_pelanggan_btn.Size = new Size(111, 30);
            edit_pelanggan_btn.TabIndex = 16;
            edit_pelanggan_btn.Text = "Edit Data ";
            edit_pelanggan_btn.UseVisualStyleBackColor = false;
            // 
            // data_pelanggan
            // 
            data_pelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_pelanggan.Location = new Point(34, 34);
            data_pelanggan.Margin = new Padding(3, 2, 3, 2);
            data_pelanggan.Name = "data_pelanggan";
            data_pelanggan.RowHeadersWidth = 51;
            data_pelanggan.Size = new Size(413, 192);
            data_pelanggan.TabIndex = 3;
            data_pelanggan.CellContentClick += data_pelanggan_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(168, 12);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 2;
            label3.Text = "Daftar Pelanggan:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 13);
            label1.Name = "label1";
            label1.Size = new Size(163, 27);
            label1.TabIndex = 6;
            label1.Text = "Selamat Datang";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Logout_btn);
            panel1.Controls.Add(Laporan_btn);
            panel1.Controls.Add(Pesanan_btn);
            panel1.Controls.Add(Daftar_pelanggan_btn);
            panel1.Controls.Add(Data_btn);
            panel1.Controls.Add(Dashboard_btn);
            panel1.Location = new Point(1, -3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 344);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(70, 22);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 2;
            label4.Text = "Lorem Ipsum";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 40);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Logout_btn
            // 
            Logout_btn.BackColor = Color.Peru;
            Logout_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Logout_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_btn.ForeColor = SystemColors.ControlLightLight;
            Logout_btn.Location = new Point(-3, 298);
            Logout_btn.Margin = new Padding(3, 2, 3, 2);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(221, 42);
            Logout_btn.TabIndex = 15;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // Laporan_btn
            // 
            Laporan_btn.BackColor = Color.Peru;
            Laporan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Laporan_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Laporan_btn.ForeColor = SystemColors.ControlLightLight;
            Laporan_btn.Location = new Point(-3, 167);
            Laporan_btn.Margin = new Padding(3, 2, 3, 2);
            Laporan_btn.Name = "Laporan_btn";
            Laporan_btn.Size = new Size(221, 30);
            Laporan_btn.TabIndex = 14;
            Laporan_btn.Text = "Laporan";
            Laporan_btn.UseVisualStyleBackColor = false;
            Laporan_btn.Click += Laporan_btn_Click;
            // 
            // Pesanan_btn
            // 
            Pesanan_btn.BackColor = Color.Peru;
            Pesanan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Pesanan_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pesanan_btn.ForeColor = SystemColors.ControlLightLight;
            Pesanan_btn.Location = new Point(-3, 140);
            Pesanan_btn.Margin = new Padding(3, 2, 3, 2);
            Pesanan_btn.Name = "Pesanan_btn";
            Pesanan_btn.Size = new Size(221, 30);
            Pesanan_btn.TabIndex = 13;
            Pesanan_btn.Text = "Pesanan";
            Pesanan_btn.UseVisualStyleBackColor = false;
            Pesanan_btn.Click += Pesanan_btn_Click;
            // 
            // Daftar_pelanggan_btn
            // 
            Daftar_pelanggan_btn.BackColor = Color.Peru;
            Daftar_pelanggan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Daftar_pelanggan_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Daftar_pelanggan_btn.ForeColor = SystemColors.ControlLightLight;
            Daftar_pelanggan_btn.Location = new Point(-3, 113);
            Daftar_pelanggan_btn.Margin = new Padding(3, 2, 3, 2);
            Daftar_pelanggan_btn.Name = "Daftar_pelanggan_btn";
            Daftar_pelanggan_btn.Size = new Size(221, 30);
            Daftar_pelanggan_btn.TabIndex = 12;
            Daftar_pelanggan_btn.Text = "Daftar Pelanggan";
            Daftar_pelanggan_btn.UseVisualStyleBackColor = false;
            // 
            // Data_btn
            // 
            Data_btn.BackColor = Color.Peru;
            Data_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Data_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Data_btn.ForeColor = SystemColors.ControlLightLight;
            Data_btn.Location = new Point(-3, 88);
            Data_btn.Margin = new Padding(3, 2, 3, 2);
            Data_btn.Name = "Data_btn";
            Data_btn.Size = new Size(221, 30);
            Data_btn.TabIndex = 10;
            Data_btn.Text = "Data Biji Kopi";
            Data_btn.UseVisualStyleBackColor = false;
            Data_btn.Click += Data_btn_Click;
            // 
            // Dashboard_btn
            // 
            Dashboard_btn.BackColor = Color.Peru;
            Dashboard_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Dashboard_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard_btn.ForeColor = SystemColors.ControlLightLight;
            Dashboard_btn.Location = new Point(-3, 62);
            Dashboard_btn.Margin = new Padding(3, 2, 3, 2);
            Dashboard_btn.Name = "Dashboard_btn";
            Dashboard_btn.Size = new Size(221, 30);
            Dashboard_btn.TabIndex = 9;
            Dashboard_btn.Text = "Dashboard";
            Dashboard_btn.UseVisualStyleBackColor = false;
            Dashboard_btn.Click += Dashboard_btn_Click;
            // 
            // Daftar_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Daftar_Pelanggan";
            Text = "Daftar_Pelanggan";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_pelanggan).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Button button2;
        private Button edit_pelanggan_btn;
        private DataGridView data_pelanggan;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Button Logout_btn;
        private Button Laporan_btn;
        private Button Pesanan_btn;
        private Button Daftar_pelanggan_btn;
        private Button Data_btn;
        private Button Dashboard_btn;
    }
}