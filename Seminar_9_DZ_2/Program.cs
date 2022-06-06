// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.

int ValueSet(int a, int b)
{
    if (b==0) return 0;
    return ValueSet(a,b-1)+b;
}
Console.Write (ValueSet(1,5));

