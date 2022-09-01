// Задайте массив. 
//Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[]array = new int [12];

for(int i=0; i<12; i++)
{
    array[i] = new Random().Next(-9,10);
}

/*void search(int[] array_num, int num)
{
    for (int i = 0; i < array_num.Length; i++)
    {
        if (array_num[i] == num)
        {
            Console.WriteLine("Число есть");
            return;
        }
    }
    Console.WriteLine("Числа нет");
}

search(array, 3);*/

/*Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

void SunNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine(sum);
}
SunNumber(number);*/

