﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("Точка находится в 1 четверти");
}
if(x<0 && y>0)
{
    Console.WriteLine("Точка находится во 2 четверти");
}
if(x>0 && y<0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}
if(x<0 && y<0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}