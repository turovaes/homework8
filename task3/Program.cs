int[,] matrixA = new int[2, 2];
int[,] matrixB = new int[2, 2];
int[,] matrixC = new int[2, 2];

GetRandomArray(matrixA);
Console.WriteLine($"Матрицы А: ");
PrintArray(matrixA);
Console.WriteLine();
GetRandomArray(matrixB);
Console.WriteLine($"Матрицы B: ");
PrintArray(matrixB);
Console.WriteLine();

MultiplyMatrix(matrixA, matrixB);
Console.WriteLine($"Произведение матрицы А на матрицу В равно: ");
PrintArray(matrixC);

void GetRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}

int[,] PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < matrixA.GetLength(0); n++)
            {
                sum = sum + matrixA[i, n] * matrixB[n, j];
            }
            matrixC[i, j] = sum;
        }
    }
    return matrixC;
}


