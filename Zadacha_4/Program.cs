// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

string s_a = Console.ReadLine();        // Выводим результат
int a = int.Parse(s_a);

string s_b = Console.ReadLine();        // Выводим результат
int b = int.Parse(s_b);

string s_c = Console.ReadLine();        // Выводим результат
int c = int.Parse(s_c);

int max = a;

if (a > b)                              // Проверяем на максимум первый раз
{
    a = max;
}
else
{
    b = max;

}

if (b > c)                             // Проверяем на максимум второй раз
{
    b = max;
}
else
{
    c = max;
}
Console.WriteLine($"max = {max}");     // Выводим результат