// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if (a == 1)
{
    Console.WriteLine("Monday");
}
if (a == 2)
{
    Console.WriteLine("Tuesday");
}
if (a == 3)
{
    Console.WriteLine("Wednesday");
}
if (a == 4)
{
    Console.WriteLine("Thursday");
}
if (a == 5)
{
    Console.WriteLine("Friday");
}
if (a == 6)
{
    Console.WriteLine("Saturday");
}
if (a == 7)
{
    Console.WriteLine("Sunday");
}

if (a == 6 | a == 7)
{
    Console.WriteLine("day off");
}
else
{
    Console.WriteLine("work day");
}