using FaceApp.Common;
using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FaceApp.ViewModel
{
    class FaceObject : ViewModelBase
    {
        private string curFaceImage="";
        public int curFaceCtrlId = 1;
        public FaceModel FaceCtrl { get; set; }
        public FaceObject(int ctrlID)
        {
            curFaceCtrlId = ctrlID;
            FaceCtrl = new FaceModel();
            FaceCtrl.Id = "ID号:000" + curFaceCtrlId.ToString();
            FaceCtrl.Sex = "性别：女";
            FaceCtrl.Age = "青年";
            if(ctrlID == 1)
                SetFaceImage("./defultImage/1.png");
            else if (ctrlID == 2)
                SetFaceImage("./defultImage/2.png");
            else if (ctrlID == 3)
            {
                SetFaceImage("./defultImage/3.png");
                FaceCtrl.Sex = "性别：男";
            }
            else if (ctrlID == 4)
                SetFaceImage("./defultImage/4.png");
            else
                SetFaceImage("");
        }

        public void SetFaceImage(string faceImage)
        {
            try
            {

            if (faceImage == null)
            {
                object obj = Application.Current.Resources["FaceImageSource"];
                ImageSource imageSource = obj as ImageSource;
                imageSource.Clone();
                FaceImage = imageSource;
                FaceImage.Freeze();
                return;
            }
            if (faceImage == "")
            {
                object obj = Application.Current.Resources["FaceImageSource"];
                ImageSource imageSource = obj as ImageSource;
                imageSource.Clone();
                FaceImage = imageSource;
                FaceImage.Freeze();
                return;
            }

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();  //给BitmapImage对象赋予数据的时候，需要用BeginInit()开始，用EndInit()结束
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            using (Stream ms = new MemoryStream(File.ReadAllBytes(faceImage)))
            {
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();
                FaceImage = bitmapImage as ImageSource;
                FaceImage.Freeze();
            }
//             if (curFaceImage.Length>0)
//             {
//                 File.Delete(curFaceImage);
//             }
            }
            catch (Exception)
            {

            }

            curFaceImage = faceImage;
        }

        private ImageBrush _idImage;
        public ImageBrush IDImage
        {
            get
            {
                object obj = Application.Current.Resources[String.Format("FaceID_{0}Source", curFaceCtrlId)];
                ImageSource imageSource = obj as ImageSource;
                _idImage = new ImageBrush();
                _idImage.ImageSource = imageSource;
                return _idImage;
            }
            set
            {
                _idImage = value;
                NotifyChange();
            }
        }

        private ImageSource _backGroundImage;
        public ImageSource BackGroundImage
        {
            get
            {
                object obj = Application.Current.Resources[String.Format("BackGround_{0}Source", curFaceCtrlId)];
                ImageSource imageSource = obj as ImageSource;
                _backGroundImage = imageSource;
                return _backGroundImage;
            }
            set
            {
                _backGroundImage = value;
                NotifyChange();
            }
        }

        private ImageSource _faceImage = null;
        public ImageSource FaceImage
        {
            get
            {
                if (_faceImage == null)
                {
                    object obj = Application.Current.Resources["FaceImageSource"];
                    ImageSource imageSource = obj as ImageSource;
                    _faceImage = imageSource;
                }
                return _faceImage;
            }
            set
            {
                _faceImage = value;
//                 _faceImage.Freeze();
                NotifyChange();
            }
        }
    }
}
