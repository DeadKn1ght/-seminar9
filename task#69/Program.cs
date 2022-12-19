// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int degree(int numbA,int numbB)
{
    if(numbB<=0) return 1;
    return degree(numbA,--numbB) *numbA;
}

Console.WriteLine("Input number A :");
int numbA = int.Parse(Console.ReadLine());
Console.WriteLine("Input number B :");
int numbB = int.Parse(Console.ReadLine());
int scaledegree = degree(numbA,numbB);
System.Console.WriteLine($"Degree of Number A in number B is : {scaledegree}");