// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string s_a = Console.ReadLine();        // Выводим результат
int a = int.Parse(s_a);

string s_b = Console.ReadLine();        // Выводим результат
int b = int.Parse(s_b);

Console.WriteLine($"{a}>{b}?");
Console.WriteLine($"{a > b}");

if (a > b)                             // Проверяем результат
{
    Console.WriteLine($"max = {a}");   // Выводим результат
}
else
{
    Console.WriteLine($"max = {b}");   // Выводим результат
}