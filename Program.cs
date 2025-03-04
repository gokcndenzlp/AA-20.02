using System;
using System.Diagnostics;

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
    }

    static void Main()
    {
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
        }
    }
}
