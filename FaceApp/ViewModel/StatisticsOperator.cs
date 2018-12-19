using FaceApp.Common;
using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.ViewModel
{
    class StatisticsOperator:ViewModelBase
    {
        private StatisticsModel statCtrl;
        public StatisticsModel StatCtrl
        {
            get
            {
                return statCtrl;
            }
            set
            {
                statCtrl = value;NotifyChange();
            }
        }
        System.Timers.Timer timer;

        public StatisticsOperator()
        {
            statCtrl = new StatisticsModel();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timeFunc);//到达时间的时候执行事件；
            timer.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            timer.Enabled = true;
            timer.Start();

        }
        public void SetStatisticsInfo(int total, int fall, int punch, int raise, int nTracker)
        {
            statCtrl.PunchCount = punch.ToString();
//             statCtrl.PunchCount = punch.ToString();
            statCtrl.PutHandCount = raise.ToString();
        }
        public void SetStatistics(int motion)
        {
            if (motion == 1)
                statCtrl.Embrace++;
            if (motion == 2)
                statCtrl.SayHello++;
        }
        private void timeFunc(object source, System.Timers.ElapsedEventArgs e)
        {
        }
    }
}
