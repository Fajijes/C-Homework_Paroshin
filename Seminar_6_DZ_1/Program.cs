// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(0, 10);
    return arr;
}

void matching  (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (i>0)  count++;
    }
    Console.WriteLine($"Кол-во элементов > 0: {count}");
}

int[] arr_1=Mass(12);
Print(arr_1);
matching(arr_1);