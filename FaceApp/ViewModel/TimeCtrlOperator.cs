using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FaceApp.ViewModel
{
    class TimeCtrlOperator
    {
        public TimeCtrlModel TimeCtrl { get; set; }
        System.Timers.Timer timer;

        public TimeCtrlOperator()
        {
            TimeCtrl = new TimeCtrlModel();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timeFunc);//到达时间的时候执行事件；
            timer.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            timer.Enabled = true;
            timer.Start();

        }
        private void timeFunc(object source, System.Timers.ElapsedEventArgs e)
        {
            TimeCtrl.CurTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public void SetAskCount(int count)
        {
            TimeCtrl.AskCount = string.Format("{0:N0}", count);
        }
    }
}
