using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ClassAdapterDemo;
namespace ClassAdapterDemo
{
    public class Adapter : Dog, ICat
    {
        /// <summary>
        /// 适配器中猫咪的学叫实现
        /// </summary>
        public void Miao()
        {
            Console.WriteLine("小猫开始发声音了！");
            base.Cry();
        }

    }//end Adapter

}//end namespace ClassAdapterDemo