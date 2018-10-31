using System.Windows.Forms;

namespace imageProcessing
{
    partial class imageProcessing
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog_LoadImage = new System.Windows.Forms.OpenFileDialog();
            this.loadLmAgeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SourceImage = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageEnd = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.button5 = new System.Windows.Forms.Button();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "加载图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(680, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Processing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // openFileDialog_LoadImage
            // 
            this.openFileDialog_LoadImage.FileName = "openFileDialog1";
            // 
            // loadLmAgeLabel
            // 
            this.loadLmAgeLabel.AutoSize = true;
            this.loadLmAgeLabel.Location = new System.Drawing.Point(313, 148);
            this.loadLmAgeLabel.Name = "loadLmAgeLabel";
            this.loadLmAgeLabel.Size = new System.Drawing.Size(37, 15);
            this.loadLmAgeLabel.TabIndex = 7;
            this.loadLmAgeLabel.Text = "原图";
            this.loadLmAgeLabel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 700);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "图像灰度化";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 1287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "中值滤波";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 1864);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "图像二值化:Otsu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SourceImage
            // 
            this.SourceImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.SourceImage.Location = new System.Drawing.Point(111, 166);
            this.SourceImage.Name = "SourceImage";
            this.SourceImage.Size = new System.Drawing.Size(500, 500);
            this.SourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SourceImage.TabIndex = 2;
            this.SourceImage.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox1.Location = new System.Drawing.Point(111, 755);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 14;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox2.Location = new System.Drawing.Point(111, 1342);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(500, 500);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 15;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox3.Location = new System.Drawing.Point(111, 1918);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(500, 500);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox3.TabIndex = 16;
            this.imageBox3.TabStop = false;
            // 
            // imageEnd
            // 
            this.imageEnd.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageEnd.Location = new System.Drawing.Point(105, 4049);
            this.imageEnd.Name = "imageEnd";
            this.imageEnd.Size = new System.Drawing.Size(500, 500);
            this.imageEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageEnd.TabIndex = 17;
            this.imageEnd.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox4.Location = new System.Drawing.Point(111, 2495);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(500, 500);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox4.TabIndex = 18;
            this.imageBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 2442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 30);
            this.button5.TabIndex = 19;
            this.button5.Text = "空洞填充（暂时不做）";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // imageBox5
            // 
            this.imageBox5.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox5.Location = new System.Drawing.Point(111, 3076);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(500, 500);
            this.imageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox5.TabIndex = 20;
            this.imageBox5.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(111, 3021);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 30);
            this.button6.TabIndex = 21;
            this.button6.Text = "形态学开闭处理";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 1295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "孔径线性尺寸:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 1295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "必须是奇数！";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 1291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 25);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "1";
            // 
            // imageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1419, 659);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.imageBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageEnd);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.SourceImage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadLmAgeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "imageProcessing";
            this.Text = "Image Processing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.imageProcessing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private OpenFileDialog openFileDialog_LoadImage;
        private Label loadLmAgeLabel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Emgu.CV.UI.ImageBox SourceImage;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageEnd;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Button button5;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Button button6;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}

