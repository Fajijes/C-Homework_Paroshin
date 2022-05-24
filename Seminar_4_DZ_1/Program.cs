// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.


void degree(int A, int B)
{
    int x = A;
  
    for (int i = 0; i < B; i++)
    {
        x *= A;
    }
    Console.WriteLine();
    Console.WriteLine($"{A}^{B} = {x}");
}

degree(2, 5);
Console.WriteLine("------");
degree(5, 4);
Console.WriteLine("------");
degree(7, 8);
Console.WriteLine("------");
degree(10, 4);
Console.WriteLine("------");
degree(11, 3);
Console.WriteLine();

