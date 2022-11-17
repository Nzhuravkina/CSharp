// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string str = Console.ReadLine();
char [] arr = str.ToCharArray();

if (arr.Length >= 3)
{
    Console.WriteLine("Третья цифра числа: " + arr[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
