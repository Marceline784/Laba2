using System;
class Program
{
    static void Main()
    {
        int n;
     
        do
        {
            Console.WriteLine("Enter n/4: ");
            n = int.Parse(Console.ReadLine());
        }
        while (n % 4 != 0);
        int[] numbers = new int[n];
        Console.WriteLine("Enter numbers: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        // перші n/4 елементів у зворотному порядку + останні n/4 елементів у зворотному порядку
        int[] row1 = new int[n/2];
        for (int i = 0; i < n / 4; i++)
        {
            // Приклад для numbers = 1,2,3,4,5,6,7,8:
            // перші 2 числа 1,2 → перевертаємо → 2,1
            row1[i] = numbers[(n / 4) - 1 - i];
            // останні 2 числа 7,8 → перевертаємо → 8,7
            row1[(n / 4) + i] = numbers[n - 1 - i];   
        }
        // Беремо середні n/2 елементів масиву
        // середні 4 числа → 3,4,5,6
        int[] row2 = new int[n / 2];
        for (int i = 0; i < n / 2; i++)
        {
            row2[i] = numbers[(n / 4) + i];
        }
        int[] sum = new int[n / 2];
        for (int i = 0; i < n / 2; i++)
        {
            sum[i] = row1[i] + row2[i];
        }

        Console.WriteLine("Row 1: " + string.Join(" ", row1));
        Console.WriteLine("Row 2: " + string.Join(" ", row2));
        Console.WriteLine("Sum:   " + string.Join(" ", sum));

    }
}
