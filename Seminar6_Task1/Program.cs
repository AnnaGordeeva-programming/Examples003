//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
    res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}


void ReverseArray(int[]inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length-i-1];
        inArray[inArray.Length-i-1] = k;
    }
}

int[]array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ", array));// Отпечатывание массива через пробел

ReverseArray(array);
Console.WriteLine(String.Join(" ", array));



