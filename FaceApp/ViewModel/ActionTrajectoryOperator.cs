using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.ViewModel
{
    class ActionTrajectoryOperator : ViewModelBase
    {
		public ActionTrajectoryOperator()
		{
			_objectControlS = new ObservableCollection<ActionTrajectoryObject>();
			ActionTrajectoryObject actionObj = new ActionTrajectoryObject();
			actionObj.ID = 11;
			actionObj.PointX = 20;
			actionObj.PointY = 20;
			_objectControlS.Add(actionObj);
		}

        public void SetPoint(int id, int x, int y)
        {
            bool bFind = _objectControlS.Any<ActionTrajectoryObject>(p => p.ID==id);
            if (bFind)
            {
                foreach(ActionTrajectoryObject item in _objectControlS)
                {
                    if (item.ID == id)
                    {
                        item.PointX = x;
                        item.PointY = y;
                        break;
                    }
                }
            }
            else
            {
                ActionTrajectoryObject actionObj = new ActionTrajectoryObject();
                actionObj.ID = id;
                actionObj.PointX = x;
                actionObj.PointY = y;
                ObjectControlS.Add(actionObj);
            }
        }
        /*private int maxWidth = 2370;
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
        }*/
		
		private ObservableCollection<ActionTrajectoryObject>  _objectControlS;
		public ObservableCollection<ActionTrajectoryObject>  ObjectControlS
		{
			get{return _objectControlS;}
			set{_objectControlS = value; NotifyChange();}
		}
    }
}
