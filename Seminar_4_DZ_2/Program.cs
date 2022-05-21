// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе

void SumNum(int num)
{   
    int x=0;
    int n=num;
    for (int i = 0; i <= n; i++)
    {
        int num1 = n % 10;
        n = n / 10;
        x = num1+x;
    }
    x=x+n;
    Console.WriteLine($"Суммой цифр числа {num} является {x}");
}

Console.WriteLine();
SumNum(12345);
Console.WriteLine();
SumNum(15483746);
Console.WriteLine();
SumNum(1020304050);
Console.WriteLine();
SumNum(111111111);
Console.WriteLine();