﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

System.Console.WriteLine("Введите длинну массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine()); ;

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray[i] + " ");
}
int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}