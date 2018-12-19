using FaceApp.Common;
using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FaceApp.ViewModel
{
    class FaceOperator:ViewModelBase
    {
        int curIndex = 0;
        int oldId = 0;

        string _childrenRange = ConfigurationManager.AppSettings["Children"];
        string _juvenileRange = ConfigurationManager.AppSettings["Juvenile"];
        string _youthRange = ConfigurationManager.AppSettings["Youth"];
        string _midageRange = ConfigurationManager.AppSettings["Midage"];
        string _primelifeRange = ConfigurationManager.AppSettings["Primelife"];
        string _oldageRange = ConfigurationManager.AppSettings["Oldage"];

        System.Timers.Timer timer;
        public FaceOperator()
        {
            faceObjOne = new FaceObject(1);
            faceObjTwo = new FaceObject(2);
            faceObjThree = new FaceObject(3);
            faceObjFour = new FaceObject(4);
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timeFunc);//到达时间的时候执行事件；
            timer.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            timer.Enabled = true;
            timer.Start();
            SetObjectInfo(faceObjOne, 1, 10, SexType.Male);

//             BitmapImage bitmapImage = new BitmapImage();
//             bitmapImage.BeginInit();  //给BitmapImage对象赋予数据的时候，需要用BeginInit()开始，用EndInit()结束
//             bitmapImage.UriSource = new Uri(@"D:\work\Face\FaceApp\FaceApp_2\FaceApp\bin\x64\Debug\tempImage\image_0.bmp");
//             bitmapImage.EndInit();
//             ImageSource imageSource = bitmapImage as ImageSource;
//             faceObjOne.FaceImage = imageSource;
        }
        //判断faceObjOne，faceObjTwo，faceObjThree，faceObjFour是否使用，也就是判断界面是否空闲
        private void timeFunc(object source, System.Timers.ElapsedEventArgs e)
        {
        }

        private FaceObject faceObjOne;
        public FaceObject FaceObjOne
        {
            get
            {
                return faceObjOne;
            }
            set
            {
                faceObjOne = value; NotifyChange();
            }
        }

        private FaceObject faceObjTwo;
        public FaceObject FaceObjTwo
        {
            get
            {
                return faceObjTwo;
            }
            set
            {
                faceObjTwo = value; NotifyChange();
            }
        }

        private FaceObject faceObjThree;
        public FaceObject FaceObjThree
        {
            get
            {
                return faceObjThree;
            }
            set
            {
                faceObjThree = value; NotifyChange();
            }
        }

        private FaceObject faceObjFour;
        public FaceObject FaceObjFour
        {
            get
            {
                return faceObjFour;
            }
            set
            {
                faceObjFour = value; NotifyChange();
            }
        }
        private void SetObjectInfo(FaceObject obj, int id, int age, SexType sex)
        {
            string[] _childrenArray = _childrenRange.Split(',');
            string[] _juvenileArray = _juvenileRange.Split(',');
            string[] _youthArray = _youthRange.Split(',');
            string[] _midageArray = _midageRange.Split(',');
            string[] _primelifeArray = _primelifeRange.Split(',');
            string[] _oldageArray = _oldageRange.Split(',');

            if (int.Parse(_childrenArray[0])<= age && age<= int.Parse(_childrenArray[1]))
                obj.FaceCtrl.Age = "儿童";
            else if(int.Parse(_juvenileArray[0]) <= age && age <= int.Parse(_juvenileArray[1]))
                obj.FaceCtrl.Age = "少年";
            else if (int.Parse(_youthArray[0]) <= age && age <= int.Parse(_youthArray[1]))
                obj.FaceCtrl.Age = "青年";
            else if (int.Parse(_midageArray[0]) <= age && age <= int.Parse(_midageArray[1]))
                obj.FaceCtrl.Age = "中年";
            else if (int.Parse(_primelifeArray[0]) <= age && age <= int.Parse(_primelifeArray[1]))
                obj.FaceCtrl.Age = "壮年";
            else if (int.Parse(_oldageArray[0]) <= age)
                obj.FaceCtrl.Age = "老年";

            obj.FaceCtrl.Id = "ID:000" + id.ToString();
            obj.FaceCtrl.Sex = "性别：" + (sex==SexType.Female?"女":"男");
        }
        public void SetFaceObjetInfo(int age, SexType sex, int id)
        {
//             if (id == (FaceObjOne.curFaceCtrlId-1))
//             {
//                 SetObjectInfo(FaceObjOne, id, age, sex);
//             }
//             else if (id == (faceObjTwo.curFaceCtrlId - 1))
//             {
//                 SetObjectInfo(faceObjTwo, id, age, sex);
//             }
//             else if (id == (faceObjThree.curFaceCtrlId-1))
//             {
//                 SetObjectInfo(faceObjThree, id, age, sex);
//             }
//             else if (id == (faceObjFour.curFaceCtrlId - 1))
//             {
//                 SetObjectInfo(faceObjFour, id, age, sex);
//             }
//             else
            {
                if (curIndex == 0)
                {
                    SetObjectInfo(FaceObjOne, id, age, sex);
                }
                else if (curIndex == 1)
                {
                    SetObjectInfo(faceObjTwo, id, age, sex);
                }
                else if (curIndex == 2)
                {
                    SetObjectInfo(faceObjThree, id, age, sex);
                }
                else if (curIndex == 3)
                {
                    SetObjectInfo(faceObjFour, id, age, sex);
                }
            }
            if (curIndex >= 3) curIndex = 0;
            else curIndex++;
        }
        public void SetFaceImage(int id, string imagePath)
        {
            if (id == 0)
                faceObjOne.SetFaceImage(imagePath);
            else if(id == 1)
                faceObjTwo.SetFaceImage(imagePath);
            else if (id == 2)
                faceObjThree.SetFaceImage(imagePath);
            else if (id == 3)
                faceObjFour.SetFaceImage(imagePath);
        }

        public void SetInfoAndImage(int age, SexType sex, int id, string imagePath)
        {
            if (oldId != id)
            {
//                 for (int i = curIndex; i < 4; i++)
//                 {
//                     if (curIndex == 0)
//                     {
//                         faceObjOne.SetFaceImage("");
//                     }
//                     else if (curIndex == 1)
//                     {
//                         faceObjTwo.SetFaceImage("");
//                     }
//                     else if (curIndex == 2)
//                     {
//                         faceObjThree.SetFaceImage("");
//                     }
//                     else if (curIndex == 3)
//                     {
//                         faceObjFour.SetFaceImage("");
//                     }
//                 }
                curIndex = 0;
                oldId = id;
            }
            if (curIndex == 0)
            {
                SetObjectInfo(FaceObjOne, 1, age, sex);
                faceObjOne.SetFaceImage(imagePath);
            }
            else if (curIndex == 1)
            {
                SetObjectInfo(faceObjTwo, 2, age, sex);
                faceObjTwo.SetFaceImage(imagePath);
            }
            else if (curIndex == 2)
            {
                SetObjectInfo(faceObjThree, 3, age, sex);
                faceObjThree.SetFaceImage(imagePath);
            }
            else if (curIndex == 3)
            {
                SetObjectInfo(faceObjFour, 4, age, sex);
                faceObjFour.SetFaceImage(imagePath);
            }
            if (curIndex >= 3) curIndex = 0;
            else curIndex++;
        }
    }
}
