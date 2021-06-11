using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStockDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化目标
            Subject subject = new Stock(name: "中国工商银行", price: 1000);
            //创建两个观察者（股民）
            IObserver user1 = new ShareHolders();
            IObserver user2 = new ShareHolders();
            //以下两个写法同样是实现了向目标中添加观察者
            subject.AddShareHolder(user1);
            subject.AddShareHolder(obs: user2);

            //输入当前的股票价格，股票进行判断，是否给观察者发送消息，当浮动大于5%时就会发送消息
            subject.StockChange(1030);

            //股票降幅5%
            subject.StockChange(949);
            //股票增幅5%
            subject.StockChange(1051);
            Console.Read();
        }
    }
}
