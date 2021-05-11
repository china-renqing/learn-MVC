using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalance balancer = LoadBalance.GetLoadBalance();
            balancer.AddServer(new Server("服务器1", "192.168.1.1"));
            balancer.AddServer(new Server("服务器2", "192.168.1.2"));
            balancer.AddServer(new Server("服务器3", "192.168.1.3"));
            balancer.AddServer(new Server("服务器4", "192.168.1.4"));
            balancer.AddServer(new Server("服务器5", "192.168.1.5"));
            balancer.AddServer(new Server("服务器6", "192.168.1.6"));

            //模拟客户端请求的分发
            for (int i = 0; i < 10; i++)
            {
                Server server = balancer.GetServer();
                Console.WriteLine("请求的服务器名称是：{0}，服务器的id是：{1}", server.Name, server.Ip);
            }
            Console.Read();

        }
    }
}
