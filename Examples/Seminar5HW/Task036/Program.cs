// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 51);
    }
}

int SumOddIndex(int[] array)
{
    int sumOddIndex = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sumOddIndex = sumOddIndex + array[i];
    }
    return sumOddIndex;
}

int[] array = new int[10];
FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {SumOddIndex(array)}");