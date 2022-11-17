// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


//Решение через вычисление
Console.WriteLine("Введите трехзначное число");
string str = Console.ReadLine();
int number = int.Parse(str);

int secondDigit = (number / 10) % 10;

Console.WriteLine("Вторая цифра этого числа: " + secondDigit);

// Альтернативное решение через массив (гуглила для 13 задачи, но здесь тоже применимо)
Console.WriteLine("Введите трехзначное число");
string str1 = Console.ReadLine();
char [] arr = str1.ToCharArray();

Console.WriteLine(arr[1]);