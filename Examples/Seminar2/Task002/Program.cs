// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.WriteLine("Ввeдите первое число: ");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

Console.WriteLine("Ввeдите второе число: ");
string str2 = Console.ReadLine();
int number2 = int.Parse(str2);

int del = number1 % number2; //ввели переменную, чтобы далее не высчитывать это 2 раза (в троках 17 и 23)

if (del == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток " + del);
}