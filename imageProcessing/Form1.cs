using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace imageProcessing
{
    public partial class imageProcessing : Form
    {
        //定义每个步骤处理后的结果
        Image<Bgr, Byte> sourseImage = null;            //原图    
        Image<Gray, Byte> grayImage = null;             //灰度化
        Image<Gray, Byte> filterImage = null;            //滤波(单通道黑白图片)
        Image<Gray, Byte> thresholdingImage = null;      //二值化
        Image<Gray, Byte> kdtcImage = null;              //空洞填充
        Image<Gray, Byte>  xtxlpImage =null;             //形态学滤波



        private void imageProcessing_Load(object sender, EventArgs e)
        {

        }     
        public imageProcessing()
        {
            InitializeComponent();
            openFileDialog_LoadImage.Filter = "Bmp files (*.bmp)|*.bmp";
            openFileDialog_LoadImage.FilterIndex = 1;
            openFileDialog_LoadImage.RestoreDirectory = true;
        }

        
        /// <summary>
        /// 加载图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog_LoadImage.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog_LoadImage.FileName;
                loadLmAgeLabel.Visible = true;
                sourseImage= new Image<Bgr, Byte>(openFileDialog_LoadImage.FileName);
                SourceImage.Image = sourseImage;
            }
        }

        

        /// <summary>
        /// 灰度化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(sourseImage !=null)
            {
                grayImage = sourseImage.Convert<Gray, byte>();
                imageBox1.Image = grayImage;
            }
            else
            {
                MessageBox.Show("请先加载图片");
            }
        }


        /// <summary>
        /// 滤波
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            if (grayImage != null&& textBox1.Text!=null)
            {
                string result = System.Text.RegularExpressions.Regex.Replace(textBox1.Text, @"[^0-9]+", "");
                if(result=="")
                {
                    MessageBox.Show("请填写数字！");
                }
                else
                {
                    int temp = 1;
                    int.TryParse(result, out temp);
                    if(temp%2!=0)

                    {
                        filterImage = grayImage.SmoothMedian(temp);
                        imageBox2.Image = filterImage;
                    }
                    else
                    {
                        MessageBox.Show("请输入奇数！");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("请先完成上一步或填写数据！");
            }
        }


        /// <summary>
        /// 二值化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (filterImage != null)
            {
                thresholdingImage = filterImage.CopyBlank();
                CvInvoke.Threshold(filterImage, thresholdingImage, 0,255, ThresholdType.Otsu);//中间几个参数的意思没搞清楚，其影响也不知道。
                imageBox3.Image = thresholdingImage;
            }
            else
            {
                MessageBox.Show("请先完成上一步！");
            }
        }

        /// <summary>
        /// 空洞填充（暂时不做）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //if (thresholdingImage != null)
            //{
            //    imageBox4.Image = sourseImage;
            //}
            //else
            //{
            //    MessageBox.Show("请先完成上一步！");
            //}
        }

        /// <summary>
        /// 形态学滤波
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {            
            if (thresholdingImage != null)
            {
                
                xtxlpImage = thresholdingImage;          
                //定义一个结构元素：aaa这个参数十分重要
                Mat aaa = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(2, 2));
                //开运算
                xtxlpImage._MorphologyEx(MorphOp.Open, aaa, new Point(1, 1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0));              
                //闭运算
               xtxlpImage._MorphologyEx(MorphOp.Close, aaa, new Point(1, 1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0));
                imageBox5.Image = xtxlpImage;
            }
            else
            {
                MessageBox.Show("请先完成上一步！");
            }


        }
    }
}

