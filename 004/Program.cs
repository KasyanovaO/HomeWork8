/*/ Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)/*/

class Program
{
    static void FillArray(int[,,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int k = 0;
                while (k < arr.GetLength(2))
                {
                    int element = new Random().Next(10, 100);
                    if (FindElement(arr, element)) continue;
                    arr[i, j, k] = element;
                    k++;
                }
            }
        }
    }

    static bool FindElement(int[,,] arr, int element)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    if (arr[i, j, k] == element) return true;
                }
            }
        }
        return false;
    }

    static void PrintArray(int[,,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write($"{arr[i, j, k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива m ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размер массива n ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размер массива p ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"m={m},n={n}, p={p}");
        int[,,] array = new int[m, n, p];
        FillArray(array);
        PrintArray(array);
    }
}

