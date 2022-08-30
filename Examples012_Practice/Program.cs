﻿// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить больштит "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, сказал князь, улыбаясь, - Что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?"; 

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);