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
            int[] testArray2 = { 5, 1, 2, 4, 3 };
            var ans2 = ReverseSort(testArray);
            foreach (int i in ans2)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] Sort(int[] array)
        {
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                //mark the lowest found so far
                //starting out, it will be the first element
                //after the first iteration, set min to the next element to process.
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    //Every time we visit a new element, compare it to the 
                    //smallest seen so far. If the new element is smaller, 
                    //replace the min with it.
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                //Ok, now we know the min of what's left in the array. 
                //But, we don't want to overwrite values we still need.
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }

            return array;
        }
        public static int[] ReverseSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex])
                    {
                        // Update the index of the maximum value found
                        maxIndex = j;
                    }
                }

                // Swap the elements at i and maxIndex
                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }

            return array;
        }




    }
}
