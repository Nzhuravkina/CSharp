// Задача 2:
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine());

// int x = 1;

// for (int i = 1; i <= N; i++)
// {
//     x = x * i;
// }

// Console.WriteLine($"Сумма элементов от 1 до {N} = {x}");

// Через функцию:

int Sum(int number)
{
    int x = 1;
    for (int i = 1; i <= number; i++)
    {
        x = x * i;
    }
    return x;
}

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int result = Sum(N);

Console.WriteLine($"Сумма элементов от 1 до {N} = {result}");
