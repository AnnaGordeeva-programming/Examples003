// Задайте массив. 
//Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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
Console.WriteLine();

void Search(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine("Число есть");
            return;
        }
    }
    Console.WriteLine("Числа нет");
}

Search(array, 3);

