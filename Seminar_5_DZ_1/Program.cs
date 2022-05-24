// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

    for (int i = 0; i < size; i++) arr[i] = new Random().Next(100, 999);

    return arr;
}

void EvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int x = arr[i];

        if (x % 2 == 0) count += 1;
    }

    Console.Write($"Количество чётных чисел в массиве---> {count}  ");
    Console.WriteLine();
}

int[] arr_1 = Mass(12);
Print(arr_1);
EvenNum(arr_1);

int[] arr_2 = Mass(20);
Print(arr_2);
EvenNum(arr_2);
Console.WriteLine();