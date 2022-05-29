// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    Console.WriteLine();
    Console.Write("Сгенерированный массив данных---> ");
    double size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}

double[] Mass(int size)
{

    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}

void Difference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];

    }
    Console.WriteLine();
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"Difference = {max}-{min} = {max - min}");

}

double[] arr_1 = Mass(10);
Print(arr_1);
Difference(arr_1);

double[] arr_2 = Mass(20);
Print(arr_2);
Difference(arr_2);
Console.WriteLine();
