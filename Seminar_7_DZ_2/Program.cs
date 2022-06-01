// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++) Console.Write($"\t{arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    }
    return arr;
}

void ReturnNum(int[,] arr, int arg1, int arg2)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    string answer = "element doesn't exist";

    if (arg1 < 0 | arg1 > row | arg2 < 0 | arg2 > column)
        Console.WriteLine(answer);

    else
        Console.WriteLine($"Value in position {(arg1, arg2)} ---> = {arr[arg1, arg2]}");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

Console.Write("Enter an argument1: ");
int argument1 = int.Parse(Console.ReadLine());

Console.Write("Enter an argument2: ");
int argument2 = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] arr_1 = MassNums(row, column, 1, 5);
Print(arr_1);
ReturnNum(arr_1, argument1, argument2);


