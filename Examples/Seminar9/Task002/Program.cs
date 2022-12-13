// Задача 2. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int Pow(int a, int b)
{
    if (b == 0)
        return 1;
    if (b == 1)
        return a;
    return (a * Pow(a, b - 1));
}

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"{a} в степени {b} = {Pow(a, b)}");