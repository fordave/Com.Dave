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
    public partial class WebRequestDemo : Form
    {
        public WebRequestDemo()
        {
            InitializeComponent();
            try
            {
                WebRequest request = WebRequest.Create("http://www.baidu.com");
                WebResponse response = request.GetResponse();
                string line;
                List<string> responseContents = new List<string>();
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    while ((line=sr.ReadLine())!=null)
                    {
                        responseContents.Add(line);
                    }
                    sr.Close();

                }
                listBox1.DataSource = responseContents;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
