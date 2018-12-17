using FaceApp.Common;
using FaceApp.Model;
using System;
using System.Collections.Generic;
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
        int curFaceCtrlId = 1;
        public FaceModel FaceCtrl { get; set; }
        public FaceObject(int ctrlID)
        {
            curFaceCtrlId = ctrlID;
            FaceCtrl = new FaceModel();
            FaceCtrl.Id = "ID号:000" + curFaceCtrlId.ToString();
            FaceCtrl.Sex = "性别：女";
            FaceCtrl.Age = "青年";
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
                NotifyChange();
            }
        }
    }
}
