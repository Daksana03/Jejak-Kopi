// GlobalCloseHandler.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public static class GlobalCloseHandler
    {
        private static bool _isInitialized = false;
        private static bool _isClosing = false;

        public static void EnableGlobalCloseForAllForms()
        {
            if (_isInitialized) return;
            _isInitialized = true;

            // Memasang hook ke form yang sudah ada saat inisialisasi awal
            Application.OpenForms.Cast<Form>().ToList().ForEach(HookForm);

            // Memasang hook secara dinamis ke form-form baru yang dibuka kemudian
            Application.Idle += OnApplicationIdle;
        }

        private static void OnApplicationIdle(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (!IsFormHooked(form))
                {
                    HookForm(form);
                }
            }
        }

        private static void HookForm(Form form)
        {
            if (form.Tag?.ToString() == "GlobalHooked") return;

            form.FormClosing += OnFormClosing;
            form.Tag = "GlobalHooked"; // Menandai bahwa form sudah dipasang penangan close
        }

        private static bool IsFormHooked(Form form)
        {
            return form.Tag?.ToString() == "GlobalHooked";
        }

        private static void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing) return;

            // Hanya bertindak jika aksi penutupan dipicu langsung oleh tombol 'X' Windows oleh User
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form formYangDitutup = sender as Form;

                // Menghitung berapa banyak form yang SAAT INI sedang tampil/terbuka di layar, 
                // di luar form yang saat ini sedang dalam proses menutup.
                int formTerbukaLainnya = Application.OpenForms.Cast<Form>()
                    .Count(f => f.Visible && f != formYangDitutup);

                // JIKA tidak ada form lain yang sedang tampil (ini adalah form aktif terakhir),
                // MAKA bersihkan memori dan tutup seluruh aplikasi secara aman.
                if (formTerbukaLainnya == 0)
                {
                    e.Cancel = true;
                    CloseAllForms();
                }
                // JIKA masih ada form lain yang terbuka (misal perpindahan form via navigasi .Show() dan .Hide()), 
                // biarkan form tersebut menutup sendiri tanpa memicu penutupan masal.
            }
        }

        private static void CloseAllForms()
        {
            _isClosing = true;

            var forms = Application.OpenForms.Cast<Form>().ToList();
            foreach (var form in forms)
            {
                if (!form.IsDisposed)
                {
                    form.FormClosing -= OnFormClosing; // Mencegah terjadinya rekursi/perulangan tak terbatas
                    form.Close();
                }
            }

            _isClosing = false;

            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}