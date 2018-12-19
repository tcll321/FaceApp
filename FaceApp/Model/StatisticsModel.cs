using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class StatisticsModel:ViewModelBase
    {

        private string putHandCount = "0";
        public string PutHandCount
        {
            get { return putHandCount; }
            set { putHandCount = value; NotifyChange(); }
        }
        private string punchCount = "0";
        public string PunchCount
        {
            get { return punchCount; }
            set { punchCount = value; NotifyChange(); }
        }
        private string fallCount = "0";
        public string FallCount
        {
            get { return fallCount; }
            set { fallCount = value; NotifyChange(); }
        }

        private int sayHello = 0;
        public int SayHello
        {
            get { return sayHello; }
            set { sayHello = value; }
        }
        private int embrace = 0;
        public int Embrace
        {
            get { return embrace; }
            set { embrace = value; }
        }
    }
}
