
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CofeeDecoratorDemo;
namespace CofeeDecoratorDemo
{
    public class Milk : Decorator
    {
        /// <summary>
        /// ���캯��������Ĺ��캯����ֵ
        /// </summary>
        /// <param name="coffe">ע��ľ��忧��</param>
        public Milk(Coffee coffe) : base(coffe)
        {

        }
        /// <summary>
        /// ����װ�κ�ļ۸�
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public override float Cacl(int number)
        {
            float allMoney = base.Cacl(number) + this.Price * number;
            Console.WriteLine("�����ţ��!");
            return allMoney;
        }
        /// <summary>
        /// ���û��ȡţ�̵ļ۸�
        /// </summary>
        public override float Price
        {
            get;
            set;
        }
    }//end Milk

}//end namespace CofeeDecoratorDemo