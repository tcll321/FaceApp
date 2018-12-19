using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// ActionTrajectory.xaml 的交互逻辑
    /// </summary>
    public partial class ActionTrajectory : UserControl
    {
        public ActionTrajectory()
        {
            InitializeComponent();

            //BitmapImage bi = new BitmapImage();
            //bi.BeginInit();
            //bi.UriSource = new Uri("D:\\work\\Face\\FaceApp\\FaceApp_2\\FaceApp\\View\\Resources\\Position.png", UriKind.Absolute);
            //bi.EndInit();
            //bi.Freeze();

            //Image img = new Image();
            //img.Source = bi;
            //img.Height = this.Height / 20;
            //img.Width = this.Width / 20;
            //img.SetValue(Canvas.LeftProperty, 50.00);
            //img.SetValue(Canvas.TopProperty, 50.00);
            //Canvast.Children.Add(img);
        }
    }
}
