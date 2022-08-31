// Напишите программу, которая будет выдавать название дня недели
// по заданному номеру

//Console.WriteLine("Введите число от 1 до 7:");
//int number = int.Parse(Console.ReadLine());
//if(number==1) Console.WriteLine("Понедельник");
//if(number==2) Console.WriteLine("Вторник");
//if(number==3) Console.WriteLine("Среда");
//if(number==4) Console.WriteLine("Четверг");
//if(number==5) Console.WriteLine("Пятница");
//if(number==6) Console.WriteLine("Суббота");
//if(number==7) Console.WriteLine("Воскресенье");
//if(number<=0) Console.Write("Введите число от 1 до 7:");
//if(number>=7) Console.Write("Введите число от 1 до 7:");

string day_number = "";
while (true)
{
Console.WriteLine("Enter a day number you want to see");
day_number = Console.ReadLine();
switch (day_number)
{
case "1":
{
Console.WriteLine("Monday");
continue;
}
case "2":
{
Console.WriteLine("Tuesday");
continue;
}
case "3":
{
Console.WriteLine("Wednsday");
continue;
}
{
Console.WriteLine("Thursday");
continue;
}
case "5":
{
Console.WriteLine("Friday");
continue;
}
case "6":
{
Console.WriteLine("Suturday");
continue;
}
case "7":
{
Console.WriteLine("Sunday");
continue;
}
default:
{
Console.WriteLine("Incorrect number");
break;
}
}
}