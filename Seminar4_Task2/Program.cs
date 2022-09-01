// Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine());
int Factorial(int number)
{
    int count = 1;
    int i = 1;
    while (i<=number)
    {
        count = count*i;
        i = i + 1;
    }
    return count;
}

int result = Factorial(number);
Console.WriteLine(result);
