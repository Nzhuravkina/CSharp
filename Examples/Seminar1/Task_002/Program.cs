// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Ввeдите число 1:");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

Console.WriteLine("Ввeдите число 2:");
string str2 = Console.ReadLine();
int number2 = int.Parse(str2);

if (number1 == number2 * number2)
{
    Console.WriteLine(number1 + " " + "является квадратом" + " " + number2);
}
else
{
    Console.WriteLine(number1 + " " + "не является квадратом" + " " + number2);
}

