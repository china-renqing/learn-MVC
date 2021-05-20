
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CofeeDecoratorDemo;
namespace CofeeDecoratorDemo
{
    public class Milk : Decorator
    {
        /// <summary>
        /// 构造函数给父类的构造函数赋值
        /// </summary>
        /// <param name="coffe">注入的具体咖啡</param>
        public Milk(Coffee coffe) : base(coffe)
        {

        }
        /// <summary>
        /// 计算装饰后的价格
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public override float Cacl(int number)
        {
            float allMoney = base.Cacl(number) + this.Price * number;
            Console.WriteLine("添加了牛奶!");
            return allMoney;
        }
        /// <summary>
        /// 设置或获取牛奶的价格
        /// </summary>
        public override float Price
        {
            get;
            set;
        }
    }//end Milk

}//end namespace CofeeDecoratorDemo