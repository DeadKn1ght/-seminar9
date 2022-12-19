// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

int NaturNumbers(int i, int numb)
{
    if ( i < numb)
    {
        System.Console.Write($"{NaturNumbers(i, numb-1)}, ");
    }
       return numb;
}


Console.WriteLine("Input number N :");
int numb = int.Parse(Console.ReadLine());
int i = 1;

int Natur = NaturNumbers(i, numb);
System.Console.WriteLine($"{Natur}");

