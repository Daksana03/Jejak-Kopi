using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class Data_Biji_Kopi : Form
    {
        public Data_Biji_Kopi(string adminName)
        {
            InitializeComponent();
            label2.Text = adminName;
            label4.Text = adminName;
        }
    }
}
