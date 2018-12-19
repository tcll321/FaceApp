using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FaceApp.ViewModel
{
    public class ActionTrajectoryObject:ViewModelBase
    {
        private int maxWidth = 2370;
        private int maxHeight = 3150;

        private int id = 0;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private float pointX=0;
        public float PointX
        {
            get { return pointX; }
            set { pointX = value; NotifyChange(); }
        }

        private float pointY =0;
        public float PointY {
            get {return pointY; }
            set {pointY = value; NotifyChange(); }
        }

        private Visibility showPoint = Visibility.Visible;
        public Visibility ShowPoint
        {
            get { return showPoint; }
            set { showPoint = value; }
        }
        public ActionTrajectoryObject()
        {
        }
    } 
}
