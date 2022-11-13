// Написать программу: Программа получает число с консоли,
// возводит его в квадрат и выводит на экран

// Вывод сообщения в консоль
Console.WriteLine("Введите число, которое хотите возвести в квадрат: ");
// Получаем текст с консоли
string str = Console.ReadLine();
// int.Parse - переводит строку(string) в число (int)
int number = int.Parse(str);

int square = number * number;

Console.Write("Квадрат вашего числа = ");
Console.WriteLine(square);

// Вместо строк 13 и 14 можно записать Console.WriteLine("Квадрат вашего числа = " + sqare)