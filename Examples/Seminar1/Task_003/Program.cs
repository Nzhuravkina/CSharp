// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Ввeдите число:");
string str1 = Console.ReadLine();
int number1 = int.Parse(str1);

int negativeNumber = number1 * -1;

Console.WriteLine("Целые числа в промежутке между " + (-number1) + " и " + number1 + ": ");

while(negativeNumber <= number1)
{
    Console.Write(negativeNumber +" ");
    negativeNumber++;
}

