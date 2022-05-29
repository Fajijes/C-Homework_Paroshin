// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

void Print(int[] arr)
{
    Console.WriteLine();
    Console.Write("Сгенерированный массив данных---> ");
    int size = arr.Length;

    for (int i = 0; i < size; i++) Console.Write($"{arr[i]} ");
  
  
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++) arr[i] = new Random().Next(-10, 10);
  
    return arr;
}

void Multiply(int[] arr)
{
    Console.WriteLine();
    Console.Write($"Массив произведений пар чисел---> ");
    int max = arr.Length - 1;

    for (int i = 0; i < ((arr.Length) / 2) +1 ; i++) Console.Write($"{arr[i] * arr[max]} "); max--;
    
 Console.WriteLine();   
}

int[] arr_1 = Mass(5);
Print(arr_1);
Multiply(arr_1);

// int[] arr_2 = Mass(15);
// Print(arr_2);
// Multiply(arr_2);
// Console.WriteLine();

