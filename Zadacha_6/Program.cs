// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int b = 1;

while (b<=a)
{
  if(b%2==0)
  {
   Console.Write(b + " ");
  }
   
   b=b+1;
   
}

