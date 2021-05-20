using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeDecoratorDemo
{
    class Program
    {
        //定义全局变量,方便后续添加咖啡以及配料等操作
        public static string[] coffees = new string[] { "浓咖啡", "混合咖啡", "重烘焙咖啡" };
        public static int[] coffeePrice = new int[] { 25, 30, 20 };
        public static string[] others = new string[] { "摩卡", "奶泡", "牛奶" };
        public static int[] otherPrice = new int[] { 10, 8, 6 };
        static void Main(string[] args)
        {
            Coffee[] coffeeObj = new Coffee[] { new Espresso(), new HouseBlend(), new DarkRoast() };
            while (true)
            {
                Coffee entity;
                Console.WriteLine("请输选择您想要购买的咖啡的数字:");
                for (int i = 0; i < coffees.Length; i++)
                {
                    Console.Write("{0}.{1}    ", i + 1, coffees[i]);
                }
                //接收选择的咖啡
                Console.WriteLine();
                int choseCoffee = 0;
                //尝试转换,成功则为数字存入out的变量中,否则为out的变量为0
                int.TryParse(Console.ReadLine(), out choseCoffee);
                if (choseCoffee == 0 || choseCoffee > coffees.Length)
                {
                    Console.WriteLine("请正确输入范围内的咖啡！");
                    Console.Write("点击任意键位返回选择咖啡.......");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else
                {
                    //获取咖啡
                    entity = coffeeObj[choseCoffee - 1];
                    entity.Price = coffeePrice[choseCoffee - 1];
                    //选择配料
                    entity = ChoseOthers(entity);
                    //获取杯数
                    Console.WriteLine("请输入您想买的杯数:");
                    int numbers = int.Parse(Console.ReadLine());
                    float money = entity.Cacl(numbers);
                    Console.WriteLine("您最后的消费为:{0}", money);
                    break;
                }
            }
            Console.Read();
        }

        private static Coffee ChoseOthers(Coffee entity)
        {
            //获取配料有哪些
            Coffee[] otherObj = new Coffee[] { new Mocha(entity), new Whip(entity), new Milk(entity) };
            while (true)
            {
                Console.WriteLine("请输选择您想要购买的咖啡的数字,输入0退出选择配料!:");
                for (int i = 0; i < otherObj.Length; i++)
                {
                    Console.Write("{0}.{1}    ", i + 1, others[i]);
                }
                //接收选择的配料
                Console.WriteLine();
                int choseOther;
                int.TryParse(Console.ReadLine(), out choseOther);
                if (choseOther > coffees.Length)
                {
                    Console.WriteLine("请正确输入范围内的咖啡,输入0退出选择配料!");
                    continue;
                }
                else if (choseOther == 0)
                {
                    Console.WriteLine("返回上一级中...");
                    break;
                }
                else
                {
                    //获取配料
                    entity = otherObj[choseOther - 1];
                    entity.Price = otherPrice[choseOther - 1];
                    //选择配料
                    entity = ChoseOthers(entity);
                    break;
                }
            }
            return entity;
        }
    }
}
