using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static int FindKthElement_Sort(int[] array, int k)
    {
        Array.Sort(array);
        return array[k - 1];
    }

    static int FindKthElement_Insertion(int[] array, int k)
    {
        int[] temp = new int[k];
        Array.Copy(array, temp, k);
        Array.Sort(temp);

        for (int i = k; i < array.Length; i++)
        {
            if (array[i] < temp[k - 1])
            {
                temp[k - 1] = array[i];
                Array.Sort(temp);
            }
        }
        return temp[k - 1];
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 10000);
        }
        return array;
    }

    static void Main()
    {
        int[] sizes = { 100, 500, 1000, 2000, 5000 };
        int k = 10;

        foreach (int size in sizes)
        {
            int[] array = GenerateRandomArray(size);

            Stopwatch stopwatch = Stopwatch.StartNew();
            int kthElement1 = FindKthElement_Sort((int[])array.Clone(), k);
            stopwatch.Stop();
            Console.WriteLine($"Array Size: {size}, Sort Method Time: {stopwatch.ElapsedMilliseconds} ms, Kth Element: {kthElement1}");

            stopwatch.Restart();
            int kthElement2 = FindKthElement_Insertion((int[])array.Clone(), k);
            stopwatch.Stop();
            Console.WriteLine($"Array Size: {size}, Insertion Method Time: {stopwatch.ElapsedMilliseconds} ms, Kth Element: {kthElement2}");
        }
    }
}
