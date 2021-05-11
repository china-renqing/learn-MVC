using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShowImageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //设置当前下的系统
            //MySystems os = new Windows();
            MySystems os = (MySystems)Assembly.Load("ShowImageDemo").
                CreateInstance(ConfigurationManager.AppSettings["nowSystem"]);
            //设置需要画布画出的图画格式
            IPainImage images = (IPainImage)Assembly.Load("ShowImageDemo").
                CreateInstance(ConfigurationManager.AppSettings["imageType"]);

            //设置图片格式、类型
            os.SetImage(images);

            //传入图片
            os.ParseFile("中国地图.png");
            Console.Read();
        }
    }
}
