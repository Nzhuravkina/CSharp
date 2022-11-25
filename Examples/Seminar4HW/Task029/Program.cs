// Hапишите программу, которая генерирует массив из 8 элементов - случайных чисел (от 0 до 20) и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 3 -> [1, 2, 5, 7, 19, 6, 1, 3]


void FillArray(int[] array)
{
    int arrayLength = 8;
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(0, 21);
        Console.WriteLine($"array[{i}] = {array[i]}");
    }
}

int[] array2 = new int[8];

FillArray(array2);