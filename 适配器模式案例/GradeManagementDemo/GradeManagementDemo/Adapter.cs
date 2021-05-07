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
        /// �ڹ��캯����ֱ�ӽ��г�ʼ��
        /// binarySearch��quickSort
        /// </summary>
        public Adapter()
        {
            this.binarySearch = new BinarySearchClass();
            this.quickSort = new QuickSortClass();
        }

        public int Search(int[] allGrade, int id)
        {
            //�÷�����Ҫ������������ݺ�ָ����ֵ�����������ݰ���ָ��ֵʱ����1�����򷵻�-1
            int result = binarySearch.BinarySearch(allGrade, id);
            return result;
        }

        public void Sort(int[] allGrade)
        {
            //�÷���������������������
            quickSort.QuickSort(allGrade);
        }

    }//end Adapter

}//end namespace GradeManagementDemo