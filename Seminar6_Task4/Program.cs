// Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());

void Triangle(int num1, int num2, int num3)
{
    if(num1+num2<=num3 || num1+num3<=num2 || num2+num3<=num1) 
    {
        Console.WriteLine("Треуголник НЕ получится");
    }
    else Console.WriteLine("Треуголник получится");
}

Triangle(num1, num2, num3);
