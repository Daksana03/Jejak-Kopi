using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class FormUtama : Form
    {
        public string data; //Sementara jadi public. Harusnya ini jadi id dari usernya dan private(?)
        //public Dashboard_User FormUser; 
        //public Katalog_Kopi_User FormKatalogUser; 
        public FormUtama(string data)
        {
            InitializeComponent();
            //panel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance |
            //    System.Reflection.BindingFlags.NonPublic)?.SetValue(panel1, true, null); // Double buffered
            this.data = data;
            //FormUser = new Dashboard_User(data, this);
            //FormKatalogUser = new Katalog_Kopi_User(this, data);
            BukaPanel(new Dashboard_User(data, this));
            //BukaPanel(FormUser);
        }

        public void BukaPanel(Form formAnak)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls[0].Dispose();
                this.panel1.Controls.Clear();
            }

            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(formAnak);
            this.panel1.Tag = formAnak;
            formAnak.Show();
        }
    }
}
