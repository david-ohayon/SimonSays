using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SimonSays
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameStart());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        // Helpers
        public static void OpenForm(Form form, Form new_form)
        {
            form.Hide();
            new_form.Show();
        }
        public static void AddFontFile(string fontname, params Control[] controls)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile($@"..\..\Resources\{fontname}.ttf");
            foreach (Control control in controls)
                control.Font = new Font(pfc.Families[0], control.Font.Size);
            //for (int i = 0; i < controls.Length; i++)
              //  controls[i].Font = new Font(pfc.Families[0], controls[i].Font.Size);
        }
    }
}
