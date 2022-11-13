// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Ввeдите число: ");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

if(number1 % 2 == 0)
{
    Console.WriteLine("Введенное число является четным");
}
else
{
    Console.WriteLine("Введенное число является нечетным");
}