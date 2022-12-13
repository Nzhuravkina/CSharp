// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ack(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return Ack(n - 1, 1);
    return Ack(n - 1, Ack(n, m - 1));
}

Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана: {Ack(n, m)}");
