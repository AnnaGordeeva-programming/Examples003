// Напишите функцию, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNumber(int numA)
{
    int sum = 0;
    while (numA>0)
    {
        sum = sum + numA;
        numA = numA -1;
    }
    return sum;
}

Console.WriteLine(GetSumNumber(num));