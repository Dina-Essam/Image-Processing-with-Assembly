using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpGUI
{
    public partial class Form1 : Form
    {
        int[,] arrPic;
        int[,] arrPic2;
        int width, height;
        Bitmap Pic;
        public Form1()
        {
            InitializeComponent();
        }

        public static Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src, 0, 0);
            }

            return newBmp;
        }

        private void BrightnessValue_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    arrPic[i, j] = arrPic2[i, j];
                }
            }
            Pic = (System.Drawing.Bitmap)Picture.Image;
            label2.Text = BrightnessValue.Value.ToString();
            Program.Brightness(arrPic, width, height, BrightnessValue.Value);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Pic.SetPixel(i, j, (Color.FromArgb(arrPic[i, j])));
                }
            }
            Picture.Image = Pic;
        }

        private void GreyScale_Click(object sender, EventArgs e)
        {
            Pic = (System.Drawing.Bitmap)Picture.Image;
            Program.GreyScale(arrPic,width,height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Pic.SetPixel(i, j, (Color.FromArgb(arrPic[i, j])));
                }
            }
            Picture.Image = Pic;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    arrPic2[i, j] = arrPic[i, j];
                }
            }
        }

        private void INVERT_Click(object sender, EventArgs e)
        {
            Pic = (System.Drawing.Bitmap)Picture.Image;
            Program.INVERT(arrPic, width, height);
            Pic = CreateNonIndexedImage(Picture.Image);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Pic.SetPixel(i, j, (Color.FromArgb(arrPic[i, j])));
                }
            }
            Picture.Image = Pic;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    arrPic2[i, j] = arrPic[i, j];
                }
            }
        }

        private void anding_Click(object sender, EventArgs e)
        {
            Pic = (System.Drawing.Bitmap)Picture.Image;
            OpenFileDialog folderDlg = new OpenFileDialog();
            folderDlg.Filter = "Image File (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png";
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap oldPic = new Bitmap(folderDlg.FileName);
                width = oldPic.Width;
                height = oldPic.Height;
               int [,] anding = new int[width, height];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        anding[i, j] = oldPic.GetPixel(i, j).ToArgb();
                    }
                }
                Program.ANDING(arrPic,anding,width,height);
                Pic = CreateNonIndexedImage(Picture.Image);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Pic.SetPixel(i, j, (Color.FromArgb(arrPic[i, j])));
                    }
                }
                Picture.Image = Pic;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        arrPic2[i, j] = arrPic[i, j];
                    }
                }

            }
        }

        private void oring_Click(object sender, EventArgs e)
        {
            Pic = (System.Drawing.Bitmap)Picture.Image;
            OpenFileDialog folderDlg = new OpenFileDialog();
            folderDlg.Filter = "Image File (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png";
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap oldPic = new Bitmap(folderDlg.FileName);
                width = oldPic.Width;
                height = oldPic.Height;
                int[,] anding = new int[width, height];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        anding[i, j] = oldPic.GetPixel(i, j).ToArgb();
                    }
                }
                Program.ORING(arrPic, anding, width, height);
                Pic = CreateNonIndexedImage(Picture.Image);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Pic.SetPixel(i, j, (Color.FromArgb(arrPic[i, j])));
                    }
                }
                Picture.Image = Pic;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        arrPic2[i, j] = arrPic[i, j];
                    }
                }

            }
        }

        private void adding_Click(object sender, EventArgs e)
        {
            Pic = (System.Drawing.Bitmap)Picture.Image;
            OpenFileDialog folderDlg = new OpenFileDialog();
            folderDlg.Filter = "Image File (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png";
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap oldPic = new Bitmap(folderDlg.FileName);
                width = oldPic.Width;
                height = oldPic.Height;
                int[,] anding = new int[width, height];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        anding[i, j] = oldPic.GetPixel(i, j).ToArgb();
                    }
                }
                int [,] temp=new int[width, height];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        temp[i, j] = anding[i,j];
                    }
                }

                Program.INVERT(anding, width, height);
                Program.ANDING(anding,arrPic, width, height);
                Program.ImageAddition(anding,temp,width, height);

                Pic = CreateNonIndexedImage(Picture.Image);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Pic.SetPixel(i, j, (Color.FromArgb(anding[i, j])));
                    }
                }
                Picture.Image = Pic;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        arrPic2[i, j] = anding[i, j];
                    }
                }


            }
        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderDlg = new OpenFileDialog();
            folderDlg.Filter = "Image File (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png";
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                this.Picture.Image = new Bitmap(folderDlg.FileName);
                Picture.SizeMode = PictureBoxSizeMode.StretchImage;
                width = this.Picture.Image.Width;
                height = this.Picture.Image.Height;
                arrPic = new int[width, height];
                arrPic2 = new int[width, height];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        arrPic[i, j] = ((System.Drawing.Bitmap)Picture.Image).GetPixel(i, j).ToArgb();
                    }
                }
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        arrPic2[i, j] = arrPic[i, j];
                    }
                }
            }
        }




    }
}
