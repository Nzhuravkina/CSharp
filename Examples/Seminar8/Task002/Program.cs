// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

int[] MinElementIndexes(int[,] array)
{
    int[] arrayOfIndexes = new int[2];
    int minElement = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < minElement) 
            {
                minElement = array[i, j];
                arrayOfIndexes[0] = i;
                arrayOfIndexes[1] = j;
            }
        }
    }
    return arrayOfIndexes;
}

int[,] DeleteRowAndColumnOfMinElement(int[,] array, int[] indexesOfMinElement)
{
    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i == indexesOfMinElement[0])
        {
            continue;
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == indexesOfMinElement[1])
            {
                continue;
            }
            resultArray[row, column] = array[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return resultArray;
        
}


int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] indexesOfMinElement = MinElementIndexes(array);
Console.WriteLine(indexesOfMinElement[0] + " " + indexesOfMinElement[1]);

int[,] updatedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
updatedArray = DeleteRowAndColumnOfMinElement(array, indexesOfMinElement);

Console.WriteLine();
PrintArray(updatedArray);
