﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray(int[,,] array)
{
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  tempNumber;
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        tempNumber = tempArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j = 0;
                    tempNumber = tempArray[i];
                }
                tempNumber = tempArray[i];
            }
        }
    }
    int indexOfTemArray = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = tempArray[indexOfTemArray];
                indexOfTemArray++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);