// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

bool FindNumber(int[,] array, int n)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == n) 
            {
                result = true;
                break;
            }
        }
    }
    return result;
}

void PrintIndexes(int[,] array, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == n)
            {
                Console.WriteLine($"Число находится в строке {i + 1}, столбце {j + 1}");
            }
        }
    }
}

int[,] array = { { 0, 1, 2 }, { 0, 4, 5 } };

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

if(FindNumber(array, n))
{
    PrintIndexes(array, n);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}

