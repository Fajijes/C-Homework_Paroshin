// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции 

int[] array = new int[8];
void Array(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 100);

        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Array(array);
