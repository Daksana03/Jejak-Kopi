namespace Jejak_Kopi
{
    partial class Tambah_Kopi
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
            label5 = new Label();
            nama_kopi = new TextBox();
            stok = new TextBox();
            label4 = new Label();
            harga = new TextBox();
            label2 = new Label();
            label3 = new Label();
            kategori = new TextBox();
            tambah_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 139);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 27;
            label5.Text = "Nama Kopi";
            // 
            // nama_kopi
            // 
            nama_kopi.Location = new Point(149, 135);
            nama_kopi.Name = "nama_kopi";
            nama_kopi.Size = new Size(262, 27);
            nama_kopi.TabIndex = 26;
            // 
            // stok
            // 
            stok.Location = new Point(149, 222);
            stok.Name = "stok";
            stok.Size = new Size(262, 27);
            stok.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Bisque;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 226);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 24;
            label4.Text = "Stok";
            // 
            // harga
            // 
            harga.Location = new Point(149, 178);
            harga.Name = "harga";
            harga.Size = new Size(262, 27);
            harga.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 182);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 22;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 97);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 21;
            label3.Text = "Kategori Kopi";
            // 
            // kategori
            // 
            kategori.Location = new Point(149, 93);
            kategori.Name = "kategori";
            kategori.Size = new Size(262, 27);
            kategori.TabIndex = 20;
            // 
            // tambah_btn
            // 
            tambah_btn.Location = new Point(317, 305);
            tambah_btn.Name = "tambah_btn";
            tambah_btn.Size = new Size(94, 29);
            tambah_btn.TabIndex = 18;
            tambah_btn.Text = "Tambah";
            tambah_btn.UseVisualStyleBackColor = true;
            tambah_btn.Click += tambah_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 27);
            label1.Name = "label1";
            label1.Size = new Size(296, 34);
            label1.TabIndex = 17;
            label1.Text = "Penambahan Stok Kopi";
            // 
            // Tambah_Kopi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(446, 361);
            Controls.Add(label5);
            Controls.Add(nama_kopi);
            Controls.Add(stok);
            Controls.Add(label4);
            Controls.Add(harga);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(kategori);
            Controls.Add(tambah_btn);
            Controls.Add(label1);
            Name = "Tambah_Kopi";
            Text = "Tambah_Kopi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox nama_kopi;
        private TextBox stok;
        private Label label4;
        private TextBox harga;
        private Label label2;
        private Label label3;
        private TextBox kategori;
        private Button tambah_btn;
        private Label label1;
    }
}