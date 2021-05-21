using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualComponentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成一个LIstBox
            VisualComponent entity = new ListBox();
            //为ListBox添加Border
            VisualComponent entity2 = new BorderDecorator(entity);

            //为ListBox添加Scroll
            VisualComponent entity3 = new ScrollBarDecorator(entity2);
            //在这里进行渲染
            entity3.Display();
            Console.Read();
        }
    }
}
