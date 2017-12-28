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
        private static extern void ImageAddition([In, Out]int[,] arr, [In, Out]int[,] arr2, int w, int h);
        [DllImport("Project.dll")]
        private static extern void INVERT([In, Out]int[,] arr, int w, int h);
        [DllImport("Project.dll")]
        private static extern void ANDING([In, Out]int[,] arr, [In, Out]int[,] arr2, int w, int h);
        [DllImport("Project.dll")]
        private static extern void ORING([In, Out]int[,] arr, [In, Out]int[,] arr2, int w, int h);
        [DllImport("Project.dll")]
        private static extern int Sum(int y, int b);

        [DllImport("Project.dll")]
        private static extern int SumArr([In] int[] arr, int sz);

        [DllImport("Project.dll")]
        private static extern void ToUpper([In, Out]char[] arr, int sz);

        public static Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src, 0, 0);
            }

            return newBmp;
        }

        static void Main(string[] args)
        {

            Bitmap oldPic = null;
            oldPic = new Bitmap("..\\IN\\21.png");            
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
            
             Bitmap oldPic2 = new Bitmap("..\\IN\\21.png");
             //width = oldPic2.Width;
             //height = oldPic2.Height;
            int[,] arrPic2 = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    arrPic2[i, j] = oldPic2.GetPixel(i, j).ToArgb();
                }
            }

            Bitmap oldPic3 = new Bitmap("..\\IN\\22.png");
            //width = oldPic2.Width;
            //height = oldPic2.Height;
            int[,] arrPic3 = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    arrPic3[i, j] = oldPic3.GetPixel(i, j).ToArgb();
                }
            }


            /////do your asm stuff here on arrPic

            INVERT(arrPic2,width,height);
            ANDING(arrPic2, arrPic, width, height);
            ImageAddition(arrPic2, arrPic3, width, height);

            /////


           Image newImage = Image.FromFile(("..\\IN\\21.png"));
           oldPic =CreateNonIndexedImage(newImage);
            for (int i = 0; i < oldPic.Width; i++)
            {
                for (int j = 0; j < oldPic.Height; j++)
                {
                   oldPic.SetPixel(i,j,( Color.FromArgb(arrPic2[i,j])) );
                }
            }
            oldPic.Save("..\\OUT\\hh.png");




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
