// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;

}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
    Console.WriteLine();
    Console.WriteLine();

}

int[,] Multiply(int[,] arr1, int[,] arr2)
{
    int row = arr1.GetLength(0);
    int column = arr1.GetLength(1);
    int[,] multi = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            multi[i, j] = arr1[i, j] * arr2[i, j];
    return multi;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row, column, 0, 5);
PrintArray(arr1);
int[,] arr2 = FillArray(row, column, 0, 5);
PrintArray(arr2);

int[,] res_matrix = Multiply(arr1, arr2);
PrintArray(res_matrix);
