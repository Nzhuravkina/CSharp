// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// 1 -> x > 0, y > 0
// 3 -> x < 0, y < 0

Console.WriteLine("Введите номер четверти: ");
string qText = Console.ReadLine();
int qNumber = int.Parse(qText);

if (qNumber < 1 || qNumber > 4)
{
    Console.WriteLine("Такой плоскости не существует");
}

else
{
    if (qNumber == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    if (qNumber == 2)
    {
        Console.WriteLine("x < 0, y > 0");
    }
    if (qNumber == 3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    if (qNumber == 4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
}

// Альтернативное решение через switch

Console.WriteLine("Введите номер четверти: ");
string qText1 = Console.ReadLine();
int qNumber1 = int.Parse(qText);

switch(qNumber)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
         Console.WriteLine("Такой плоскости не существует");
         break;
}