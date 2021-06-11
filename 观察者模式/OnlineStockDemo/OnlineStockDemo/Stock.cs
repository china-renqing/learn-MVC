using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStockDemo
{
    /// <summary>
    /// 具体目标：股票
    /// </summary>
    public class Stock : Subject
    {

        public Stock(string name, float price) : base(name, price)
        {

        }
        public override void StockChange(float newPrice)
        {
            if (newPrice < price * 0.95)
            {
                Console.WriteLine("该股票的票价已经下降了5%！");
                base.StockChange(newPrice);
            }
            else if (newPrice > price * 1.05)
            {
                Console.WriteLine("该股票的票价已经上涨了5%！");
                base.StockChange(newPrice);
            }
            else
            {
                Console.WriteLine("该股票的价格浮动大小未超过5%，不做提示");
            }
        }
    }
}
