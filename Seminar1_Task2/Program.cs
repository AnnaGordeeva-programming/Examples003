// Напишите программу, которая на вход принимает два числа
// и определяет, является ли первое число квадратом второго

Console.WriteLine("Число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Число 2: ");
int number2 = int.Parse(Console.ReadLine());
int div = number1/number2;
if(div==number2)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else Console.WriteLine($"Число {number1} НЕ является квадратом числа {number2}");