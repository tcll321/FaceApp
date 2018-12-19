using FaceApp.Common;
using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FaceApp.ViewModel
{
    class VideoOperator : ViewModelBase
    {
        System.Timers.Timer timer;
        VideoModel videoModel = null;
        StatisticsOperator statOper = null;
        FaceOperator faceOper = null;
        ActionTrajectoryOperator actionOper = null;
        TimeCtrlOperator timerOper = null;

        private Visibility _punchHand = Visibility.Hidden;
        public Visibility PunchHand
        {
            get { return _punchHand; }
            set { _punchHand = value; }
        }

        public VideoOperator(StatisticsOperator statOp, FaceOperator face, ActionTrajectoryOperator action, TimeCtrlOperator timerOp)
        {
            statOper = statOp;
            faceOper = face;
            actionOper = action;
            timerOper = timerOp;
            string strAskCount = ConfigurationManager.AppSettings["AskCount"];
            string strEmbraceCount = ConfigurationManager.AppSettings["EmbraceCount"];
            string strSayHelloCount = ConfigurationManager.AppSettings["SayHelloCount"];
            timerOper.SetAskCount(int.Parse(strAskCount));
            statOper.SetStatisticsInfo(0, 0, int.Parse(strEmbraceCount), int.Parse(strSayHelloCount), 0);
            videoModel = new VideoModel(OnFaceInfo, OnTrajectoryInfo);
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timeFunc);//到达时间的时候执行事件；
            timer.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            timer.Enabled = true;
            timer.Start();
        }
        private void timeFunc(object source, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            if (videoModel!=null)
                videoModel.StartVideo();
            PunchHand = Visibility.Hidden;
        }
        private void OnFaceInfo(int device, int sex,int age,int id, string faceImage, int userParam)
        {
            if (age <= 0)
                return;
            SexType type = sex == 0 ? SexType.Female : SexType.Male;
//             faceOper.SetFaceObjetInfo(age, type, id);
//             faceOper.SetFaceImage(id, faceImage);
            faceOper.SetInfoAndImage(age, type, id, faceImage);
        }

        private void OnTrajectoryInfo(_TrajectoryStruct info, int userParam)
        {
            if (statOper != null)
            {
                timerOper.SetAskCount(info.total);
                statOper.SetStatisticsInfo(info.total, info.fall, info.punch, info.raise, info.nTracker);
//                 actionOper.SetPoint(info.id, 10, 10);
            }
        }
    }
}
