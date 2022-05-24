// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(int[] arr)
{
    Console.WriteLine();
    Console.Write("Сгенерированный массив данных---> ");
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void Difference(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];

    }
    Console.WriteLine();
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"Difference = {max}-{min} = {max - min}");

}

int[] arr_1 = Mass(10);
Print(arr_1);
Difference(arr_1);

int[] arr_2 = Mass(20);
Print(arr_2);
Difference(arr_2);
Console.WriteLine();
