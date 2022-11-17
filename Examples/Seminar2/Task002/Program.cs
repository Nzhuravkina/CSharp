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

if (number1 % number2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток " + number1 % number2);
}