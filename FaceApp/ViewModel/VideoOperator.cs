using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.ViewModel
{
    class VideoOperator
    {
        System.Timers.Timer timer;
        VideoModel videoModel = null;
        StatisticsOperator statOper = null;
        FaceOperator faceOper = null;
        public VideoOperator(StatisticsOperator statOp, FaceOperator face)
        {
            statOper = statOp;
            faceOper = face;
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
        }
        private void OnFaceInfo(int device, int sex,int age,int id, int userParam)
        {
            if (age <= 0)
                return;
            SexType type = sex == 0 ? SexType.Female : SexType.Male;
            faceOper.SetFaceObjetInfo(age, type, 0);
        }

        private void OnTrajectoryInfo(_TrajectoryStruct info, int userParam)
        {
            if (statOper != null)
            {
                statOper.SetStatisticsInfo(info.total, info.fall, info.punch, info.raise, info.nTracker);
            }
        }
    }
}
