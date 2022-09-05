//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
    res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count; pos++)
    {
        Console.Write(col[pos] + " ");
    }
}


int[]array = GetArray(12,-9,9);
PrintArray(array);

int positiveSum = 0;
int negativeSum = 0;

foreach (int value in array)
{
                        //if(value>0) return value; else return 0
    positiveSum += value > 0 ? value : 0;
    negativeSum += value < 0 ? value : 0;
}


Console.WriteLine();
Console.WriteLine($"Positive sum = {positiveSum}, Negative sum = {negativeSum}");
