// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = new Random().Next(10000, 99999);
System.Console.WriteLine($"Сгенерованное число {num}");
int n = num;
int i = 0;

while (num > 0)
{
    int x = num % 10;
    i = i * 10 + x;
    num = num / 10;
}
if (n == i)
{
    System.Console.WriteLine($"Это палиндром");
}
else
{
    System.Console.WriteLine($"Это не палиндром");
}



