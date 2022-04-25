// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string s_a = Console.ReadLine();
int a = int.Parse(s_a);

string s_b = Console.ReadLine();
int b = int.Parse(s_b);

Console.WriteLine($"{a}>{b}?");
Console.WriteLine($"{a > b}");

if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}