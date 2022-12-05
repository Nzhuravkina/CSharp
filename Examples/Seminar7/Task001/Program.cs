// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = m + n;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m, n]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

FillArray(array);

PrintArray(array);