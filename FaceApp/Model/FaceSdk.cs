using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public enum SexType
    {
        Female=0,
        Male
    };

    public struct _FaceInfoStruct
    {
        public int age; //年龄
        public int sex; //性别
    }

    public struct _TrajectoryStruct
    {
        public int total;//总人数
        public int fall;  //跌倒
        public int punch; //出拳
        public int raise; //举手
        public int nTracker; //当前图片中的人数
        public int id;         //id
        public int x;          //x坐标
        public int y;          //y坐标
        public int body_x;
        public int body_y;
        public int body_w;
        public int body_h;
        public int motion;     //运动姿态 punch出拳(双臂展开) = 1, raise_hand = 2(打招呼), fall = 3
    }

    public class FaceSdk
    {
        private const string libPath = @".\FaceSdk.dll";

        public delegate void Callback_OnFaceInfo(int device, int sex, int age, int id, string faceImage, int userParam);
        [DllImport(libPath)]
        public static extern int Face_Init(out int deviceCnt);

        [DllImport(libPath)]
        public static extern int Face_Create(int device, int hwnd, Callback_OnFaceInfo info, int userParam);

        [DllImport(libPath)]
        public static extern int Face_SetFaceWnd(int wndID, int hwnd);

        [DllImport(libPath)]
        public static extern int Face_Delete(int device);

        [DllImport(libPath)]
        public static extern int Face_InitTrajectory();

        public delegate void  Callback_OnTrajectoryInfo(_TrajectoryStruct info, int userParam);

        [DllImport(libPath)]
        public static extern int Face_SetWnd(int hwndVideo, int hwndMap);

        [DllImport(libPath)]
        public static extern int Face_StartTrajectory(int hwnd, Callback_OnTrajectoryInfo info, int userParam);

        [DllImport(libPath)]
        public static extern void Face_StopTrajectory();
    }
}
