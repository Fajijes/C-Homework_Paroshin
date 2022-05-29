// Напишите программу, которая будет создавать копию заданного 2-мерного массива 
// с помощью поэлементного копирования.

void Massive(int[,] arr)
{
    int[,] arr1 = new int[5, 5];
    int[,] arr2 = new int[5, 5];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(1, 10);
    }

    Console.WriteLine("Массив А");
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr1[i, j] = arr[i, j];
            Console.Write($"{arr1[i, j]} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Массив В");

    for (int i1 = 0; i1 < arr.GetLength(0); i1++)
    {
        for (int j1 = 0; j1 < arr.GetLength(1); j1++)
        {
            arr2[i1, j1] = arr[i1, j1];
            Console.Write($"{arr2[i1, j1]} ");
        }

        Console.WriteLine();
    }
}
int[,] arr = new int[5, 5];

Console.WriteLine();
Massive(arr);
Console.WriteLine();
