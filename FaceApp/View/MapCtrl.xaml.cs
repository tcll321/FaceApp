using FaceApp.Common;
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

namespace FaceApp
{
    /// <summary>
    /// MapCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class MapCtrl : UserControl
    {
        public MapCtrl()
        {
            InitializeComponent();
            IntPtr flpHandle = flowLayoutPanelMap.Handle;
            Loaded += VideoCtrlLoaded;
        }
        void VideoCtrlLoaded(object sender, RoutedEventArgs e)
        {
            IntPtr flpHandle = flowLayoutPanelMap.Handle;
            GlobalData.instance.MapPtr = (Int32)flpHandle;
        }
    }
}
