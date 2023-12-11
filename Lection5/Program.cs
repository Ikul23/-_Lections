// Задача превратить строку в числовые значения
// => одномерный массив

string text = "(1,2) (2,3) (3,4) (4,5) (5,6)"
    .Replace("(", "")
    .Replace(")", "");

Console.WriteLine(text);

var data = text.Split(" ")
    .Select(item => item.Split(','))
    .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
    .Where(e => e.x % 2 == 0) // fix the condition here
    .Select(point => (point.x * 10, point.y))
    .ToArray();

for (int i = 0; i < data.Length; i++) // fix the loop increment
{
    Console.WriteLine(data[i]);
}
