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
        /// ��������è���ѧ��ʵ��
        /// </summary>
        public void Miao()
        {
            Console.WriteLine("Сè��ʼ�������ˣ�");
            base.Cry();
        }

    }//end Adapter

}//end namespace ClassAdapterDemo