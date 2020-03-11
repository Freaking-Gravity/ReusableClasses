using System;

namespace Generic_Linear_Search
{
    public class LinearSearch
    {
        private static int Search<T>(T[] arr, T search) where T : IComparable<T>
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(search) == 0)
                    return i;
            }
            return -1;


        }
    }
}
