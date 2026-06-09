namespace Jejak_Kopi
{
    partial class Katalog_Kopi_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Katalog_Kopi_User));
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            textBox1 = new TextBox();
            tambah_btn = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Logout_btn = new Button();
            Riwayat_btn = new Button();
            Keranjang_btn = new Button();
            Katalog_btn = new Button();
            Dashboard_btn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label2.TabIndex = 19;
            label2.Text = "Lorem Ipsum";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(tambah_btn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(219, 51);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 287);
            panel2.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 232);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 23;
            label5.Text = "Jumlah (Qty)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // tambah_btn
            // 
            tambah_btn.BackColor = Color.Peru;
            tambah_btn.BackgroundImageLayout = ImageLayout.Stretch;
            tambah_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tambah_btn.ForeColor = SystemColors.ControlLightLight;
            tambah_btn.Location = new Point(334, 242);
            tambah_btn.Margin = new Padding(3, 2, 3, 2);
            tambah_btn.Name = "tambah_btn";
            tambah_btn.Size = new Size(122, 36);
            tambah_btn.TabIndex = 16;
            tambah_btn.Text = "Tambah ke Keranjang";
            tambah_btn.UseVisualStyleBackColor = false;
            tambah_btn.Click += tambah_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 12);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 21;
            label3.Text = "Katalog Kopi:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 34);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(426, 193);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 13);
            label1.Name = "label1";
            label1.Size = new Size(163, 27);
            label1.TabIndex = 17;
            label1.Text = "Selamat Datang";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Logout_btn);
            panel1.Controls.Add(Riwayat_btn);
            panel1.Controls.Add(Keranjang_btn);
            panel1.Controls.Add(Katalog_btn);
            panel1.Controls.Add(Dashboard_btn);
            panel1.Location = new Point(1, -3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 341);
            panel1.TabIndex = 18;
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
            Logout_btn.Location = new Point(-3, 302);
            Logout_btn.Margin = new Padding(3, 2, 3, 2);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(221, 42);
            Logout_btn.TabIndex = 15;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // Riwayat_btn
            // 
            Riwayat_btn.BackColor = Color.Peru;
            Riwayat_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Riwayat_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Riwayat_btn.ForeColor = SystemColors.ControlLightLight;
            Riwayat_btn.Location = new Point(-3, 142);
            Riwayat_btn.Margin = new Padding(3, 2, 3, 2);
            Riwayat_btn.Name = "Riwayat_btn";
            Riwayat_btn.Size = new Size(221, 30);
            Riwayat_btn.TabIndex = 12;
            Riwayat_btn.Text = "Riwayat Transaksi";
            Riwayat_btn.UseVisualStyleBackColor = false;
            Riwayat_btn.Click += Riwayat_btn_Click;
            // 
            // Keranjang_btn
            // 
            Keranjang_btn.BackColor = Color.Peru;
            Keranjang_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Keranjang_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Keranjang_btn.ForeColor = SystemColors.ControlLightLight;
            Keranjang_btn.Location = new Point(-3, 116);
            Keranjang_btn.Margin = new Padding(3, 2, 3, 2);
            Keranjang_btn.Name = "Keranjang_btn";
            Keranjang_btn.Size = new Size(221, 30);
            Keranjang_btn.TabIndex = 11;
            Keranjang_btn.Text = "Keranjang";
            Keranjang_btn.UseVisualStyleBackColor = false;
            Keranjang_btn.Click += Keranjang_btn_Click;
            // 
            // Katalog_btn
            // 
            Katalog_btn.BackColor = Color.Peru;
            Katalog_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Katalog_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Katalog_btn.ForeColor = SystemColors.ControlLightLight;
            Katalog_btn.Location = new Point(-3, 88);
            Katalog_btn.Margin = new Padding(3, 2, 3, 2);
            Katalog_btn.Name = "Katalog_btn";
            Katalog_btn.Size = new Size(221, 30);
            Katalog_btn.TabIndex = 10;
            Katalog_btn.Text = "Katalog Kopi";
            Katalog_btn.UseVisualStyleBackColor = false;
            Katalog_btn.Click += Katalog_btn_Click;
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
            // Katalog_Kopi_User
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
            Name = "Katalog_Kopi_User";
            Text = "Katalog_Kopi_User";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Button Logout_btn;
        private Button Riwayat_btn;
        private Button Keranjang_btn;
        private Button Katalog_btn;
        private Button Dashboard_btn;
        private DataGridView dataGridView1;
        private Button tambah_btn;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
    }
}