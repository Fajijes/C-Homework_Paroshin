// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(int[] arr)
{
    Console.WriteLine();
    Console.Write("Сгенерированный массив данных---> ");
    int size = arr.Length;

    for (int i = 0; i < size; i++) Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++) arr[i] = new Random().Next(-20, 20);

    return arr;
}

void SumOdd(int[] arr)
{
    double s_odd = 0;
    for (int i = 0; i < arr.Length; i ++)
    {
        if (i % 2 == 1) s_odd += arr[i];
    }

    Console.WriteLine($"sum odd = {s_odd}");
 
}


int[] arr_1 = Mass(15);
Print(arr_1);
SumOdd(arr_1);

int[] arr_2 = Mass(20);
Print(arr_2);
SumOdd(arr_2);
Console.WriteLine();
