using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeDecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //浓咖啡+摩卡+牛奶
            Coffee espresso, mocha, milk;
            //浓咖啡实例
            espresso = new Espresso();
            //定义价格
            espresso.Price = 25;
            //摩卡实例
            mocha = new Mocha(espresso);
            mocha.Price = 10;
            //牛奶实例
            milk = new Milk(mocha);
            milk.Price = 6;
            //计算总价格
            float allPrice = milk.Cacl(1);
            Console.WriteLine("您本次消费的价格为:" + allPrice);
            Console.Read();
        }
    }
}
