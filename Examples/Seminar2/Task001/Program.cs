// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); //100 - включена, 1000 - нет

Console.WriteLine("Рандомное число: " + number);

int firstDigit = number / 100;
// int secondDigit = (number/10) %10; эта строка лишняя
int thirdDigit = number % 10;

Console.WriteLine("Число после удаления второй цифры: " + firstDigit + thirdDigit);



