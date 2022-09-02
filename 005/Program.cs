/*/ Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07/*/

class Program

{
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] / 10 <= 0)
                {
                    Console.Write($"0{arr[i, j]} ");
                }
                else
                {
                    Console.Write($"{arr[i, j]} ");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];
        int number = 1;
        int i = 0;
        int j = 0;
        while (number <= 4 * 4)
        {
            array[i, j] = number;
            if (i <= j + 1 && i + j < 4 - 1)
                ++j;
            else if (i < j && i + j >= 4 - 1)
                ++i;
            else if (i >= j && i + j > 4 - 1)
                --j;
            else
                --i;
            ++number;
        }
        PrintArray(array);
    }
}




