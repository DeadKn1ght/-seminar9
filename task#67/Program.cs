// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();



int SummDigits(int numb,int summ)
{
    if (numb>1)
    {
        summ += numb%10 + SummDigits(numb/10,summ);
        
    }
    return summ;
}

Console.WriteLine("Input number :");
int number = int.Parse(Console.ReadLine());
int summ = 0;
int digits = SummDigits(number,summ);
System.Console.WriteLine($"Summ of all digits is : {digits}");