int[,] array = new int[5, 8];
GetRandomArray(array);
PrintArray(array);
FindSmalestSum(array);

void GetRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindSmalestSum(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    int minSum = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] = sumArray[i] + array[i, j];
        }
        if (sumArray[i] < minSum)
        {
            minSum = sumArray[i];
        }
    }
    Console.WriteLine($"Минимальная сумма элементов строки : {minSum}");
}
