using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDemo
{
    public partial class WebClientDemo : Form
    {
        public WebClientDemo()
        {
            InitializeComponent();
            WebClient client = new WebClient();
            try
            {
                string line;
                using (StreamReader sr = new StreamReader(client.OpenRead("http://www.baidu.com")))
                {
                    while ((line=sr.ReadLine())!=null)
                    {
                        richTextBox1.AppendText(line+"\r\n");
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {

               
            }
           
        }
    }
}
