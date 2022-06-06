// Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.



void EvenNum(int m, int n)
{
    int FirstNum = 2;
    if (m % 2 != 0) m += 1;
    if (m <= 0) m = FirstNum;
    if (n < m) return;
    Console.Write($"{m} ");
    EvenNum(m + 2, n);
}
Console.WriteLine();
EvenNum(1, 55);


