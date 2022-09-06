﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int number2 = Convert.ToInt32(Console.ReadLine());

int PrintSumMtoN(int a, int b)
{

    if (a>b) return 0;
    return b + PrintSumMtoN(a, b-1);
}
Console.WriteLine(PrintSumMtoN(number, number2));