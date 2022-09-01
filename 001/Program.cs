/*/Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2/*/

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
        Console.WriteLine("Отсортированный массив (элементы по убыванию по каждой строке)");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = 0;
                        temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }

        }
        PrintArray(array);
    }
}

