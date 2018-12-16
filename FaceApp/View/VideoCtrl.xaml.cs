﻿using FaceApp.Common;
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
    /// StatisticsCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class VideoCtrl : UserControl
    {
        public VideoCtrl()
        {
            InitializeComponent();
            IntPtr flpHandle = flowLayoutPanel1.Handle;
            Loaded += VideoCtrlLoaded;
        }
        void VideoCtrlLoaded(object sender, RoutedEventArgs e)
        {
            IntPtr flpHandle = flowLayoutPanel1.Handle;
            GlobalData.instance.VideoPtr = (Int32)flpHandle;
        }
    }
}