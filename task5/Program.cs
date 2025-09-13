using System;
    class Program
    {
        static void Main()
        {

         Console.WriteLine("Enter 1 word: ");
        string input1 = Console.ReadLine();
        char[] arr1 = input1.ToCharArray();
 
        Console.WriteLine("Enter 2 word: ");
        string input2 = Console.ReadLine();
        char[] arr2 = input2.ToCharArray();
        Console.WriteLine("Result: ");
        int minlength = Math.Min(arr1.Length, arr2.Length);
        // порівнюємо символи по одному
        for (int i = 0;i < minlength; i++)
        {
            if (arr1[i] < arr2[i]) // якщо літера першого слова менша
            {
                Console.WriteLine(input1);
                Console.WriteLine(input2);
                return; // завершуємо програму
            }
            else if (arr1[i] > arr2[i]) // якщо літера другого слова менша
            {
                Console.WriteLine(input2);
                Console.WriteLine(input1);
                return;
            }
            // якщо літери однакові → цикл продовжується далі
        }
        // якщо всі літери однакові, тоді дивимось на довжину
        if (arr1.Length < arr2.Length) // перше слово коротше → воно менше
        {
            Console.WriteLine(input1);
            Console.WriteLine(input2);
        }
        else if (arr1.Length > arr2.Length)
        {
            Console.WriteLine(input2);
            Console.WriteLine(input1);
        }
        else
        {
            Console.WriteLine("Words are equal");
            Console.WriteLine(input1);
            Console.WriteLine(input2);
        }



    }
    }
