/*/Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка/*/

class Program
{
    static void FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(1, 10);
            }
        }
    }
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк m ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов n ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"m={m},n={n}");
        int[,] array = new int[m, n];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine("Сумма элементов в каждой строке ");
        int row = 0;
        int minSum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            minSum += array[0, i];
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
            }
            if (minSum > sum)
            {
                minSum = sum;
                row = i;
            }
            Console.WriteLine(sum);
        }
        Console.WriteLine("Номер строки с наименьшей суммой элементов ");
        Console.WriteLine(row + 1);
    }
}





