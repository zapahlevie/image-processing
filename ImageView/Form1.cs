using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox3.Image = Image.FromFile(ofd.FileName);
                pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox10.Image = Image.FromFile(ofd.FileName);
                pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox11.Image = Image.FromFile(ofd.FileName);
                pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox13.Image = Image.FromFile(ofd.FileName);
                pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox15.Image = Image.FromFile(ofd.FileName);
                pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox16.Image = Image.FromFile(ofd.FileName);
                pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox18.Image = Image.FromFile(ofd.FileName);
                pictureBox23.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox23.Image = Image.FromFile(ofd.FileName);
                pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox24.Image = Image.FromFile(ofd.FileName);
                pictureBox26.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox26.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, number3;
            Int32.TryParse(RedText.Text, out number1);
            Int32.TryParse(GreenText.Text, out number2);
            Int32.TryParse(BlueText.Text, out number3);
            Bitmap bitCampur = new Bitmap(100, 100);
            Color campur = Color.FromArgb(number1, number2, number3);

            for (int y = 0; y < 100; y++)
            {
                for (int x = 0; x < 100; x++)
                {
                    bitCampur.SetPixel(x, y, campur);
                }
            }
            
            MixBox.Image = new Bitmap(bitCampur.Height, bitCampur.Width);
            MixBox.Image = bitCampur;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitRed = new Bitmap(100, 100);
            Bitmap bitGreen = new Bitmap(100, 100);
            Bitmap bitBlue = new Bitmap(100, 100);
            Color red = Color.FromArgb(255, 0, 0);
            Color green = Color.FromArgb(0, 255, 0);
            Color blue = Color.FromArgb(0, 0, 255);
            for (int y = 0; y < 100; y++)
            {
                for (int x = 0; x < 100; x++)
                {
                    bitRed.SetPixel(x, y, red);
                    bitGreen.SetPixel(x, y, green);
                    bitBlue.SetPixel(x, y, blue);
                }
            }
            RedBox.Image = new Bitmap(bitRed.Height, bitRed.Width);
            RedBox.Image = bitRed;
            GreenBox.Image = new Bitmap(bitGreen.Height, bitGreen.Width);
            GreenBox.Image = bitGreen;
            BlueBox.Image = new Bitmap(bitBlue.Height, bitBlue.Width);
            BlueBox.Image = bitBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox3.Image = Image.FromFile(ofd.FileName);
                pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox10.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number1, number2, number3;
            Int32.TryParse(RedText.Text, out number1);
            Int32.TryParse(GreenText.Text, out number2);
            Int32.TryParse(BlueText.Text, out number3);
            pictureBox2.BackColor = Color.FromArgb(number1, number2, number3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox2.Image;
            Color pixelColor;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    int rata = (int)(red + green + blue) / 3;
                    if (rata < 128) { rata = 0; } else { rata = 255; }
                    bmp1.SetPixel(x, y, Color.FromArgb(rata, rata, rata));
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = bmp1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox2.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            grayscale(bmp1);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = bmp1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox2.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pC = source.GetPixel(x, source.Height - y - 1);
                    bmp1.SetPixel(y, x, pC);
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = bmp1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox2.Image;
            Color pC;
            
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pC = source.GetPixel(x, source.Height - 1 - y);
                    bmp1.SetPixel(x, y, pC);
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = bmp1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox2.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            Color pixelColor;
            int k = 30;
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pixelColor = source.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    if ((red + k) <= 255) { red = red + k; };
                    if ((green + k) <= 255) { green = green + k; };
                    if ((blue + k) <= 255) { blue = blue + k; };
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = bmp1;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox2.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pC = source.GetPixel(source.Width - 1 - x, y);
                    bmp1.SetPixel(x, y, pC);
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = bmp1;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox2.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pC = source.GetPixel(source.Width - x - 1, source.Height - y - 1);
                    bmp1.SetPixel(x, y, pC);
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = bmp1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox3.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox3.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            int K = 16;
            int th = (int)256 / K;
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pC = source.GetPixel(x, y);
                    int red = pC.R;
                    int green = pC.G;
                    int blue = pC.B;
                    int rata = (int)(red + green + blue) / 3;
                    int kuantisasi = (int)(rata / th);
                    int result = (int)th * kuantisasi;
                    bmp1.SetPixel(x, y, Color.FromArgb(result, result, result));
                }
            }
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = bmp1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox3.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            int K = 4;
            int th = (int)256 / K;
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pC = source.GetPixel(x, y);
                    int red = pC.R;
                    int green = pC.G;
                    int blue = pC.B;
                    int rata = (int)(red + green + blue) / 3;
                    int kuantisasi = (int)(rata / th);
                    int result = (int)th * kuantisasi;
                    bmp1.SetPixel(x, y, Color.FromArgb(result, result, result));
                }
            }
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Image = bmp1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox3.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            int K = 2;
            int th = (int)256 / K;
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    pC = source.GetPixel(x, y);
                    int red = pC.R;
                    int green = pC.G;
                    int blue = pC.B;
                    int rata = (int)(red + green + blue) / 3;
                    int kuantisasi = (int)(rata / th);
                    int result = (int)th * kuantisasi;
                    bmp1.SetPixel(x, y, Color.FromArgb(result, result, result));
                }
            }
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.Image = bmp1;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox10.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            int K = int.Parse(textBox1.Text) * 10;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pC = source.GetPixel(x, y);
                    int red = pC.R;
                    int green = pC.G;
                    int blue = pC.B;
                    if (K > 0)
                    {
                        if ((red + K) <= 255) { red = red + K; }
                        if ((green + K) <= 255) { green = green + K; }
                        if ((blue + K) <= 255) { blue = blue + K; }
                    }
                    if (K < 0)
                    {
                        if ((red + K) >= 0) { red = red + K; }
                        if ((green + K) >= 0) { green = green + K; }
                        if ((blue + K) >= 0) { blue = blue + K; }
                    }
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.Image = bmp1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox10.Image;
            Color pC;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            float K = float.Parse(textBox1.Text)/10f;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pC = source.GetPixel(x, y);
                    int red = pC.R;
                    int green = pC.G;
                    int blue = pC.B;
                    if (K > 0)
                    {
                        if ((red * K) <= 255) { red = (int)(red * K); }
                        if ((green * K) <= 255) { green = (int)(green * K); }
                        if ((blue * K) <= 255) { blue = (int)(blue * K); }
                    }
                    if (K < 0)
                    {
                        if ((red * K) >= 0) { red = (int)(red * K); }
                        if ((green * K) >= 0) { green = (int)(green * K); }
                        if ((blue * K) >= 0) { blue = (int)(blue * K); }
                    }
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.Image = bmp1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox11.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = 255 - pixelColor.R;
                    int green = 255 - pixelColor.G;
                    int blue = 255 - pixelColor.B;
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.Image = bmp1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox11.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            int K = 50;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    red = (int)(K * Math.Log(red, 10));
                    green = (int)(K * Math.Log(green, 10));
                    blue = (int)(K * Math.Log(blue, 10));
                    if (red > 255) { red = 255; }
                    if (green > 255) { green = 255; }
                    if (blue > 255) { blue = 255; }
                    if (red < 0) { red = 0; }
                    if (green < 0) { green = 0; }
                    if (blue < 0) { blue = 0; }
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.Image = bmp1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox11.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            int K = 50;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    red = (int)(10 * Math.Exp(red / K));
                    green = (int)(10 * Math.Exp(green / K));
                    blue = (int)(10 * Math.Exp(blue / K));
                    if (red > 255) { red = 255; }
                    if (green > 255) { green = 255; }
                    if (blue > 255) { blue = 255; }
                    if (red < 0) { red = 0; }
                    if (green < 0) { green = 0; }
                    if (blue < 0) { blue = 0; }
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.Image = bmp1;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox11.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            float K = 0.4f;
            float K2 = 1.5f;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    red = (int)(K * red * Math.Exp(K2));
                    green = (int)(K * green * Math.Exp(K2));
                    blue = (int)(K * blue * Math.Exp(K2));
                    if (red > 255) { red = 255; }
                    if (green > 255) { green = 255; }
                    if (blue > 255) { blue = 255; }
                    if (red < 0) { red = 0; }
                    if (green < 0) { green = 0; }
                    if (blue < 0) { blue = 0; }
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.Image = bmp1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox11.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            float K = 0.6f;
            float K2 = 1.5f;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    red = (int)(K * red * Math.Exp(1 / K2));
                    green = (int)(K * green * Math.Exp(1 / K2));
                    blue = (int)(K * blue * Math.Exp(1 / K2));
                    if (red > 255) { red = 255; }
                    if (green > 255) { green = 255; }
                    if (blue > 255) { blue = 255; }
                    if (red < 0) { red = 0; }
                    if (green < 0) { green = 0; }
                    if (blue < 0) { blue = 0; }
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.Image = bmp1;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox13.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    bmp1.SetPixel(x, y, Color.FromArgb(red, 0, 0));
                }
            }
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.Image = bmp1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox13.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int green = pixelColor.G;
                    bmp1.SetPixel(x, y, Color.FromArgb(0, green, 0));
                }
            }
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.Image = bmp1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox13.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int blue = pixelColor.B;
                    bmp1.SetPixel(x, y, Color.FromArgb(0, 0, blue));
                }
            }
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.Image = bmp1;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox13.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    bmp1.SetPixel(x, y, Color.FromArgb(red, red, red));
                }
            }
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.Image = bmp1;
        }

        private void copyRGB(Bitmap a, Bitmap b)
        {
            for (int y = 0; y < a.Height; y++)
            {
                for (int x = 0; x < a.Width; x++)
                {
                    b.SetPixel(x, y, a.GetPixel(x, y));
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox13.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int green = pixelColor.G;
                    bmp1.SetPixel(x, y, Color.FromArgb(green, green, green));
                }
            }
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.Image = bmp1;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox13.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            copyRGB(source, bmp1);
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int blue = pixelColor.B;
                    bmp1.SetPixel(x, y, Color.FromArgb(blue, blue, blue));
                }
            }
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.Image = bmp1;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox15.Image;
            float[] h = new float[256];
            int i;
            for (i = 0; i < 256; i++)
                h[i] = 0;
            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R; h[xg] = h[xg] + 1;
                }
            for (i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, h[i]);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox15.Image;
            float[] h = new float[256];
            float[] c = new float[256];
            int i;
            for (i = 0; i < 256; i++)
                h[i] = 0;
            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R; h[xg] = h[xg] + 1;
                }
            c[0] = h[0];
            for (i = 1; i < 256; i++)
                c[i] = c[i - 1] + h[i];
            for (i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, c[i]);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox10.Image;

            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            int xgmax=0;
            int xgmin=255;
            for (int x = 0; x < bmp1.Width; x++)
                for (int y = 0; y < bmp1.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R;
                    if (xg < xgmin)
                        xgmin = xg;
                    if (xg > xgmax)
                        xgmax = xg;
                }
            for (int x = 0; x < bmp1.Width; x++)
                for (int y = 0; y < bmp1.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255*(xg-xgmin)/(xgmax-xgmin));
                    Color wb = Color.FromArgb(xb, xb, xb);
                    bmp1.SetPixel(x, y, wb);
                }
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.Image = bmp1;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox16.Image;
            Bitmap bmp1 = new Bitmap(source.Width, source.Height);
            float[] h = new float[256];
            float[] c = new float[256];
            int i;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            c[0] = h[0];
            for (i = 1; i < 256; i++)
                c[i] = c[i - 1] + h[i];
            int nx = source.Width;
            int ny = source.Height;
            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 * c[xg] / nx / ny);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    bmp1.SetPixel(x, y, wb);
                }
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox17.Image = bmp1;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox15.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            grayscale(bmp1);
            pictureBox15.Image = bmp1;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox16.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            grayscale(bmp1);
            pictureBox16.Image = bmp1;
        }

        private void grayscale(Bitmap a)
        {
            Color pixelColor;
            for (int y = 0; y < a.Height; y++)
            {
                for (int x = 0; x < a.Width; x++)
                {
                    pixelColor = a.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    int rata = (int)(red + green + blue) / 3;
                    a.SetPixel(x, y, Color.FromArgb(rata, rata, rata));
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox18.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            grayscale(bmp1);
            pictureBox18.Image = bmp1;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox18.Image;
            Bitmap objBitmap = new Bitmap(source.Width, source.Height);
            float[] a = new float[5];
            a[1] = (float)0.2;
            a[2] = (float)0.2;
            a[3] = (float)0.2;
            a[4] = (float)0.2;
            a[0] = (float)0.2;
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = source.GetPixel(x - 1, y);
                    Color w2 = source.GetPixel(x + 1, y);
                    Color w3 = source.GetPixel(x, y - 1);
                    Color w4 = source.GetPixel(x, y + 1);
                    Color w = source.GetPixel(x, y);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int xg = w.R;
                    int xb = (int)(a[0] * xg);
                    xb = (int)(xb + a[1] * x1 + a[2] * x2 + a[3] * x3 + a[3] * x4);
                    if (xb < 0)
                        xb = 0;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox19.Image = objBitmap;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox18.Image;
            Bitmap objBitmap = new Bitmap(source.Width, source.Height);
            float[] a = new float[10];
            a[1] = (float)0.1;
            a[2] = (float)0.1;
            a[3] = (float)0.1;
            a[4] = (float)0.1;
            a[5] = (float)0.2;
            a[6] = (float)0.1;
            a[7] = (float)0.1;
            a[8] = (float)0.1;
            a[9] = (float)0.1;
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = source.GetPixel(x-1, y-1);
                    Color w2 = source.GetPixel(x-1, y);
                    Color w3 = source.GetPixel(x-1, y+1);
                    Color w4 = source.GetPixel(x, y-1);
                    Color w5 = source.GetPixel(x, y);
                    Color w6 = source.GetPixel(x, y+1);
                    Color w7 = source.GetPixel(x+1, y-1);
                    Color w8 = source.GetPixel(x+1, y);
                    Color w9 = source.GetPixel(x+1, y+1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
                    xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
                    xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
                    if (xb < 0)
                        xb = 0;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox19.Image = objBitmap;
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox20.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            grayscale(bmp1);
            pictureBox20.Image = bmp1;
        }

        private void button38_Click_1(object sender, EventArgs e)
        {

        }

        private void button38_Click_2(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox23.Image;
            Bitmap objBitmap = new Bitmap(source.Width, source.Height);
            Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < 20)
                    {
                        int ns = r.Next(0, 256) - 128;
                        xb = (int)(xg + ns);
                        if (xb < 0)
                            xb = -xb;
                        if (xb > 255)
                            xb = 255;
                    }
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.Image = objBitmap;
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.Image = objBitmap;
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox22.Image = objBitmap;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox23.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            grayscale(bmp1);
            pictureBox23.Image = bmp1;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox23.Image;
            Bitmap objBitmap = new Bitmap(source.Width, source.Height);
            Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < 20)
                        xb = 0;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.Image = objBitmap;
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.Image = objBitmap;
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox22.Image = objBitmap;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox23.Image;
            Bitmap objBitmap = new Bitmap(source.Width, source.Height);
            Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = source.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < 20) xb = 255; Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.Image = objBitmap;
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.Image = objBitmap;
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox22.Image = objBitmap;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button36.PerformClick();
            button37.PerformClick();
            button38.PerformClick();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Bitmap objBitmap1 = (Bitmap)pictureBox22.Image;
            Bitmap objBitmap = new Bitmap(objBitmap1.Width, objBitmap1.Height);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1);
                    Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap1.GetPixel(x + 1, y);
                    Color w9 = objBitmap1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)((x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / 9);
                    if (xb < 0)
                        xb = 0;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox22.Image = objBitmap;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Bitmap objBitmap1 = (Bitmap)pictureBox21.Image;
            Bitmap objBitmap = new Bitmap(objBitmap1.Width, objBitmap1.Height);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1);
                    Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap1.GetPixel(x + 1, y);
                    Color w9 = objBitmap1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)((x1 + x2 + x3 + x4 + 4 * x5 + x6 + x7 + x8 + x9) / 13);
                    if (xb < 0)
                        xb = 0;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.Image = objBitmap;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Bitmap objBitmap1 = (Bitmap)pictureBox20.Image;
            Bitmap objBitmap = new Bitmap(objBitmap1.Width, objBitmap1.Height);
            int[] xt = new int[10];
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1);
                    Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap1.GetPixel(x + 1, y);
                    Color w9 = objBitmap1.GetPixel(x + 1, y + 1);
                    xt[1] = w1.R;
                    xt[2] = w2.R;
                    xt[3] = w3.R;
                    xt[4] = w4.R;
                    xt[5] = w5.R;
                    xt[6] = w6.R;
                    xt[7] = w7.R;
                    xt[8] = w8.R;
                    xt[9] = w9.R;
                    for (int i = 1; i < 9; i++)
                        for (int j = 1; j < 9; j++)
                        {
                            if (xt[j] > xt[j + 1])
                            {
                                int a = xt[j]; xt[j] = xt[j + 1]; xt[j + 1] = a;
                            }
                        }
                    int xb = xt[5]; Color wb = Color.FromArgb(xb, xb, xb); objBitmap.SetPixel(x, y, wb);
                }
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.Image = objBitmap;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)pictureBox24.Image;
            Bitmap bmp1 = new Bitmap(source.Height, source.Width);
            bmp1 = source;
            grayscale(bmp1);
            pictureBox24.Image = bmp1;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Bitmap objBitmap = (Bitmap)pictureBox24.Image;
            Bitmap objBitmap1 = new Bitmap(objBitmap.Width, objBitmap.Height);
            for (int x = 1; x < objBitmap.Width; x++)
                for (int y = 1; y < objBitmap.Height; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y);
                    Color w2 = objBitmap.GetPixel(x, y);
                    Color w3 = objBitmap.GetPixel(x, y - 1);
                    Color w4 = objBitmap.GetPixel(x, y);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int xb = (int)((x2 - x1) + (x4 - x3));
                    if (xb < 0)
                        xb = -xb;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox25.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox25.Image = objBitmap1;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            Bitmap objBitmap = (Bitmap)pictureBox24.Image;
            Bitmap objBitmap1 = new Bitmap(objBitmap.Width, objBitmap.Height);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xh = (int)(-x1 - x4 - x7 + x3 + x6 + x9);
                    int xv = (int)(-x1 - x2 - x3 + x7 + x8 + x9);
                    int xb = (int)(xh + xv);
                    if (xb < 0)
                        xb = -xb;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox25.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox25.Image = objBitmap1;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Bitmap objBitmap = (Bitmap)pictureBox24.Image;
            Bitmap objBitmap1 = new Bitmap(objBitmap.Width, objBitmap.Height);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xh = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                    int xv = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                    int xb = (int)(xh + xv);
                    if (xb < 0)
                        xb = -xb;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox25.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox25.Image = objBitmap1;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Bitmap objBitmap = (Bitmap)pictureBox24.Image;
            Bitmap objBitmap1 = new Bitmap(objBitmap.Width, objBitmap.Height);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)(x1 - 2 * x2 + x3 - 2 * x4 + 4 * x5 - 2 * x6 + x7 - 2 * x8 + x9);
                    if (xb < 0)
                        xb = -xb;
                    if (xb > 255)
                        xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox25.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox25.Image = objBitmap1;
        }

        int[] binRed = new int[256];
        int[] binGreen = new int[256];
        int[] binBlue = new int[256];

        int[] binRed2 = new int[256];
        int[] binGreen2 = new int[256];
        int[] binBlue2 = new int[256];

        int[] binRed3 = new int[256];
        int[] binGreen3 = new int[256];
        int[] binBlue3 = new int[256];

        private void button48_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = (Bitmap)pictureBox26.Image;
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    binRed[red]++;
                    binGreen[green]++;
                    binBlue[blue]++;
                }
            }
            for (int i = 0; i < 255; i++)
            {
                chart2.Series["red"].Points.AddXY(i, binRed[i]);
                chart3.Series["green"].Points.AddXY(i, binGreen[i]);
                chart4.Series["blue"].Points.AddXY(i, binBlue[i]);
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MixBox_Click(object sender, EventArgs e)
        {

        }

        private void BlueBox_Click(object sender, EventArgs e)
        {

        }

        private void GreenBox_Click(object sender, EventArgs e)
        {

        }

        private void BlueText_TextChanged(object sender, EventArgs e)
        {

        }

        private void GreenText_TextChanged(object sender, EventArgs e)
        {

        }

        private void RedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chart5_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp1 = (Bitmap)pictureBox27.Image;
            Bitmap bmp2 = (Bitmap)pictureBox28.Image;
            Bitmap bmp3 = (Bitmap)pictureBox29.Image;
            int[,,] array1 = new int[3, 3, 8];
            int temp = 0;
            int temp2 = 0;
            int temp3 = 0;
            Color pixelColor;
            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    pixelColor = bmp1.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    binRed[red]++;
                    binGreen[green]++;
                    binBlue[blue]++;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                temp = 0;
                temp2 = 0;
                temp3 = 0;
                for (int j = i * 32; j < (i * 32) + 32; j++)
                {
                    if (j > 255)
                        break;
                    temp += binRed[j];
                    temp2 += binGreen[j];
                    temp3 += binBlue[j];
                }
                array1[0, 0, i] = temp;
                array1[0, 1, i] = temp2;
                array1[0, 2, i] = temp3;
                chart5.Series["red"].Points.AddXY(i, temp);
                chart5.Series["green"].Points.AddXY(i, temp2);
                chart5.Series["blue"].Points.AddXY(i, temp3);
            }

            for (int y = 0; y < bmp2.Height; y++)
            {
                for (int x = 0; x < bmp2.Width; x++)
                {
                    pixelColor = bmp2.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    binRed2[red]++;
                    binGreen2[green]++;
                    binBlue2[blue]++;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                temp = 0;
                temp2 = 0;
                temp3 = 0;
                for (int j = i * 32; j < (i * 32) + 32; j++)
                {
                    if (j > 255)
                        break;
                    temp += binRed2[j];
                    temp2 += binGreen2[j];
                    temp3 += binBlue2[j];
                }
                array1[1, 0, i] = temp;
                array1[1, 1, i] = temp2;
                array1[1, 2, i] = temp3;
                chart6.Series["red"].Points.AddXY(i, temp);
                chart6.Series["green"].Points.AddXY(i, temp2);
                chart6.Series["blue"].Points.AddXY(i, temp3);
            }

            for (int y = 0; y < bmp3.Height; y++)
            {
                for (int x = 0; x < bmp3.Width; x++)
                {
                    pixelColor = bmp3.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    binRed3[red]++;
                    binGreen3[green]++;
                    binBlue3[blue]++;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                temp = 0;
                temp2 = 0;
                temp3 = 0;
                for (int j = i * 32; j < (i * 32) + 32; j++)
                {
                    if (j > 255)
                        break;
                    temp += binRed3[j];
                    temp2 += binGreen3[j];
                    temp3 += binBlue3[j];
                }
                array1[2, 0, i] = temp;
                array1[2, 1, i] = temp2;
                array1[2, 2, i] = temp3;
                chart7.Series["red"].Points.AddXY(i, temp);
                chart7.Series["green"].Points.AddXY(i, temp2);
                chart7.Series["blue"].Points.AddXY(i, temp3);
            }

            int dif1 = 0;
            int dif2 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    dif1 += Math.Abs(array1[2, i, j] - array1[0, i, j]);
                    dif2 += Math.Abs(array1[2, i, j] - array1[1, i, j]);
                }
            }

            pictureBox30.SizeMode = PictureBoxSizeMode.Zoom;
            if(dif1 < dif2)
            {
                pictureBox30.Image = bmp1;
            }
            else
            {
                pictureBox30.Image = bmp2;
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox27.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox27.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox28.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox28.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox29.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox29.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void chart7_Click(object sender, EventArgs e)
        {

        }

        private void chart6_Click(object sender, EventArgs e)
        {

        }

        

        int RGBToWarna(int Red, int Green, int Blue)
        {
            return (Red + (Green << 8) + (Blue << 16));
        }

        private void button51_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox31.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox31.Image = Image.FromFile(ofd.FileName);
            }
        }

        int[] proyeksi = new int[500];
        int[] proyeksi2 = new int[500];

        private void button52_Click(object sender, EventArgs e)
        {
            Color pixelColor;
            int count = 0;
            int total = 0;
            int num = 0;
            
            Bitmap source = (Bitmap)pictureBox31.Image;
            int blokH = source.Height / int.Parse(textBox2.Text);
            int sisaH = source.Height - (blokH * int.Parse(textBox2.Text));
            int blokW = source.Width / int.Parse(textBox2.Text);
            int sisaW = source.Width - (blokW * int.Parse(textBox2.Text));
            int startH = 0;
            int finishH = blokH;
            if (sisaH > 0)
            {
                finishH++;
                sisaH--;
            }
            int startW = 0;
            int finishW = 0;

            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                num = 0;
                finishW = blokW;
                if (sisaW > 0)
                {
                    finishW++;
                    sisaW--;
                }
                for (int j = 0; j < int.Parse(textBox2.Text); j++)
                {
                    total = 0;
                    count = 0;                  
                    for (int y = startH;  y < finishH; y++)
                    {
                        for (int x = startW; x < finishW; x++)
                        {
                            total++;
                            pixelColor = source.GetPixel(x, y);
                            int red = pixelColor.R;
                            int green = pixelColor.G;
                            int blue = pixelColor.B;
                            int rata = (int)(red + green + blue) / 3;
                            if (rata < 128)
                            {
                                count++;
                            }
                        }
                    }

                    startW = finishW;
                    if (sisaW > 0)
                    {
                        finishW = finishW + blokW + 1;
                        sisaW--;
                    }
                    else
                    {
                        finishW = finishW + blokW;
                    }

                    if (count > (total / 2))
                    {
                        num++;
                    }
                    
                }

                startH = finishH;
                if (sisaH > 0)
                {
                    finishH = finishH + blokH + 1;
                    sisaH--;
                }
                else
                {
                    finishH = finishH + blokH;
                }

                proyeksi[i] = num;
            }

            Bitmap bmp = new Bitmap(int.Parse(textBox2.Text), int.Parse(textBox2.Text));
            for (int y = 0; y < int.Parse(textBox2.Text); y++)
            {
                for (int x = 0; x < proyeksi[y]; x++)
                {
                    bmp.SetPixel(x, y, Color.Black);
                }

            }
            pictureBox32.Image = bmp;
            pictureBox32.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox36.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox36.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Color pixelColor;
            int count = 0;
            int total = 0;
            int num = 0;

            Bitmap source = (Bitmap)pictureBox31.Image;
            int blokH = source.Height / int.Parse(textBox2.Text);
            int sisaH = source.Height - (blokH * int.Parse(textBox2.Text));
            int blokW = source.Width / int.Parse(textBox2.Text);
            int sisaW = source.Width - (blokW * int.Parse(textBox2.Text));
            int startW = 0;
            int finishW = blokW;
            if (sisaW > 0)
            {
                finishW++;
                sisaW--;
            }
            int startH = 0;
            int finishH = 0;

            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                num = 0;
                finishH = blokH;
                if (sisaH > 0)
                {
                    finishH++;
                    sisaH--;
                }
                for (int j = 0; j < int.Parse(textBox2.Text); j++)
                {
                    total = 0;
                    count = 0;
                    for (int y = startW; y < finishW; y++)
                    {
                        for (int x = startH; x < finishH; x++)
                        {
                            total++;
                            pixelColor = source.GetPixel(y, x);
                            int red = pixelColor.R;
                            int green = pixelColor.G;
                            int blue = pixelColor.B;
                            int rata = (int)(red + green + blue) / 3;
                            if (rata < 128)
                            {
                                count++;
                            }
                        }
                    }

                    startH = finishH;
                    if (sisaH > 0)
                    {
                        finishH = finishH + blokH + 1;
                        sisaH--;
                    }
                    else
                    {
                        finishH = finishH + blokH;
                    }

                    if (count > (total / 2))
                    {
                        num++;
                    }

                }

                startW = finishW;
                if (sisaW > 0)
                {
                    finishW = finishW + blokW + 1;
                    sisaW--;
                }
                else
                {
                    finishW = finishW + blokW;
                }

                proyeksi2[i] = num;
            }

            Bitmap bmp = new Bitmap(int.Parse(textBox2.Text), int.Parse(textBox2.Text));
            for (int y = 0; y < int.Parse(textBox2.Text); y++)
            {
                for (int x = 0; x < proyeksi2[y]; x++)
                {
                    bmp.SetPixel(y, x, Color.Black);
                }

            }
            pictureBox33.Image = bmp;
            pictureBox33.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {
            int diff = 0;
            int diffTot = int.Parse(textBox2.Text) * int.Parse(textBox2.Text) * 2;
            String text = "";
            float presentage = 0;
            for (int i = 0; i < (int.Parse(textBox2.Text)); i++)
            {
                diff += Math.Abs(proyeksi[i] - proyeksi3[i]);
                diff += Math.Abs(proyeksi2[i] - proyeksi4[i]);
                if(proyeksi[i] == 0 && proyeksi3[i] == 0)
                {
                    diffTot--;
                }
                else if(proyeksi2[i] == 0 && proyeksi4[i] == 0)
                {
                    diffTot--;
                }
            }
            presentage = 100 - ((diff * 100) / diffTot);
            text = "" + presentage;
            label24.Text = diff.ToString();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            String text = "";
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                text += proyeksi2[i] + " ";
            }
            MessageBox.Show(text);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            String text = "";
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                text += proyeksi[i] + " ";
            }
            MessageBox.Show(text);
        }

        int[] proyeksi3 = new int[500];
        int[] proyeksi4 = new int[500];

        private void button55_Click(object sender, EventArgs e)
        {
            Color pixelColor;
            int count = 0;
            int total = 0;
            int num = 0;

            Bitmap source = (Bitmap)pictureBox36.Image;
            int blokH = source.Height / int.Parse(textBox2.Text);
            int sisaH = source.Height - (blokH * int.Parse(textBox2.Text));
            int blokW = source.Width / int.Parse(textBox2.Text);
            int sisaW = source.Width - (blokW * int.Parse(textBox2.Text));
            int startH = 0;
            int finishH = blokH;
            if (sisaH > 0)
            {
                finishH++;
                sisaH--;
            }
            int startW = 0;
            int finishW = 0;

            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                num = 0;
                finishW = blokW;
                if (sisaW > 0)
                {
                    finishW++;
                    sisaW--;
                }
                for (int j = 0; j < int.Parse(textBox2.Text); j++)
                {
                    total = 0;
                    count = 0;
                    for (int y = startH; y < finishH; y++)
                    {
                        for (int x = startW; x < finishW; x++)
                        {
                            total++;
                            pixelColor = source.GetPixel(x, y);
                            int red = pixelColor.R;
                            int green = pixelColor.G;
                            int blue = pixelColor.B;
                            int rata = (int)(red + green + blue) / 3;
                            if (rata < 128)
                            {
                                count++;
                            }
                        }
                    }

                    startW = finishW;
                    if (sisaW > 0)
                    {
                        finishW = finishW + blokW + 1;
                        sisaW--;
                    }
                    else
                    {
                        finishW = finishW + blokW;
                    }

                    if (count > (total / 2))
                    {
                        num++;
                    }

                }

                startH = finishH;
                if (sisaH > 0)
                {
                    finishH = finishH + blokH + 1;
                    sisaH--;
                }
                else
                {
                    finishH = finishH + blokH;
                }

                proyeksi3[i] = num;
            }

            Bitmap bmp = new Bitmap(int.Parse(textBox2.Text), int.Parse(textBox2.Text));
            for (int y = 0; y < int.Parse(textBox2.Text); y++)
            {
                for (int x = 0; x < proyeksi3[y]; x++)
                {
                    bmp.SetPixel(x, y, Color.Black);
                }

            }
            pictureBox35.Image = bmp;
            pictureBox35.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Color pixelColor;
            int count = 0;
            int total = 0;
            int num = 0;

            Bitmap source = (Bitmap)pictureBox36.Image;
            int blokH = source.Height / int.Parse(textBox2.Text);
            int sisaH = source.Height - (blokH * int.Parse(textBox2.Text));
            int blokW = source.Width / int.Parse(textBox2.Text);
            int sisaW = source.Width - (blokW * int.Parse(textBox2.Text));
            int startW = 0;
            int finishW = blokW;
            if (sisaW > 0)
            {
                finishW++;
                sisaW--;
            }
            int startH = 0;
            int finishH = 0;

            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                num = 0;
                finishH = blokH;
                if (sisaH > 0)
                {
                    finishH++;
                    sisaH--;
                }
                for (int j = 0; j < int.Parse(textBox2.Text); j++)
                {
                    total = 0;
                    count = 0;
                    for (int y = startW; y < finishW; y++)
                    {
                        for (int x = startH; x < finishH; x++)
                        {
                            total++;
                            pixelColor = source.GetPixel(y, x);
                            int red = pixelColor.R;
                            int green = pixelColor.G;
                            int blue = pixelColor.B;
                            int rata = (int)(red + green + blue) / 3;
                            if (rata < 128)
                            {
                                count++;
                            }
                        }
                    }

                    startH = finishH;
                    if (sisaH > 0)
                    {
                        finishH = finishH + blokH + 1;
                        sisaH--;
                    }
                    else
                    {
                        finishH = finishH + blokH;
                    }

                    if (count > (total / 2))
                    {
                        num++;
                    }

                }

                startW = finishW;
                if (sisaW > 0)
                {
                    finishW = finishW + blokW + 1;
                    sisaW--;
                }
                else
                {
                    finishW = finishW + blokW;
                }

                proyeksi4[i] = num;
            }

            Bitmap bmp = new Bitmap(int.Parse(textBox2.Text), int.Parse(textBox2.Text));
            for (int y = 0; y < int.Parse(textBox2.Text); y++)
            {
                for (int x = 0; x < proyeksi4[y]; x++)
                {
                    bmp.SetPixel(y, x, Color.Black);
                }

            }
            pictureBox34.Image = bmp;
            pictureBox34.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            String text = "";
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                text += proyeksi3[i] + " ";
            }
            MessageBox.Show(text);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            String text = "";
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                text += proyeksi4[i] + " ";
            }
            MessageBox.Show(text);
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        String[] gambar = new String[572];
        String dir;

        private void button64_Click(object sender, EventArgs e)
        {  
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                textBox5.Text = ofd.FileName;
            }
            String[] lines = System.IO.File.ReadAllLines(ofd.FileName);

            int p = 0;
            dir = ofd.FileName.Remove(ofd.FileName.IndexOf(ofd.SafeFileName));
            foreach (string line in lines)
            {
                gambar[p] = line;
                listBox1.Items.Add(gambar[p]);
                p++;
            }
        }

        String imageQuery;
        int[] proyeksiHQuery = new int[100];
        int[] proyeksiVQuery = new int[100];

        private void button62_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png (*.png)|*.png|jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                boxLBP.SizeMode = PictureBoxSizeMode.Zoom;
                boxLBP.Image = Image.FromFile(ofd.FileName);
                imageQuery = ofd.FileName;
            }

            Color pixelColor;
            int count = 0;
            int total = 0;
            int num = 0;

            Image img = Image.FromFile(ofd.FileName);
            Bitmap source = new Bitmap(img);

            int blokH = source.Height / sizeP;
            int sisaH = source.Height - (blokH * sizeP);
            int blokW = source.Width / sizeP;
            int sisaW = source.Width - (blokW * sizeP);
            int startH = 0;
            int finishH = blokH;
            String text = "";

            if (sisaH > 0)
            {
                finishH++;
                sisaH--;
            }
            int startW = 0;
            int finishW = 0;

            for (int i = 0; i < sizeP; i++)
            {
                num = 0;
                finishW = blokW;
                if (sisaW > 0)
                {
                    finishW++;
                    sisaW--;
                }
                for (int j = 0; j < sizeP; j++)
                {
                    total = 0;
                    count = 0;
                    for (int y = startH; y < finishH; y++)
                    {
                        for (int x = startW; x < finishW; x++)
                        {
                            total++;
                            pixelColor = source.GetPixel(x, y);
                            int red = pixelColor.R;
                            int green = pixelColor.G;
                            int blue = pixelColor.B;
                            int rata = (int)(red + green + blue) / 3;
                            if (rata < 128)
                            {
                                count++;
                            }
                        }
                    }

                    startW = finishW;
                    if (sisaW > 0)
                    {
                        finishW = finishW + blokW + 1;
                        sisaW--;
                    }
                    else
                    {
                        finishW = finishW + blokW;
                    }

                    if (count > (total / 2))
                    {
                        num++;
                    }

                }

                startH = finishH;
                if (sisaH > 0)
                {
                    finishH = finishH + blokH + 1;
                    sisaH--;
                }
                else
                {
                    finishH = finishH + blokH;
                }

                text = text + num + " ";
                proyeksiHQuery[i] = num;

            }

            startW = 0;
            finishW = blokW;
            if (sisaW > 0)
            {
                finishW++;
                sisaW--;
            }
            startH = 0;
            finishH = 0;

            for (int i = 0; i < sizeP; i++)
            {
                num = 0;
                finishH = blokH;
                if (sisaH > 0)
                {
                    finishH++;
                    sisaH--;
                }
                for (int j = 0; j < sizeP; j++)
                {
                    total = 0;
                    count = 0;
                    for (int y = startW; y < finishW; y++)
                    {
                        for (int x = startH; x < finishH; x++)
                        {
                            total++;
                            pixelColor = source.GetPixel(y, x);
                            int red = pixelColor.R;
                            int green = pixelColor.G;
                            int blue = pixelColor.B;
                            int rata = (int)(red + green + blue) / 3;
                            if (rata < 128)
                            {
                                count++;
                            }
                        }
                    }

                    startH = finishH;
                    if (sisaH > 0)
                    {
                        finishH = finishH + blokH + 1;
                        sisaH--;
                    }
                    else
                    {
                        finishH = finishH + blokH;
                    }

                    if (count > (total / 2))
                    {
                        num++;
                    }

                }

                startW = finishW;
                if (sisaW > 0)
                {
                    finishW = finishW + blokW + 1;
                    sisaW--;
                }
                else
                {
                    finishW = finishW + blokW;
                }
                text = text + num + " ";
                proyeksiVQuery[i] = num;
            }
        }

        int[,] proyeksiH = new int[572, 100];
        int[,] proyeksiV = new int[572, 100];
        int sizeP = 15;

        private void button63_Click(object sender, EventArgs e)
        {
            Color pixelColor;
            int count = 0;
            int total = 0;
            int num = 0;
            int jml = gambar.Count(x => x != null);

            for(int a = 0; a < jml; a++)
            {
                Image img = Image.FromFile(dir + gambar[a]);
                Bitmap source = new Bitmap(img);

                int blokH = source.Height / sizeP;
                int sisaH = source.Height - (blokH * sizeP);
                int blokW = source.Width / sizeP;
                int sisaW = source.Width - (blokW * sizeP);
                int startH = 0;
                int finishH = blokH;

                if (sisaH > 0)
                {
                    finishH++;
                    sisaH--;
                }
                int startW = 0;
                int finishW = 0;

                for (int i = 0; i < sizeP; i++)
                {
                    num = 0;
                    finishW = blokW;
                    if (sisaW > 0)
                    {
                        finishW++;
                        sisaW--;
                    }
                    for (int j = 0; j < sizeP; j++)
                    {
                        total = 0;
                        count = 0;
                        for (int y = startH; y < finishH; y++)
                        {
                            for (int x = startW; x < finishW; x++)
                            {
                                total++;
                                pixelColor = source.GetPixel(x, y);
                                int red = pixelColor.R;
                                int green = pixelColor.G;
                                int blue = pixelColor.B;
                                int rata = (int)(red + green + blue) / 3;
                                if (rata < 128)
                                {
                                    count++;
                                }
                            }
                        }

                        startW = finishW;
                        if (sisaW > 0)
                        {
                            finishW = finishW + blokW + 1;
                            sisaW--;
                        }
                        else
                        {
                            finishW = finishW + blokW;
                        }

                        if (count > (total / 2))
                        {
                            num++;
                        }

                    }

                    startH = finishH;
                    if (sisaH > 0)
                    {
                        finishH = finishH + blokH + 1;
                        sisaH--;
                    }
                    else
                    {
                        finishH = finishH + blokH;
                    }
                    proyeksiH[a, i] = num;

                }

                startW = 0;
                finishW = blokW;
                if (sisaW > 0)
                {
                    finishW++;
                    sisaW--;
                }
                startH = 0;
                finishH = 0;

                for (int i = 0; i < sizeP; i++)
                {
                    num = 0;
                    finishH = blokH;
                    if (sisaH > 0)
                    {
                        finishH++;
                        sisaH--;
                    }
                    for (int j = 0; j < sizeP; j++)
                    {
                        total = 0;
                        count = 0;
                        for (int y = startW; y < finishW; y++)
                        {
                            for (int x = startH; x < finishH; x++)
                            {
                                total++;
                                pixelColor = source.GetPixel(y, x);
                                int red = pixelColor.R;
                                int green = pixelColor.G;
                                int blue = pixelColor.B;
                                int rata = (int)(red + green + blue) / 3;
                                if (rata < 128)
                                {
                                    count++;
                                }
                            }
                        }

                        startH = finishH;
                        if (sisaH > 0)
                        {
                            finishH = finishH + blokH + 1;
                            sisaH--;
                        }
                        else
                        {
                            finishH = finishH + blokH;
                        }

                        if (count > (total / 2))
                        {
                            num++;
                        }

                    }

                    startW = finishW;
                    if (sisaW > 0)
                    {
                        finishW = finishW + blokW + 1;
                        sisaW--;
                    }
                    else
                    {
                        finishW = finishW + blokW;
                    }
                    proyeksiV[a, i] = num;
                }
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            int[] diff = new int[572];
            int jml = gambar.Count(x => x != null);

            listBox2.Items.Clear();
            listBox2.Items.Add("Nilai Perbedaan");
            for (int i=0; i < jml; i++)
            {
                for (int j = 0; j < sizeP; j++)
                {
                    diff[i] += Math.Abs(proyeksiH[i, j] - proyeksiHQuery[j]);
                    diff[i] += Math.Abs(proyeksiV[i, j] - proyeksiVQuery[j]);
                }
                listBox2.Items.Add(gambar[i] + " = " + diff[i]);
            }

            int fittest = diff[0];
            int indexFittest = 0;
            for (int i=0; i < 10; i++)
            {
                for(int j = 0; j < jml; j++)
                {
                    if(diff[j] < fittest)
                    {
                        fittest = diff[j];
                        indexFittest = j;
                    }
                }
                diff[indexFittest] = (sizeP * sizeP) + 1;
                fittest = diff[indexFittest];

                switch (i+1)
                {
                    case 1:
                        lbp1.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp1.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 2:
                        lbp2.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp2.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 3:
                        lbp3.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp3.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 4:
                        lbp4.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp4.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 5:
                        lbp5.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp5.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 6:
                        lbp6.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp6.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 7:
                        lbp7.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp7.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 8:
                        lbp8.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp8.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 9:
                        lbp9.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp9.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    case 10:
                        lbp10.SizeMode = PictureBoxSizeMode.Zoom;
                        lbp10.Image = Image.FromFile(dir + gambar[indexFittest]);
                        break;
                    default:
                        break;
                }
               
            }
        }

        private void tabPage16_Click(object sender, EventArgs e)
        {

        }
    }
}
