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
        /// 构造器方法注入
        /// </summary>
        /// <param name="dog"></param>
        public Adapter(Dog dog)
        {
            this.dog = dog;
        }
        /// <summary>
        /// 实现猫学狗叫
        /// </summary>
        public void Miao()
        {
            Console.WriteLine("猫咪开始发出了声音:");
            dog.Cry();
        }

    }//end Adapter

}//end namespace AdapterDemo