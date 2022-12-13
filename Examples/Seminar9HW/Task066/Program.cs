// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNaturalElements(int n, int m)
{
    if (n == m)
        return n;
    return (n + SumOfNaturalElements(n + 1, m));
}

Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма элементов в промежутке между {n} и {m} = {SumOfNaturalElements(n, m)}");