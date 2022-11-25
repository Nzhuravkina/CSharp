// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int number, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result = result * number;
    }
    return result;
}

Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("В какую степень возвести введенное число?");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = {Power(A, B)}");