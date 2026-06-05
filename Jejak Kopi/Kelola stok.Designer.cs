namespace Jejak_Kopi
{
    partial class Kelola_stok
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
            edit_btn = new Button();
            kategori = new TextBox();
            label3 = new Label();
            label2 = new Label();
            harga = new TextBox();
            stok = new TextBox();
            label4 = new Label();
            label5 = new Label();
            nama_kopi = new TextBox();
            hapus_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 21);
            label1.Name = "label1";
            label1.Size = new Size(286, 34);
            label1.TabIndex = 6;
            label1.Text = "Pengelolaan Stok Kopi";
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(311, 298);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(94, 29);
            edit_btn.TabIndex = 8;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click_1;
            // 
            // kategori
            // 
            kategori.Location = new Point(143, 87);
            kategori.Name = "kategori";
            kategori.Size = new Size(262, 27);
            kategori.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 91);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 10;
            label3.Text = "Kategori Kopi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 176);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 11;
            label2.Text = "Harga";
            // 
            // harga
            // 
            harga.Location = new Point(143, 172);
            harga.Name = "harga";
            harga.Size = new Size(262, 27);
            harga.TabIndex = 12;
            // 
            // stok
            // 
            stok.Location = new Point(143, 216);
            stok.Name = "stok";
            stok.Size = new Size(262, 27);
            stok.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PeachPuff;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 220);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 13;
            label4.Text = "Stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 133);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 16;
            label5.Text = "Nama Kopi";
            // 
            // nama_kopi
            // 
            nama_kopi.Location = new Point(143, 129);
            nama_kopi.Name = "nama_kopi";
            nama_kopi.Size = new Size(262, 27);
            nama_kopi.TabIndex = 15;
            // 
            // hapus_btn
            // 
            hapus_btn.Location = new Point(197, 298);
            hapus_btn.Name = "hapus_btn";
            hapus_btn.Size = new Size(94, 29);
            hapus_btn.TabIndex = 17;
            hapus_btn.Text = "Hapus";
            hapus_btn.UseVisualStyleBackColor = true;
            hapus_btn.Click += hapus_btn_Click;
            // 
            // Kelola_stok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(438, 349);
            Controls.Add(hapus_btn);
            Controls.Add(label5);
            Controls.Add(nama_kopi);
            Controls.Add(stok);
            Controls.Add(label4);
            Controls.Add(harga);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(kategori);
            Controls.Add(edit_btn);
            Controls.Add(label1);
            Name = "Kelola_stok";
            Text = "Kelola_stok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button edit_btn;
        private TextBox kategori;
        private Label label3;
        private Label label2;
        private TextBox harga;
        private TextBox stok;
        private Label label4;
        private Label label5;
        private TextBox nama_kopi;
        private Button hapus_btn;
    }
}