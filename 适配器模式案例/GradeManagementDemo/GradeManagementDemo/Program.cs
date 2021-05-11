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
            //动态准备数据：
            //方法一：
            //Console.WriteLine("请输入成绩，多个值之间用，分开");
            //string receiveScore = Console.ReadLine();
            //int[] allGrade = null;
            ////对输入的结果进行拆分,转换操作,变为后续可用数据
            //if (!string.IsNullOrEmpty(receiveScore))
            //{
            //    //拆分成数组
            //    string[] tempScore = receiveScore.Split(new char[] { ',', '，' },
            //        StringSplitOptions.RemoveEmptyEntries);

            //    allGrade = new int[tempScore.Length];
            //    for (int i = 0; i < tempScore.Length; i++)
            //    {
            //        allGrade[i] = int.Parse(tempScore[i]);
            //    }

            //}

            //方法二
            Console.WriteLine("请输入成绩，每行输入一个，输入-1结束");
            List<int> listScore = new List<int>();
            //对输入进行处理,筛选符合条件的和不结束的条件
            while (1 == 1)
            {
                string temp = Console.ReadLine();
                //如果什么都没有输入,则continue
                if (string.IsNullOrEmpty(temp))
                    continue;
                //如果是-1直接结束
                if (temp == "-1") break;

                int tScore = -1;
                //尝试转换,成功复制给tScore,失败tScore为-1,下方进行判断是否continue
                int.TryParse(temp, out tScore);
                if (tScore == -1)
                    continue;

                listScore.Add(tScore);
            }
            //将获取的数组转换成int[]类型,方便后续使用
            int[] allGrade = listScore.ToArray();


            //准备数据
            //int[] allGrade = new int[] { 100, 90, 99, 68, 93, 97 };
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
            int[] result = entity.Sort(allGrade);
            Console.Write("排序后的结果:");
            foreach (var item in result)
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
