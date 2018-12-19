using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.ViewModel
{
    class ActionTrajectoryOperator : ViewModelBase
    {
        private int maxWidth = 2370;
        private int maxHeight = 3150;
        private float width = 300;
        private float height = 540;

        private ActionTrajectoryObject actionObj;
        public ActionTrajectoryObject ActionObj {
            get {return actionObj; }
            set { actionObj = value;  NotifyChange(); }
        }

        public ActionTrajectoryOperator()
        {
            actionObj = new ActionTrajectoryObject();
        }
        public void SetIetmPoint(int id, int x, int y)
        {
            actionObj.PointX = x * width / maxWidth;
            actionObj.PointY = y * height/ maxHeight;
        }
    }
}
