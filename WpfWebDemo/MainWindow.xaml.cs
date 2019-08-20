using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YKBLClient.HanvonSdk;

namespace WpfWebDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HWSignApi.RegisterTouchInfoCallBack(new callBackTouchInfoFunc(TouchOver));
        }

        private int TouchOver(IntPtr ptr)
        {
          var tt=  HWSignApi.GetDeviceStatus();
            return tt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "ss";
        }

        private void InkCanvas_TouchMove(object sender, TouchEventArgs e)
        {

        }

        private void InkCanvas_StylusMove(object sender, StylusEventArgs e)
        {

        }

        private void InkCanvas_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
