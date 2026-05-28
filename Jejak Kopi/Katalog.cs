using System;
using System.Collections.Generic;
using System.Text;

namespace Jejak_Kopi
{
    public class KatalogUser
    {
        public string nama { get; set; }
        public int stok { get; set; }
        public int harga { get; set; }
        public string jenis { get; set; }

        public KatalogUser(string nama, int stok, int harga, string jenis) 
        {
            this.nama = nama;
            this.stok = stok;
            this.harga = harga;
            this.jenis = jenis;
        }
    }
}
