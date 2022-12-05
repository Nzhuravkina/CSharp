// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Average(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца:");
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        double count = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
            count++;
        }
        average = sum / count;
        Console.Write($" {Math.Round(average, 1)};");
    }
}

int[,] array = { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4} };

Average(array);
