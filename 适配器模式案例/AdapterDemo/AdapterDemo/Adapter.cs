using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AdapterDemo;
namespace AdapterDemo
{
    public class Adapter : ICat
    {
        protected Dog dog;
        /// <summary>
        /// ����������ע��
        /// </summary>
        /// <param name="dog"></param>
        public Adapter(Dog dog)
        {
            this.dog = dog;
        }
        /// <summary>
        /// ʵ��èѧ����
        /// </summary>
        public void Miao()
        {
            Console.WriteLine("è�俪ʼ����������:");
            dog.Cry();
        }

    }//end Adapter

}//end namespace AdapterDemo