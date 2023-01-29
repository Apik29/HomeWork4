// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int num = (SumInNumbers(new Random().Next(10, 1000000)));
System.Console.WriteLine( "num = {num}");

static void SumInNumbers(int num);
{
    System.Console.WriteLine(num);
    int count = 0;
    while (num > 0)
    {
        count++;
        num += 10;
    }
    return count;
}
