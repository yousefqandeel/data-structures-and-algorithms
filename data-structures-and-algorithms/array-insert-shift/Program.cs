using System;

namespace ArrayInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 42, 8, 15, 23, 42 };

            int[] res = insertShiftArray(arr, 16);

            foreach (int e in res)
            {
                Console.WriteLine(e);
            }
        }
        static int[] insertShiftArray(int[] arr, int values)
        {
            int[] result = new int[arr.Length + 1];
            int middle = (int)result.Length / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    result[i] = arr[i];
                }
                if (i == middle)
                {
                    result[i] = values;
                }
                if (i >= middle)
                {
                    result[i + 1] = arr[i];
                }

            }
            return result;
        }
    }
}
