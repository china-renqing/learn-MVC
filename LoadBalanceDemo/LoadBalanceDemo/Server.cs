///////////////////////////////////////////////////////////
//  Server.cs
//  Implementation of the Class Server
//  Generated by Enterprise Architect
//  Created on:      11-5月-2021 9:07:18
//  Original author: Ren
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace LoadBalanceDemo
{
    public class Server
    {

        private string ip;
        private string name;

        public Server(string name, string ip)
        {
            this.name = name;
            this.ip = ip;
        }

        /// <summary>
        /// 服务器的IP地址
        /// </summary>
        public string Ip
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }

        /// <summary>
        /// 服务器的名称
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }//end Server

}//end namespace LoadBalanceDemo