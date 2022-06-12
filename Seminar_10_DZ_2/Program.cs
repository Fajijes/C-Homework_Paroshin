// Повторение матриц. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.


void FillArray3D (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"x; y; z ---> ");
      for (int k = 0; k < array3D.GetLength(2); k++)
        Console.Write( $"({i}); ({j}); ({k}) ---> {array3D[i,j,k]}; ");
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void PrintArray3D(int[,,] array3D)
{
  int[] arr = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    arr[i] = new Random().Next(10, 100);
    number = arr[i];
    if (i >= 1)
      for (int j = 0; j < i; j++)
        while (arr[i] == arr[j])
        {
          arr[i] = new Random().Next(10, 100);
          j = 0;
          number = arr[i];
        }
          number = arr[i];
  }
  
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = arr[count];
        count++;
      }
    }
}

int[,,] array3D = new int[3, 3, 3];
PrintArray3D(array3D);
FillArray3D(array3D);