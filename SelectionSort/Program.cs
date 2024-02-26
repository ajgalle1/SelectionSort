using System;

namespace SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] testArray = { 5, 1, 2, 4, 3 };
            var ans = Sort(testArray);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

            return array;
        }
    }
}
