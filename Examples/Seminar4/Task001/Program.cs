﻿// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int x = 0;

for (int i = 1; i <= N; i++)
{
    x = x + i;
}

Console.WriteLine($"Сумма элементов от 1 до {N} = {x}");

// Через функцию:

int Sum(int number)
{
    int x = 0;
    for (int i = 1; i <= number; i++)
    {
        x = x + i;
    }
    return x;
}

Console.WriteLine("Введите число");
int N2 = int.Parse(Console.ReadLine());

int result = Sum(N2);

Console.WriteLine($"Сумма элементов от 1 до {N2} = {result}");