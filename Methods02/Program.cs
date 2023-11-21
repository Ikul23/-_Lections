// Задача: вывести таблицу умножения на экран используя конструкцию: "цикл в цикле"
// string Method4(int count, string text);

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}"); // интерполяция строк
    }
   Console.WriteLine(); 
}