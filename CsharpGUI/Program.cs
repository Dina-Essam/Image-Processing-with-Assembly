using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpGUI
{
    static class Program
    {
        [DllImport("Project.dll")]
        private static extern int Sum(int y, int b);

        [DllImport("Project.dll")]
        private static extern int SumArr([In] int[] arr, int sz);

        [DllImport("Project.dll")]
        private static extern void ToUpper([In, Out]char[] arr, int sz);
        [DllImport("Project.dll")]
        private static extern void ImageToGray([In, Out]int[] _image, int _size);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
