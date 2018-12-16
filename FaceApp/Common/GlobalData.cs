using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.Common
{
    class GlobalData
    {
        static GlobalData()
        {
            if (instance == null)
                instance = new GlobalData();
        }

        public static GlobalData instance;
        public GlobalData Instance
        {
            get { return instance; }
        }

        private List<Int32> faceImageHandle = new List<int>();
        public List<Int32> FaceImageHandle
        {
            get { return faceImageHandle; }
            set { faceImageHandle = value; }
        }

        private Int32 videoPtr;

        public Int32 VideoPtr
        {
            get
            {
                return videoPtr;
            }
            set
            {
                videoPtr = value;
            }
        }
    }
}
