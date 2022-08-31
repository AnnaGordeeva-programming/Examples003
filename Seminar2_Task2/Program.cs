// Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine(number);

int a1 = number/100;
int a3 = number%10;

Console.WriteLine($"{a1}{a3}");

//Вариант решения через массив
//int number = new Random().Next(100, 100);
//string number1 = Convert.ToString(number);
//Console.WriteLine(number1);
//Console.WriteLine(number1[0]+""+number1[2]);