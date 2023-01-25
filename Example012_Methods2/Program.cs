// Работа с текстом!
// Дан текст. В тексте все пробелы нужно заменить черточками,
// маленькие буквы "к" заменить большими буквами "К",
// а большие "С" заменить маленькими "с"

string text = "- Я думаю, сказал князь, улыбаясь, - что, " 
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "вы так красноречивы, вы дадите мне чаю";

// string s = "qwerty"
//             012345
// s[3] это r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newtext = Replase(text, ' ', '|');
Console.WriteLine (newtext);
Console.WriteLine();
newtext = Replase(newtext, 'к', 'К');
Console.WriteLine (newtext);
Console.WriteLine();
newtext = Replase(newtext, 'с', 'С');
Console.WriteLine (newtext);
