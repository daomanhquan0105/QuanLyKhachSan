using QuanLyKhachSan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Controller;
using QuanLyKhachSan.View;

namespace QuanLyKhachSan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FormPhongThue());
=======
            Application.Run(new FormThanhToan());
>>>>>>> 5459730363560f228cd7c5a58863e41cf0dfe272
        }
    }
}
