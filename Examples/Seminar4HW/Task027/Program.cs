// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(string number)
{
    
    int m = int.Parse(number);
    int k = -1;
    int result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        k = m % 10;
        result = result + k;
        m = m / 10;
    }
    return result;
}

Console.WriteLine("Введите число");
string A = Console.ReadLine();

Console.WriteLine($"Сумма цифр числа {A} = {Sum(A)}");