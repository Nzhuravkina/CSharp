// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

int RowWithMinSumOfElements(int[,] array)
{
    int rowWithMinSum = 0;
    int resultSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfRowElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfRowElements = sumOfRowElements + array[i, j]; 
        }
        if(i == 0) resultSum = sumOfRowElements;
        if(sumOfRowElements < resultSum)
        {
            resultSum = sumOfRowElements;
            rowWithMinSum = i;
        }
    }
    return rowWithMinSum;
}

int[,] array = new int[4, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {RowWithMinSumOfElements(array) + 1}");