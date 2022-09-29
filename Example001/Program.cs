// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNaturalNumbersToN(int n)
{
    if (n == 1)
    {
        return "1";
    }

    string result = GetNaturalNumbersToN(n - 1) + " " + n;
    return result;
}

Console.WriteLine("Введите значение для числа N: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = GetNaturalNumbersToN(n);

Console.WriteLine($"Натуральные числа в промежутке от 1 до {n}: ");
Console.WriteLine($"{result}");