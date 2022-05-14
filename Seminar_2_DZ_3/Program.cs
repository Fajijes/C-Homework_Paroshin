//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int Number = new Random().Next(0, 1000);
int NewNumber = 0;
System.Console.WriteLine($"Сгенерованное число {Number}");

if (Number / 100 > 0) 
{
    System.Console.WriteLine($"Третья цифра {Number / 1000 * 10 + Number % 10}");
}
else 
{
    System.Console.WriteLine("Третьей цифры нет");
}



