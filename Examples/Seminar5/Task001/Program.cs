// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите суммы отрицательных и положительных элементов массива.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

int SumOfNegative(int[] array)
{
    int sumOfNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumOfNegative = sumOfNegative + array[i];
    }
    return sumOfNegative;

}

int SumOfPositive(int[] array)
{
    int sumOfPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumOfPositive = sumOfPositive + array[i];
    }
    return sumOfPositive;

}

int[] array = new int[10];
FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.WriteLine($"Сумма негативных элементов = {SumOfNegative(array)}");
Console.WriteLine($"Сумма позитивных элементов = {SumOfPositive(array)}");