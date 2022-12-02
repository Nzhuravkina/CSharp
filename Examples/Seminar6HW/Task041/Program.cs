// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] FillArray(int[] array, int arrayLength)
{
    for(int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine($"Введите {i+1}-e число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int NumberOfPositive(int[] array)
{
    int numberOfPositive = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j] > 0) numberOfPositive++;
    }
    return numberOfPositive;
}

Console.WriteLine("Сколько чисел вы хотите ввести?");
int m = int.Parse(Console.ReadLine());

int[] array = new int[m];

FillArray(array, m);
Console.WriteLine($"\nКоличество введенных положительных чисел = {NumberOfPositive(array)}");