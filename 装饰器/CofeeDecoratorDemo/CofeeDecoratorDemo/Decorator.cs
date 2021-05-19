///////////////////////////////////////////////////////////
//  Decorator.cs
//  Implementation of the Class Decorator
//  Generated by Enterprise Architect
//  Created on:      18-5月-2021 9:51:38
//  Original author: Ren
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using CofeeDecoratorDemo;
namespace CofeeDecoratorDemo
{
    public class Decorator : Coffee
    {

        private CofeeDecoratorDemo.Coffee decor;

        /// <summary>
        /// 注入方法
        /// </summary>
        /// <param name="coffee"></param>
        public Decorator(Coffee coffee)
        {
            this.decor = coffee;
        }

        /// <summary>
        /// 计算咖啡i代码
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public override float Cacl(int number)
        {
            //通过关联关系去调用原来对象的计算方法
            return decor.Cacl(number);

        }

    }//end Decorator

}//end namespace CofeeDecoratorDemo