// Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int NumberQuantity(int numA)
{
int count = 0;
while(numA>0)
{
    numA=numA/10;
    count=count+1;
}
return count;
}
int result = NumberQuantity(number);
Console.WriteLine(result);