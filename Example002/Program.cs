﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum (int m, int n)
{
    if (m == n)
    {
        return n;
    }

    int result = GetSum(m, n - 1) + n;
    return result;
}

Console.WriteLine("Введите значение для числа M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumMN = GetSum(m, n);

Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}: ");
Console.WriteLine($"{sumMN}");