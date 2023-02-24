int[,] array = new int[5, 5];
GetRandomArray(array);
PrintArray(array);
Console.WriteLine();
GetStringInOrder(array);
PrintArray(array);


void GetRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void GetStringInOrder(int[,] array)
{   int temp = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int n = 0; n < array.GetLength(1)-1; n++)
        if (array[i,n+1] > array[i,n]) 
        {
            temp = array[i,n];
            array[i,n] = array[i,n+1];
            array[i,n+1] = temp;
        }
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
