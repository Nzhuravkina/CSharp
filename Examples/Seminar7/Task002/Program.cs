// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Square(double[,] array)
{
    for (int i = 2; i < array.GetLength(0); i = (i + 2))
    {
        for (int j = 2; j < array.GetLength(1); j = (j + 2))
        {
            array[i,j] = Math.Pow((array[i,j]), 2);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m,n];

FillArray(array);

Console.WriteLine("Массив из рандомных чисел");

PrintArray(array);

Square(array);

Console.WriteLine("Числа с четными индексами умножили на 2");

PrintArray(array);