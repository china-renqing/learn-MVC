using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStockDemo
{
    /// <summary>
    /// 观察者
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 观察者的通知方法，具体子类进行实现。
        /// </summary>
        void Remind(string name, float price);
    }
}
