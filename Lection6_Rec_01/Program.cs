﻿// Собрать строку с цислами от a до b, a >= b, используя метод рекурсии

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
// В цикле for начинается с числа a и уменьшается до b.
// Каждое число добавляется к строке result с пробелом в конце.
// В конце функция возвращает сформированную строку.

string NumbersRec(int a, int b)
{
    if (a<=b) return NumbersRec(a+1, b)+$"{a} ";
    else return string.Empty; // выход из цикла рекурсии
}
// Рекурсивная функция, которая добавляет число a к результату и 
// вызывает саму себя с увеличенным a до тех пор, пока a не станет больше b.
// Когда a становится больше b, функция возвращает пустую строку.

Console.WriteLine(NumbersFor(1,10));
Console.WriteLine(NumbersRec(1,10));
// Оба подхода являются валидными, но у рекурсивного метода есть некоторые недостатки,
// такие как возможное переполнение стека при больших значениях a и b. В целом, 
// код будет работать и выведет строки с числами от 10 до 1 в обоих случаях.