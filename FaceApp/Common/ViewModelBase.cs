using System;
using System.ComponentModel;

namespace FaceApp.Common
{
    /// <summary>
    /// ViewModelBase 继承INotifyPropertyChanged接口，响应绑定通知
    /// </summary>
    [Serializable]
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Property

        /// <summary>
        /// 关联对象
        /// </summary>
        public ViewModelBase RelationObject { get; set; }

        #endregion

        #region INotifyPropertyChanged Members

        /// <summary>
        /// 实现PropertyChanged事件
        /// </summary>
        [field: NonSerializedAttribute]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 封装PropertyChanged触发方法，触发所有属性
        /// </summary>
        public virtual void NotifyChange()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(null));
        }

        /// <summary>
        /// 封装PropertyChanged触发方法，触发指定属性
        /// </summary>
        /// <param name="propertyName">通知的属性名</param>
        public virtual void NotifyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// 封装PropertyChanged触发方法，触发指定属性并传递指定对象
        /// </summary>
        /// <param name="sender">对象</param>
        /// <param name="propertyName">通知的属性名</param>
        public virtual void NotifyChange(object sender, string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(sender, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
