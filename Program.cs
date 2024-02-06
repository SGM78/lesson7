// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNaturalNumbers(M, N);

        Console.ReadLine();
    }

    static void PrintNaturalNumbers(int currentNumber, int N)
    {
        if (currentNumber <= N)
        {
            Console.Write(currentNumber + " ");
            PrintNaturalNumbers(currentNumber + 1, N);
        }
    }
}


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
class Program
{
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно {result}.");
        Console.ReadLine();
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

{
    {
        // Произвольный массив целых чисел
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7 };

        // Вызываем рекурсивную функцию для вывода элементов массива
        PrintArrayReversely(myArray, myArray.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReversely(int[] array, int currentIndex)
    {
        if (currentIndex >= 0)
        {
            Console.Write(array[currentIndex] + " ");
            PrintArrayReversely(array, currentIndex - 1);
        }
    }
}