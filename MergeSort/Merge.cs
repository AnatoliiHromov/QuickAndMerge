using System.Linq;

namespace CSort
{
    public class Merge
    {
        public int iterCount = 0;
        public int[] Sort(int[] arr)
        {
            int[] array = (int[])arr.Clone();
            if (array.Length == 1)
                return array;
            int mid_point = array.Length / 2;
            return Merging(Sort(array.Take(mid_point).ToArray()), Sort(array.Skip(mid_point).ToArray()));
        }
        int[] Merging(int[] arr1, int[] arr2)
        {            
            int a = 0, b = 0;
            int[] merged = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                iterCount++;
                if (b.CompareTo(arr2.Length) < 0 && a.CompareTo(arr1.Length) < 0)
                {
                    if (arr1[a].CompareTo(arr2[b]) > 0)
                        merged[i] = arr2[b++];
                    else
                        merged[i] = arr1[a++];
                }
                else if (b < arr2.Length)
                {                   
                    merged[i] = arr2[b++];
                }
                else
                {                    
                    merged[i] = arr1[a++];
                }
            }
            return merged;
        }
       
    }
}
