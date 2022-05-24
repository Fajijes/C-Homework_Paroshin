// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции 

// int[] array = new int[8];
// void Array(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(0, 100);

//         Console.Write($"{array[i]} ");
//     }
// }

// Array(array);

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] EightMass()
{   
    int size = 8;

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);        
    }    
    return arr;
}

int[] arr_1 = EightMass();
Print(arr_1);
int[] arr_2 = EightMass();
Print(arr_2);
