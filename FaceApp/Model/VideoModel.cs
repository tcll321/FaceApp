using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class VideoModel : ViewModelBase
    {
        private bool _handUpImageEnable = true;
        public bool HandUpImageEnable
        {
            get { return _handUpImageEnable; }
            set { _handUpImageEnable = value; }
        }

        FaceSdk.Callback_OnFaceInfo _faceInfo;
        FaceSdk.Callback_OnTrajectoryInfo _trajectInfo;
        int device = 0;
        List<_FaceInfoStruct> lstFaceInfo;
        public VideoModel(FaceSdk.Callback_OnFaceInfo faceInfo, FaceSdk.Callback_OnTrajectoryInfo traInfo)
        {
            _faceInfo = faceInfo;
            _trajectInfo = traInfo;
        }

        public int StartVideo()
        {
            int ret = 0;
            try
            {

                ret = FaceSdk.Face_Init(out device);
                if (ret != 0)
                    return ret;
//                 ret = FaceSdk.Face_Create(0, GlobalData.instance.VideoPtr, _faceInfo, 0);
                ret = FaceSdk.Face_Create(0, 0, _faceInfo, 0);
//                 int i = 0;
//                 foreach (Int32 item in GlobalData.instance.FaceImageHandle)
//                 {
//                     FaceSdk.Face_SetFaceWnd(i, item);
//                     i++;
//                 }

                ret = FaceSdk.Face_InitTrajectory();
                if (ret != 0)
                    return ret;
                ret = FaceSdk.Face_SetWnd(GlobalData.instance.VideoPtr, GlobalData.instance.MapPtr);
                if (ret != 0)
                    return ret;
                //                 ret = FaceSdk.Face_StartTrajectory(GlobalData.instance.VideoPtr, _trajectInfo, 0);

                ret = FaceSdk.Face_StartTrajectory(0, _trajectInfo, 0);
                if (ret != 0)
                    return ret;

            }
            catch (Exception)
            {
            }
            return ret;
        }
    }
}
