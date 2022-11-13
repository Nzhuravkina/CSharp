// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Ввeдите число: ");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

int i = 1;

if (number1 <= 1)
{
    Console.WriteLine("Четных чисул от 1 до " + number1 + " нет");
}
else
{
    Console.WriteLine("Четные число от 1 до " + number1 + ":");

    while (i <= number1)
    {
        if (i % 2 == 0) Console.WriteLine(i);
        i++;
    }
}