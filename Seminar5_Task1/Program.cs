//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[]array = new int [12];

for(int i=0; i<12; i++)
{
    array[i] = new Random().Next(-9,10);
}

int positiveSum = 0;
int negativeSum = 0;
foreach (int value in array)
{
    positiveSum += value > 0 ? value : 0;
    negativeSum += value < 0 ? value : 0;
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Positive sum = {positiveSum}, Negative sum = {negativeSum}");

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count; pos++)
    {
        Console.Write(col[pos] + " ");
    }
}
