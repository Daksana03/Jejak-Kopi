namespace Jejak_Kopi
{
    partial class Pesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesanan));
            status_btn = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
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
            status_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // status_btn
            // 
            status_btn.BackColor = Color.Linen;
            status_btn.Controls.Add(button1);
            status_btn.Controls.Add(dataGridView1);
            status_btn.Controls.Add(label3);
            status_btn.Location = new Point(250, 56);
            status_btn.Name = "status_btn";
            status_btn.Size = new Size(550, 396);
            status_btn.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(381, 338);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 16;
            button1.Text = "Ubah Status";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(484, 291);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 36);
            label3.Name = "label3";
            label3.Size = new Size(0, 34);
            label3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 11);
            label1.Name = "label1";
            label1.Size = new Size(241, 34);
            label1.TabIndex = 2;
            label1.Text = "Pesanan Pelanggan";
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
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 451);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(80, 29);
            label4.Name = "label4";
            label4.Size = new Size(138, 26);
            label4.TabIndex = 2;
            label4.Text = "Lorem Ipsum";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 53);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Logout_btn
            // 
            Logout_btn.BackColor = Color.Peru;
            Logout_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Logout_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_btn.ForeColor = SystemColors.ControlLightLight;
            Logout_btn.Location = new Point(-3, 396);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(253, 56);
            Logout_btn.TabIndex = 15;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            // 
            // Laporan_btn
            // 
            Laporan_btn.BackColor = Color.Peru;
            Laporan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Laporan_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Laporan_btn.ForeColor = SystemColors.ControlLightLight;
            Laporan_btn.Location = new Point(-3, 227);
            Laporan_btn.Name = "Laporan_btn";
            Laporan_btn.Size = new Size(253, 40);
            Laporan_btn.TabIndex = 14;
            Laporan_btn.Text = "Laporan";
            Laporan_btn.UseVisualStyleBackColor = false;
            // 
            // Pesanan_btn
            // 
            Pesanan_btn.BackColor = Color.Peru;
            Pesanan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Pesanan_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pesanan_btn.ForeColor = SystemColors.ControlLightLight;
            Pesanan_btn.Location = new Point(-3, 189);
            Pesanan_btn.Name = "Pesanan_btn";
            Pesanan_btn.Size = new Size(253, 40);
            Pesanan_btn.TabIndex = 13;
            Pesanan_btn.Text = "Pesanan";
            Pesanan_btn.UseVisualStyleBackColor = false;
            // 
            // Daftar_pelanggan_btn
            // 
            Daftar_pelanggan_btn.BackColor = Color.Peru;
            Daftar_pelanggan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Daftar_pelanggan_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Daftar_pelanggan_btn.ForeColor = SystemColors.ControlLightLight;
            Daftar_pelanggan_btn.Location = new Point(-3, 155);
            Daftar_pelanggan_btn.Name = "Daftar_pelanggan_btn";
            Daftar_pelanggan_btn.Size = new Size(253, 40);
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
            Data_btn.Location = new Point(-3, 117);
            Data_btn.Name = "Data_btn";
            Data_btn.Size = new Size(253, 40);
            Data_btn.TabIndex = 10;
            Data_btn.Text = "Data Biji Kopi";
            Data_btn.UseVisualStyleBackColor = false;
            // 
            // Dashboard_btn
            // 
            Dashboard_btn.BackColor = Color.Peru;
            Dashboard_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Dashboard_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard_btn.ForeColor = SystemColors.ControlLightLight;
            Dashboard_btn.Location = new Point(-3, 83);
            Dashboard_btn.Name = "Dashboard_btn";
            Dashboard_btn.Size = new Size(253, 40);
            Dashboard_btn.TabIndex = 9;
            Dashboard_btn.Text = "Dashboard";
            Dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // Pesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(status_btn);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Pesanan";
            Text = "Pesanan";
            status_btn.ResumeLayout(false);
            status_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel status_btn;
        private Button button1;
        private DataGridView dataGridView1;
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