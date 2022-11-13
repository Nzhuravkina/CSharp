// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввeдите первое число: ");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

Console.WriteLine("Ввeдите второе число: ");
string str2 = Console.ReadLine();
int number2 = int.Parse(str2);

if (number1 == number2)
{
   Console.WriteLine("Введенные числа равны");
}
else
{
        if (number1 > number2)
    {
        Console.WriteLine("Первое введенное число больше второго");
    }
    else
    {
        Console.WriteLine("Второе введенное число больше первого");
    }
}
