// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Ввeдите первое число: ");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

Console.WriteLine("Ввeдите второе число: ");
string str2 = Console.ReadLine();
int number2 = int.Parse(str2);

Console.WriteLine("Ввeдите третье число: ");
string str3 = Console.ReadLine();
int number3 = int.Parse(str3);

int max = number1;

if(number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}

Console.WriteLine ("max = " + max);