using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class FaceModel:ViewModelBase
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; NotifyChange(); }
        }

        private string age;
        public string Age
        {
            get { return age; }
            set { age = value; NotifyChange(); }
        }
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; NotifyChange(); }
        }
    }
}
