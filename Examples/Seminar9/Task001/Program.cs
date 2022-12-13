// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string NaturalNumbers(int n)
{
    if (n == 0)
        return "0";
    if (n == 1)
        return "1";
    return ($"{n} {NaturalNumbers(n-1)}");
}

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(NaturalNumbers(n));

