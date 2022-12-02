// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.).
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ChangeArray(int[] array)
{
    int index = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        if(i == index)
        {
            break;
        }
        int temp = array[i];
        array[i] = array[index];
        array[index] = temp;
        index = (index - 1);
    };
}

int[] array = new int[5];

FillArray(array);

PrintArray(array);

Console.WriteLine();

ChangeArray(array);

PrintArray(array);
