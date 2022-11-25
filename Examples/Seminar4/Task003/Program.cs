// Задача 3 (общая):
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void FillArray(int[] array)
{
    int arrayLength = 8;
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.WriteLine(array[i]);
    }
}

int[] array2 = new int[8];

FillArray(array2);

