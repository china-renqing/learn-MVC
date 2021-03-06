///////////////////////////////////////////////////////////
//  MySystems.cs
//  Implementation of the Class MySystems
//  Generated by Enterprise Architect
//  Created on:      11-5月-2021 12:27:22
//  Original author: Ren
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using ShowImageDemo;
namespace ShowImageDemo
{
    public abstract class MySystems
    {
        protected IPainImage image;


        /// <summary>
        /// 定义一个文件转换的抽象类,在不同的系统中,需要通过不同的转换方式去实现文件钻换
        /// </summary>
        public abstract void ParseFile(string fileName);

        /// <summary>
        /// 在这里使用方法注入的方式,使得它的子类可以调用接口IpainImage中的方法
        /// </summary>
        public void SetImage(IPainImage image)
        {
            this.image = image;
        }

    }//end MySystems

}//end namespace ShowImageDemo