using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDemo
{
    public partial class HttpWebRequestDemo : Form
    {
        public HttpWebRequestDemo()
        {
            InitializeComponent();
            try
            {
                HttpWebRequest request =(HttpWebRequest) WebRequest.Create("http://www.baidu.com");
                WebResponse response = request.GetResponse();
                string line;
                List<string> responseContents = new List<string>();
                WebHeaderCollection headers = response.Headers;
                for(int i = 0; i < headers.Count; i++)
                {
                    responseContents.Add(string.Format("header {0} :{1}",headers.GetKey(i),headers[i]));
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
