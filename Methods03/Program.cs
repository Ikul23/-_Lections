// Задача: Дан текст в тексте нужно заменить все пробелы черточками, 
//маленькие буквы "к" заменить на большие "К", а большие "С" заменить маленькими "с"

string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде," 
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// Пояснения:string text = "qwert"
//                          01234  => s[3]=>'r' 
string Replace(string text, char oldValue, char newValue) //ввод метода
{    
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);