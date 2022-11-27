// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double MinElement(double[] array)
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement) minElement = array[i];
    }
    return minElement;
}

double MaxElement(double[] array)
{
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement) maxElement = array[i];
    }
    return maxElement;
}

double[] array = {4, 5, 7.4, 2.4, 6};

Console.WriteLine($"Разница между {MaxElement(array)} и {MinElement(array)} = {MaxElement(array) - MinElement(array)}");
