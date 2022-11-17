// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

Console.WriteLine("Ввeдите число:");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

if (number1 % 7 == 0 && number1 % 23 == 0)
{
    Console.WriteLine(number1 + " кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine(number1 + " НЕ кратно одновременно 7 и 23");
}