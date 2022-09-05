// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

void Binary(int num)
{
    string binar = "";
    while(num !=0)
    {
        binar = num % 2 + binar;
        num = num/2;
    }
    Console.WriteLine(binar);
}

Binary(num);
