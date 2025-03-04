using System;
using System.Diagnostics;
<<<<<<< HEAD
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
=======

class Program
{
    // Bubble Sort Algoritması
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Elemanları yer değiştir
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Rastgele bir dizi oluştur
    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 10001); // 1 ile 10000 arasında rastgele sayılar
        }
        return arr;
>>>>>>> f4d4ebcecbf5e9bcb430b7040e23d8cc64c55fd6
    }

    static void Main()
    {
<<<<<<< HEAD
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
=======
        // Farklı dizi boyutları
        int[] sizes = { 100, 500, 1000, 5000, 10000 };

        // Zaman ölçümü için Stopwatch kullanılıyor
        Stopwatch stopwatch = new Stopwatch();

        foreach (var size in sizes)
        {
            // Rastgele dizi oluştur
            int[] arr = GenerateRandomArray(size);

            // Zamanı başlat
            stopwatch.Start();

            // Bubble Sort çalıştır
            BubbleSort(arr);

            // Zamanı durdur
            stopwatch.Stop();

            // Geçen süreyi yazdır
            Console.WriteLine($"Dizi Boyutu: {size}, Süre: {stopwatch.ElapsedMilliseconds} ms");

            // Stopwatch'ı sıfırla
            stopwatch.Reset();
>>>>>>> f4d4ebcecbf5e9bcb430b7040e23d8cc64c55fd6
        }
    }
}
