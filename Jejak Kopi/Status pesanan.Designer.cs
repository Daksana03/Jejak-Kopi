namespace Jejak_Kopi
{
    partial class Status_pesanan
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
            label3 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 25);
            label3.Name = "label3";
            label3.Size = new Size(200, 34);
            label3.TabIndex = 12;
            label3.Text = "Status Pesanan:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(129, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(288, 162);
            button1.Name = "button1";
            button1.Size = new Size(111, 40);
            button1.TabIndex = 17;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Status_pesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(411, 214);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Name = "Status_pesanan";
            Text = "Status_pesanan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBox2;
        private Button button1;
    }
}