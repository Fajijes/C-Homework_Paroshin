// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++) 
        Console.Write($"\t{arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void Average(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    double sum=0;

    for (int j = 0; j < column_size; j++)
    {
        for (int i = 0; i < row_size; i++) 
        sum+= arr[i,j];
        Console.WriteLine($"Average = {sum/row_size}");
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();

double[,] arr_1 = MassNums(row, column, 0, 10);
Print(arr_1);
Average(arr_1);

