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
    /// FaceImageCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class FaceImageCtrl : UserControl
    {
        public FaceImageCtrl()
        {
            InitializeComponent();
            IntPtr flpHandle = flowLayoutPanelFace.Handle;
            Loaded += FaceImageCtrlLoaded;
        }
        void FaceImageCtrlLoaded(object sender, RoutedEventArgs e)
        {
            IntPtr flpHandle = flowLayoutPanelFace.Handle;
            GlobalData.instance.FaceImageHandle.Add((Int32)flpHandle);
        }
    }
}
