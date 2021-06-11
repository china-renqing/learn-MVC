using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStockDemo
{
    /// <summary>
    /// 目标
    /// </summary>
    public class Subject
    {

        public Subject(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// 股票价格
        /// </summary>
        public float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// 设置股票的名字
        /// </summary>
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 将所有的观察者放到目标中，方便后续通知
        /// </summary>
        private IList<IObserver> obsList = new List<IObserver>();

        /// <summary>
        /// 添加观察者（这里具体指的就是股民了）
        /// </summary>
        public void AddShareHolder(IObserver obs)
        {
            obsList.Add(item: obs);
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        public void RemoveShareHolder(IObserver obs)
        {
            obsList.Remove(item: obs);
        }

        /// <summary>
        /// 股票价格浮动变化
        /// price：该price接收的是当前股票的价格
        /// </summary>
        public virtual void StockChange(float newPrice)
        {
            foreach (var item in obsList)
            {
                //通知每一个观察者
                item.Remind(name, newPrice);
            }
        }
    }
}
