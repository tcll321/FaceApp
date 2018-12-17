using FaceApp.Common;
using FaceApp.Model;
using System;
using System.Collections.Generic;
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
            if (3<=age && age<=11)
                obj.FaceCtrl.Age = "儿童";
            else if(12 <= age && age <= 17)
                obj.FaceCtrl.Age = "少年";
            else if (18 <= age && age <= 34)
                obj.FaceCtrl.Age = "青年";
            else if (35 <= age && age <= 44)
                obj.FaceCtrl.Age = "中年";
            else if (45 <= age && age <= 99)
                obj.FaceCtrl.Age = "壮年";
            else if (100 <= age)
                obj.FaceCtrl.Age = "老年";

            obj.FaceCtrl.Id = id.ToString();
            obj.FaceCtrl.Sex = "性别：" + (sex==SexType.Female?"女":"男");
        }
        public void SetFaceObjetInfo(int age, SexType sex, int id)
        {
            if (id.ToString() == FaceObjOne.FaceCtrl.Id)
            {
                SetObjectInfo(FaceObjOne, id, age, sex);
            }
            else if (id.ToString() == faceObjTwo.FaceCtrl.Id)
            {
                SetObjectInfo(faceObjTwo, id, age, sex);
            }
            else if (id.ToString() == faceObjThree.FaceCtrl.Id)
            {
                SetObjectInfo(faceObjThree, id, age, sex);
            }
            else if (id.ToString() == faceObjFour.FaceCtrl.Id)
            {
                SetObjectInfo(faceObjFour, id, age, sex);
            }
            else
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
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();  //给BitmapImage对象赋予数据的时候，需要用BeginInit()开始，用EndInit()结束
            bitmapImage.UriSource = new Uri(imagePath);
            bitmapImage.EndInit();
            ImageSource imageSource = bitmapImage as ImageSource;
            if (id == 0)
                faceObjOne.FaceImage = imageSource;
            else if(id == 1)
                faceObjTwo.FaceImage = imageSource;
            else if (id == 2)
                faceObjThree.FaceImage = imageSource;
            else if (id == 3)
                faceObjFour.FaceImage = imageSource;
        }
    }
}
