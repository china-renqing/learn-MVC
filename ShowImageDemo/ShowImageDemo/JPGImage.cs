///////////////////////////////////////////////////////////
//  JPGImage.cs
//  Implementation of the Class JPGImage
//  Generated by Enterprise Architect
//  Created on:      11-5月-2021 12:27:17
//  Original author: Ren
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using ShowImageDemo;
namespace ShowImageDemo
{
    public class JPGImage : IPainImage
    {
        /// <summary>
        /// 完成绘图
        /// </summary>
        /// <param name="m"></param>
        public void DoPain(Matrix m)
        {
            Console.WriteLine("这里通过接收到像素矩阵后,完成了对JPG图片的显示！");

        }

    }//end JPGImage

}//end namespace ShowImageDemo