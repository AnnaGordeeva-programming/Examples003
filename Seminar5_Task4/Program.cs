// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

int[]array = GetArray(123,-100,100);
PrintArray(array);
Console.WriteLine();

int Count(int[] array, int minLength, int maxLength)
{
    int count = 0;
    foreach(int value in array)
    {
        if(value>=minLength && value<=maxLength)
        {
            count+=1;
        }
    }
    return count;
}

int res = Count(array, 10,99);
Console.WriteLine(res);
