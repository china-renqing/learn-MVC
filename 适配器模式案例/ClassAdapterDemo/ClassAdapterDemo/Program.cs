using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassAdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化适配器
            ICat entity = new Adapter();
            //适配器调用方法输出
            entity.Miao();
            Console.Read();
        }
    }
}
