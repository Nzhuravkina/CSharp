// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
string weekDay = Console.ReadLine();
int weekDayNumber = int.Parse(weekDay);

if (weekDayNumber > 5 && weekDayNumber < 8)
{
    Console.WriteLine("Введенный день недели является выходным");
}
else
{
    Console.WriteLine("Введенный день недели не является выходным");
}
