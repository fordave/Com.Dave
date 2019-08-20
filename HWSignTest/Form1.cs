using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HWSignTest.SDK;

namespace HWSignTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TOUCH_INFO _tOUCH_INFO;
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = -1U;

            try
            {
                result = HWSignApi.HWInit(new IntPtr(0));

                Thread.Sleep(200);
                result = HWSignApi.GetDeviceStatus();

                DEVICE_INFO dEVICE_INFO = new DEVICE_INFO();
                result = HWSignApi.GetDeviceInfo(ref dEVICE_INFO);

                HWSignApi.RegisterTouchInfoCallBack(TouchInfoCallBack);

                graphics = pictureBox1.CreateGraphics();
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            }
            catch (Exception ex)
            {


            }

        }
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, IntPtr hdc, int flags);


        Graphics graphics;
        private int TouchInfoCallBack(TOUCH_INFO tOUCH_INFO)
        {
            _tOUCH_INFO = tOUCH_INFO;
            return 0;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = HWSignApi.HWClose(new IntPtr(0));
            // MessageBox.Show($"{result}");
        }
        private Random Random = new Random();
        private void Button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(Random.Next(250), Random.Next(250), Random.Next(250), Random.Next(250)), 4);
            graphics?.DrawLine(pen, new Point(Random.Next(250), Random.Next(200)), new Point(Random.Next(400), Random.Next(200)));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var path = @".\imagetemp.bmp";

            graphics.Save();
            graphics.Flush();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, graphics);
            pictureBox1.DrawToBitmap(bitmap, pictureBox1.Bounds);
            bitmap.Save(path);
        }
    }
}
