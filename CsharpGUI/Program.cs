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
        public static extern void GreyScale([In, Out]int[,] arr, int w, int h);

        [DllImport("Project.dll")]
        public static extern void Brightness([In, Out]int[,] arr, int w, int h, int val);

        [DllImport("Project.dll")]
        public static extern void ImageAddition([In, Out]int[,] arr, [In, Out]int[,] arr2, int w, int h);
        [DllImport("Project.dll")]
        public static extern void INVERT([In, Out]int[,] arr, int w, int h);
        [DllImport("Project.dll")]
        public static extern void ANDING([In, Out]int[,] arr, [In, Out]int[,] arr2, int w, int h);
        [DllImport("Project.dll")]
        public static extern void ORING([In, Out]int[,] arr, [In, Out]int[,] arr2, int w, int h);


        [DllImport("Project.dll")]
        private static extern int Sum(int y, int b);

        [DllImport("Project.dll")]
        private static extern int SumArr([In] int[] arr, int sz);

        [DllImport("Project.dll")]
        private static extern void ToUpper([In, Out]char[] arr, int sz);
      
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
