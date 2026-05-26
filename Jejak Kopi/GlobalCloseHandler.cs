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

            // Hook into existing and future forms
            Application.OpenForms.Cast<Form>().ToList().ForEach(HookForm);

            // Hook into forms that will be created later
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
            form.Tag = "GlobalHooked"; // Mark as hooked
        }

        private static bool IsFormHooked(Form form)
        {
            return form.Tag?.ToString() == "GlobalHooked";
        }

        private static void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing) return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                CloseAllForms();
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
                    form.FormClosing -= OnFormClosing; // Prevent recursion
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