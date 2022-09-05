// Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

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

void Reverse(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
    array[i]*=-1;
    }
}

Reverse(array);
Console.WriteLine();
PrintArray(array);