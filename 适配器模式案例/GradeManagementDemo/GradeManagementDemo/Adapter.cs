using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using GradeManagementDemo;
using ScoreLibs;
namespace GradeManagementDemo
{
    public class Adapter : IScoreOperation
    {
        protected BinarySearchClass binarySearch;
        protected QuickSortClass quickSort;

        /// <summary>
        /// 在构造函数中直接进行初始化
        /// binarySearch和quickSort
        /// </summary>
        public Adapter()
        {
            this.binarySearch = new BinarySearchClass();
            this.quickSort = new QuickSortClass();
        }

        public int Search(int[] allGrade, int id)
        {
            //该方法需要输入的所有数据和指定的值，当所有数据包含指定值时返回1，否则返回-1
            int result = binarySearch.BinarySearch(allGrade, id);
            return result;
        }

        public void Sort(int[] allGrade)
        {
            //该方法将传入的数组进行排序
            quickSort.QuickSort(allGrade);
        }

    }//end Adapter

}//end namespace GradeManagementDemo