namespace Jejak_Kopi
{
    partial class Keranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keranjang));
            panel2 = new Panel();
            button1 = new Button();
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
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(250, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 396);
            panel2.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(424, 351);
            button1.Name = "button1";
            button1.Size = new Size(112, 40);
            button1.TabIndex = 16;
            button1.Text = "Check Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 24);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(514, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 17);
            label1.Name = "label1";
            label1.Size = new Size(138, 34);
            label1.TabIndex = 26;
            label1.Text = "Keranjang";
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
            panel1.Location = new Point(1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 459);
            panel1.TabIndex = 27;
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
            Logout_btn.Location = new Point(-3, 403);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(253, 56);
            Logout_btn.TabIndex = 15;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            // 
            // Riwayat_btn
            // 
            Riwayat_btn.BackColor = Color.Peru;
            Riwayat_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Riwayat_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Riwayat_btn.ForeColor = SystemColors.ControlLightLight;
            Riwayat_btn.Location = new Point(-3, 189);
            Riwayat_btn.Name = "Riwayat_btn";
            Riwayat_btn.Size = new Size(253, 40);
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
            Keranjang_btn.Location = new Point(-3, 155);
            Keranjang_btn.Name = "Keranjang_btn";
            Keranjang_btn.Size = new Size(253, 40);
            Keranjang_btn.TabIndex = 11;
            Keranjang_btn.Text = "Keranjang";
            Keranjang_btn.UseVisualStyleBackColor = false;
            // 
            // Katalog_btn
            // 
            Katalog_btn.BackColor = Color.Peru;
            Katalog_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Katalog_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Katalog_btn.ForeColor = SystemColors.ControlLightLight;
            Katalog_btn.Location = new Point(-3, 117);
            Katalog_btn.Name = "Katalog_btn";
            Katalog_btn.Size = new Size(253, 40);
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
            Dashboard_btn.Location = new Point(-3, 83);
            Dashboard_btn.Name = "Dashboard_btn";
            Dashboard_btn.Size = new Size(253, 40);
            Dashboard_btn.TabIndex = 9;
            Dashboard_btn.Text = "Dashboard";
            Dashboard_btn.UseVisualStyleBackColor = false;
            Dashboard_btn.Click += Dashboard_btn_Click;
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Keranjang";
            Text = "Keranjang";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button1;
        private DataGridView dataGridView1;
    }
}