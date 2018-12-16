using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class TimeCtrlModel : ViewModelBase
    {
        private string curTime;
        public string CurTime
        {
            get { return curTime; }
            set { curTime = value; NotifyChange(); }
        }

        private int askCount;
        public int AskCount
        {
            get {return askCount; }
            set { askCount = value; NotifyChange(); }
        }

    }
}
