// Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.

string[] st = Console.ReadLine().Split(' ');
bool IsTriangle(int a, int b, int c)
{
return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}
Console.WriteLine(IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])));

//string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
//bool IsTriangle(int a, int b, int c) { return (((a + b) > c) && ((a + c) > b) && ((b + c) > a)); }
//Console.WriteLine(IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])));