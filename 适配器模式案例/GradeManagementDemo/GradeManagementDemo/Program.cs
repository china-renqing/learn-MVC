using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManagementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //准备数据
            int[] allGrade = new int[] { 100, 90, 99, 68, 93, 97 };
            //获得排序和查询工具
            IScoreOperation entity = new Adapter();

            //输出未排序的成绩
            Console.Write("输出未排序的成绩:");
            foreach (var item in allGrade)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            //获取排序后的成绩
            entity.Sort(allGrade);
            Console.Write("排序后的结果:");
            foreach (var item in allGrade)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            //分别用查询工具中的Search()方法进行查询是否含有成绩130和97,有返回true,没有返回false;
            Console.WriteLine("查询所有成绩当中是否有130的成绩：{0}", entity.Search(allGrade, 130) > 0 ? "true" : "false");
            Console.WriteLine("查询所有成绩当中是否有97的成绩：" + (entity.Search(allGrade, 97) > 0 ? "true" : "false"));
            Console.Read();

        }
    }
}
