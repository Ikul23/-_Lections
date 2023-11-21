//Виды методов
// Вид метода 1: Метод ничего не возвращает и ничего не принимает
// void Method1()
// {
//     Console.WriteLine( "Автор ...");
// }
// Method1 (); // Строка вызова метода

// Вид Метода 2: Метод, который ничего не возвращает, но принимает аргументы
// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method2 (count: 4, msg: "New text"); // "4" означает сколько раз требуется вывести текст на консоль

// Вид метода 3: Метод ничего не принимает, но возвращает аргумент в консоль
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
//Console.WriteLine(Year);

// Вид метода 4: Метод принимает и возвращает аргумент в консоль

string Method4(int count, string text)
{
    // int i = 0;
    //string result = String.Empty;  //String.Empty - означает пустая строка

    // while(i < count)
    // {
    //     result = result + text;
    //     i++;
    // }
    // return result;
    string result = String.Empty;
    for(int i = 0; i < count; i++) // использование цикла for
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);