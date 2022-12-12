// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

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

void ChangeFirstAndLastRow(int[,] array)
{
    int lastRow = array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 0;
        int temp = array[i, j];
        array[i, j] = array[lastRow - 1, j];
        array[lastRow - 1, j] = temp; 
    }
}

int[,] array = new int[4, 4];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeFirstAndLastRow(array);
PrintArray(array);


