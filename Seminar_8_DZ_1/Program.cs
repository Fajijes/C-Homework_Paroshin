// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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

void Fill(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(1, 20);
}

void Order(int[,] arr)
{
    int RowSize = arr.GetLength(0);
    int ColumnSize = arr.GetLength(1);

    for (int i = 0; i < RowSize; i++)
        for (int j = 0; j < ColumnSize; j++)
            for (int x = 0; x < ColumnSize - 1; x++)
                if (arr[i, x] < arr[i, x + 1])
                {
                    int NewArray = arr[i, x];
                    arr[i, x] = arr[i, x + 1];
                    arr[i, x + 1] = NewArray;
                }
    return;
}

int[,] arr = new int[3, 3];
Fill(arr);
Print(arr);
Console.WriteLine();
Order(arr);
Print(arr);