using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] originalArray = { 3.5, -2.1, 4.8, -6.2, 1.0, -5.5 }; // Пример исходного массива

        var positiveNumbers = originalArray.Where(num => num > 0).ToArray();
        var negativeNumbers = originalArray.Where(num => num < 0).ToArray();

        Console.WriteLine("Массив положительных чисел:");
        foreach (var number in positiveNumbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nМассив отрицательных чисел:");
        foreach (var number in negativeNumbers)
        {
            Console.Write(number + " ");
        }
    }
}