// // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


int Number = new Random().Next(100, 999);
int NewNumber = 0;
System.Console.WriteLine(Number);

void input()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return;
}

input();
System.Console.WriteLine($"{Number} -> {NewNumber}");
