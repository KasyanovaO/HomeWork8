/*/ Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18/*/

class Program
{
    static void FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(2, 5);
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
        Console.Write("Введите количество столбцов/строк n ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов p ");
        int p = Convert.ToInt32(Console.ReadLine());
        int[,] arrayA = new int[m, n];
        int[,] arrayB = new int[n, p];
        FillArray(arrayA);
        PrintArray(arrayA);
        Console.WriteLine();
        FillArray(arrayB);
        PrintArray(arrayB);
        Console.WriteLine("Произведение двух матриц");
        int[,] arrayC = new int[m, p];

        for (int i = 0; i < arrayC.GetLength(0); i++)
        {
            for (int j = 0; j < arrayC.GetLength(1); j++)
            {
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] = arrayC[i, j] + (arrayA[i, k] * arrayB[k, j]);
                }
            }
        }
        PrintArray(arrayC);
    }
}






