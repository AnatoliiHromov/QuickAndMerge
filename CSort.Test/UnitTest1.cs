using CSort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class Tests
    {
        int[] ReadArray(string path, int length)
        {
            int[] arr = new int[length];
            using (StreamReader sr = new StreamReader(path))
            {
                string[] words = sr.ReadToEnd().Split(' ');
                for (int i = 0; i < length; i++)
                {
                    arr[i] = int.Parse(words[i]);
                }
            }
            return arr;
        }
        int[] sortArray1;
        int[] sortArray2;
        int[] sortArray3;
        int[] sortArray4;
        int[] sortArray5;
        int[] sorted1;
        int[] sorted2;
        int[] sorted3;
        int[] sorted4;
        int[] sorted5;
        List<int> sortList1;
        List<int> sortList2;
        List<int> sortList3;
        List<int> sortList4;
        List<int> sortList5;
        [SetUp]
        public void Setup()
        {
            sortArray1 = ReadArray("Arr1.txt", 100);
            sortArray2 = ReadArray("Arr2.txt", 1000);
            sortArray3 = ReadArray("Arr3.txt", 5000);
            sortArray4 = ReadArray("Arr4.txt", 10000);
            sortArray5 = ReadArray("Arr5.txt", 1000000);
            sorted1 = (int[])sortArray1.Clone();
            sorted2 = (int[])sortArray2.Clone();
            sorted3 = (int[])sortArray3.Clone();
            sorted4 = (int[])sortArray4.Clone();
            sorted5 = (int[])sortArray5.Clone();
            Array.Sort(sorted1);
            Array.Sort(sorted2);
            Array.Sort(sorted3);
            Array.Sort(sorted4);
            Array.Sort(sorted5);
            sortList1 = new List<int>(sortArray1);
            sortList2 = new List<int>(sortArray2);
            sortList3 = new List<int>(sortArray3);
            sortList4 = new List<int>(sortArray4);
            sortList5 = new List<int>(sortArray5);
        }

        [Test]
        public void NetMergeSort1()
        {
            Merge m = new Merge();
            int[] sorted =m.Sort(sortArray1);
            Console.WriteLine("Count of iterations:"+m.iterCount);
            Assert.AreEqual(sorted,sorted1);
        }
        [Test]
        public void NetMergeSort2()
        {
            Merge m = new Merge();
            int[] sorted = m.Sort(sortArray2);
            Console.WriteLine("Count of iterations:" + m.iterCount);
            Assert.AreEqual(sorted, sorted2);
        }
        [Test]
        public void NetMergeSort3()
        {
            Merge m = new Merge();
            int[] sorted = m.Sort(sortArray3);
            Console.WriteLine("Count of iterations:" + m.iterCount);
            Assert.AreEqual(sorted, sorted3);
        }
        [Test]
        public void NetMergeSort4()
        {
            Merge m = new Merge();
            int[] sorted = m.Sort(sortArray4);
            Console.WriteLine("Count of iterations:" + m.iterCount);
            Assert.AreEqual(sorted, sorted4);
        }
        [Test]
        public void NetMergeSort5()
        {
            Merge m = new Merge();
            int[] sorted = m.Sort(sortArray5);
            Console.WriteLine("Count of iterations:" + m.iterCount);
            Assert.AreEqual(sorted, sorted5);
        }
        [Test]
        public void NetQuickSort1()
        {
            Quick q = new Quick();
            List<int> sorted = q.Sort(sortList1);
            Console.WriteLine("Count of iterations:" + q.iterCount);
            Assert.AreEqual(sorted, new List<int>(sorted1));
        }
        [Test]
        public void NetQuickSort2()
        {
            Quick q = new Quick();
            List<int> sorted = q.Sort(sortList2);
            Console.WriteLine("Count of iterations:" + q.iterCount);
            Assert.AreEqual(sorted, new List<int>(sorted2));
        }
        [Test]
        public void NetQuickSort3()
        {
            Quick q = new Quick();
            List<int> sorted = q.Sort(sortList3);
            Console.WriteLine("Count of iterations:" + q.iterCount);
            Assert.AreEqual(sorted, new List<int>(sorted3));
        }
        [Test]
        public void NetQuickSort4()
        {
            Quick q = new Quick();
            List<int> sorted = q.Sort(sortList4);
            Console.WriteLine("Count of iterations:" + q.iterCount);
            Assert.AreEqual(sorted, new List<int>(sorted4));
        }
        [Test]
        public void NetQuickSort5()
        {
            Quick q = new Quick();
            List<int> sorted = q.Sort(sortList5);
            Console.WriteLine("Count of iterations:" + q.iterCount);
            Assert.AreEqual(sorted, new List<int>(sorted5));
        }
    }
}