// Вычислить среднее арифметическое положительных элементов в одномерном массиве.
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10
// [1, -5, 8, 4, -9] -> 4.33

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

double Average(int[] array)
{
    double numberOfPositive = 0;
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            numberOfPositive++;
            sum = sum + array[i];
        }
    }
    double average = (sum / numberOfPositive);
    return average;
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Console.WriteLine($"\nСреднее арифметическое положительных чисел массива = {Average(array)}");
