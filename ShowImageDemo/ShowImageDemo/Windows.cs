///////////////////////////////////////////////////////////
//  Windows.cs
//  Implementation of the Class Windows
//  Generated by Enterprise Architect
//  Created on:      11-5��-2021 12:27:14
//  Original author: Ren
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ShowImageDemo;
namespace ShowImageDemo
{
    public class Windows : MySystems
    {
        public override void ParseFile(string fileName)
        {
            //ģ�����ͼƬ���������ؾ���m
            Matrix m = new Matrix();
            Console.WriteLine("��Windowsϵͳ�У���{0}ת���������ؾ���", fileName);
            image.DoPain(m);        //��������ø�����image�еĻ滭����,��ɻ滭.
        }
    }//end Windows

}//end namespace ShowImageDemo