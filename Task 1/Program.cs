// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}


void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int CountOfPositive(int[] arr)
{
    int count = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

//------------------------------------------------------------------------------------

int[] array = FillArray(10, 100, 999);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел: {CountOfPositive(array)}");

