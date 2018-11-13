using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageProcessing
{
    public partial class testForm : Form
    {
        Image<Bgr, Byte> sourseImage = null;            //原图  

        public testForm()
        {
            InitializeComponent();
            openFileDialog_LoadImage.Filter = "Bmp files (*.bmp)|*.bmp";
            openFileDialog_LoadImage.FilterIndex = 1;
            openFileDialog_LoadImage.RestoreDirectory = true;
        }
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog_LoadImage.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog_LoadImage.FileName;
                sourseImage = new Image<Bgr, Byte>(openFileDialog_LoadImage.FileName);
                SourceImage.Image = sourseImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
               // imgForm curWid = (imgForm)this.ActiveMdiChild;
               // Image<Emgu.CV.Structure.Bgr, byte> img = curWid.CurImage;
                Image<Gray, byte> gray = sourseImage.Convert<Gray, byte>();
                CvInvoke.Canny(gray, gray, 100, 200, 3);
                for (int i = 0; i < gray.Height; i++)
                {
                    for (int j = 0; j < gray.Width; j++)
                    {
                        gray.Data[i, j, 0] = Convert.ToByte(255 - gray.Data[i, j, 0]);
                    }
                }
                //(IInputArray src, IOutputArray dst, IOutputArray labels, DistType distanceType, int maskSize, DistLabelType labelType = DistLabelType.CComp);
                Image<Gray, byte> result = new Image<Gray, byte>(gray.Width, gray.Height);
                CvInvoke.DistanceTransform(gray, result, null,Emgu.CV.CvEnum.DistType.L1, 3, Emgu.CV.CvEnum.DistLabelType.CComp);
                // CvInvoke.cvShowImage("Test", result);
                //CvInvoke.cvShowImage("binary", gray);
                imageBox1.Image = result;
                   
        }
    }
}
