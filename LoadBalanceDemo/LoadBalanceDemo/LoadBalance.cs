///////////////////////////////////////////////////////////
//  LoadBalance.cs
//  Implementation of the Class LoadBalance
//  Generated by Enterprise Architect
//  Created on:      11-5月-2021 9:07:16
//  Original author: Ren
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using LoadBalanceDemo;
using System.Threading;

namespace LoadBalanceDemo
{
    public class LoadBalance
    {
        private static LoadBalance instance;
        private IList<Server> serverList;
        private static readonly object isLock = new object();

        /// <summary>
        /// 在私有构造函数中进行serverList的实例化
        /// </summary>
        private LoadBalance()
        {
            serverList = new List<Server>();
        }

        /// <summary>
        /// 用共有静态保证整个程序中,该LoadBalance只能实例化一次
        /// </summary>
        /// <returns></returns>
        public static LoadBalance GetLoadBalance()
        {

            //判断实例是否存在,不存在再加锁处理
            if (instance == null)
            {
                //加锁的程序在某一刻只允许一个线程访问
                lock (isLock)
                {
                    //第二重判断
                    if (instance == null)
                    {
                        instance = new LoadBalance();   //创建实例
                    }
                }
                instance = new LoadBalance();
            }
            return instance;

        }
        /// <summary>
        /// 通过传入的服务器,增加服务器到该实例中
        /// </summary>
        /// <param name="server"></param>
        public void AddServer(Server server)
        {
            serverList.Add(server);
        }

        /// <summary>
        /// 获取所有的服务器
        /// </summary>
        /// <returns>返回所有的服务器</returns>
        public IList<Server> GetAllServer()
        {
            return serverList;
        }

        /// <summary>
        /// 获取一个随机服务
        /// </summary>
        /// <param name="server"></param>
        /// <returns>返回一个服务器</returns>
        public Server GetServer()
        {
            Random random = new Random();
            int i = random.Next(serverList.Count);
            //在这里写睡眠，主要是让每次的请求是随机的，否则以系统的运算速度，很容易复制给同一个服务器
            //这里也可以将random的定义写在方法的外部,也可以实现
            Thread.Sleep(10);
            return serverList[i];
        }
        /// <summary>
        /// 根据传入的server删除服务器
        /// </summary>
        /// <param name="server"></param>
        public void RemoveServer(Server server)
        {
            serverList.Remove(server);
        }



    }//end LoadBalance

}//end namespace LoadBalanceDemo