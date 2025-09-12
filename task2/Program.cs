using System;
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Enter numbers: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter rotate: ");
        int r = int.Parse(Console.ReadLine());
        int[] sum = new int[n];
        // Основний цикл: робимо r поворотів
        for (int i = 0;i < r; i++)
        {
            int[] rotated = new int[n];
            // Поворот вправо на 1 позицію
            // Останній елемент стає першим
            rotated[0] = numbers[n - 1];
            // Решта елементів зсуваємо на 1 позицію вправо
            for (int j = 1; j < n; j++)
            {
                rotated[j] = numbers[j - 1];
            }
            for (int b = 0;b < n; b++)
            {
                sum[b] += rotated[b];
            }
            // Оновлюємо масив numbers для наступного повороту
            numbers = rotated;
            Console.WriteLine("After rotation " + (i + 1) + ": " + string.Join(" ", numbers));     
        }
        Console.WriteLine("After sum: " + string.Join(" ", sum));

    }
    }

