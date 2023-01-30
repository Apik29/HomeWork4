// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = new Random().Next(10, 1000000);
System.Console.WriteLine(number);

int len = NumberLen(number);
SumInNumbers(number, len);

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumInNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}