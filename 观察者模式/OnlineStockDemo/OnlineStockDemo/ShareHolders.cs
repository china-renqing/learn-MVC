using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStockDemo
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ShareHolders : IObserver
    {
        /// <summary>
        /// 实现抽象观察者的通知方法
        /// </summary>
        public void Remind(string name, float price)
        {
            Console.WriteLine("尊敬的股民您好！您的购买的关于{0}的股票价格已经浮动了5%，现在的价格为：{1}", name, price);
        }


    }
}
