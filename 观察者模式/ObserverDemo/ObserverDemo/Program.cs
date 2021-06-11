using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化目标
            Subject subject = new Cat();
            //实例化观察者
            IObserver mouse = new Mouse();
            IObserver master = new Master();
            //将观察者放到集合中
            subject.AddObserver(obs: mouse);
            subject.AddObserver(obs: master);
            subject.Call();
            Console.Read();
        }
    }
}
