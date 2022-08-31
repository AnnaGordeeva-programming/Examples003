// Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

Console.Write("Число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int div = number2 % number1;
if(div == 0)
{
    Console.WriteLine($"Число {number2} кратно числу {number1}");
}
else Console.WriteLine($"Число {number2} НЕ кратно числу {number1}. Остаток {div}");