// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write ("\nЗадайте значения k1: ");
string a = Console.ReadLine();

double k1 = int.Parse(a);
Console.Write ("\nЗадайте значения b1: ");
string b  = Console.ReadLine();

double b1  = int.Parse(b );
Console.Write ("\nЗадайте значения k2: ");
string c = Console.ReadLine();

double k2 = int.Parse(c);
Console.Write ("\nЗадайте значения b2: ");

string d = Console.ReadLine();
double b2 = int.Parse(d);

double x=((b2-b1)/(k1-k2));

double y = k1*x+b1;
Console.WriteLine ($"\nПересечение двух точек находятся в координате {(x,y)}");