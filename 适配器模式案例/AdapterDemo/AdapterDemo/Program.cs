using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICat entity = new Adapter(new Dog());
            entity.Miao();
            Console.Read();
        }
    }
}
