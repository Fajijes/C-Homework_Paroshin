// Напишите программу вычисления модуля числа;

string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if (a>0)
{
    Console.WriteLine(a);
}
else
{
    a=-1*a;
    Console.WriteLine(a);
}