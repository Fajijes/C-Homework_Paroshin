// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void square(int num)
{
    int i = 1;
    while (num >= i)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}

square(11);