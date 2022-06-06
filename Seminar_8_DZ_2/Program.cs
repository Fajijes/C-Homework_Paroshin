// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(1, 10);
}

void Print(int[,] arr)
{
    int RowSize = arr.GetLength(0);
    int ColumnSize = arr.GetLength(1);
    for (int i = 0; i < RowSize; i++)
        for (int j = 0; j < ColumnSize; j++)
            Console.Write($"\t{arr[i, j]} ");
        Console.WriteLine();
    Console.WriteLine();
}

int SummRow(int[,] arr)
{
    int sum = 0;
    int MinRow = 0;
    int MinSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == 0)
            {
                sum += arr[i, j];
                MinSum += arr[i, j];

            }

            else sum += arr[i, j];

        // Console.WriteLine(sum);  // проверка суммы

        if (sum < MinSum)
        {
            MinSum = sum;
            MinRow = i;
        }
        sum = 0;
    }
    return MinRow;
}

int[,] arr = new int[4, 5];
Fill(arr);
Print(arr);
Console.WriteLine();
Console.WriteLine($"MinSumm = {SummRow(arr)}");


