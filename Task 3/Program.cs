// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.NextDouble() + rand.Next(leftRange, rightRange + 1), 2);
    }

    return tempArray;
}


void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}


double FindMin(double[] arrayForCheck)
{
    double min = arrayForCheck[0];
    for (int i = 1; i < arrayForCheck.Length; i++)
    {
        if (min > arrayForCheck[i])
        {
            min = arrayForCheck[i];
        }
    }
    return min;
}


double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

//----------------------------------------------------------------------------------------

double[] array = FillArray(10, 0, 10);
PrintArray(array);
double result = Math.Round((FindMax(array) - FindMin(array)), 2);
Console.WriteLine($"Разница между максимальным числом и минимальным числом: {result}");