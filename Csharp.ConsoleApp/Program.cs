using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp.ConsoleApp
{
    class Program
    {
        [DllImport("Project.dll")]
        private static extern void GreyScale([In, Out]int[,] arr, int w, int h);
        [DllImport("Project.dll")]
        private static extern void Brightness([In, Out]int[,] arr, int w,int h,int val);

        [DllImport("Project.dll")]
        private static extern int Sum(int y, int b);

        [DllImport("Project.dll")]
        private static extern int SumArr([In] int[] arr, int sz);

        [DllImport("Project.dll")]
        private static extern void ToUpper([In, Out]char[] arr, int sz);

        static void Main(string[] args)
        {

            Bitmap oldPic = null;
            oldPic = new Bitmap("..\\IN\\4.jpg");

            
            int width = oldPic.Width;
            int height = oldPic.Height;
            int[,] arrPic = new int[width,height];

            for(int i = 0; i < width; i++)
            {
                for (int j =0; j < height; j++)
                {
                   
                    arrPic[i, j] = oldPic.GetPixel(i,j).ToArgb();
                }
            }

            /////do your asm stuff here on arrPic
            GreyScale(arrPic,width,height);
            /////

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                   oldPic.SetPixel(i,j,( Color.FromArgb(arrPic[i,j])) );
                }
            }
            oldPic.Save("..\\OUT\\heeh.jpg");




            int[] x = { 1, 20, 3 };
            char[] c = "How are u?".ToCharArray();

            //test SumArr procedure
            Console.Write(SumArr(x, x.Length));
            Console.WriteLine();

            //test ToUpper procedure
            Console.Write(c, 0, c.Length);
            Console.WriteLine();

            ToUpper(c, c.Length);
            Console.Write(c, 0, c.Length);
            Console.WriteLine();
        }
    }
}
