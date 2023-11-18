// имеется одномерный массив 'array' из 'n' элементов
// требуется найти элемент массива равный 'find'
//int [] array = {10, 21, 32, 54, 5, 63, 21, 78};
//int n = array.Length;       // определяет длину массива
//int find = 5;
//int index = 0;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размерность N массива: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите элемент массива find который нужно найти: ");
        int find = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        // Заполнение массива
        FillArray(array);

        // Вывод содержимого массива
        PrintArray(array, find);
    }

    static void FillArray(int[] arr)
    {
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100);
        }
    }

    static void PrintArray(int[] arr, int find)
    {
        Console.WriteLine("Содержимое массива:");
        bool found = false;

        foreach (var item in arr)
        {
            Console.Write(item + " ");

            if (item == find)
            {
                found = true;
            }
        }

        Console.WriteLine();

        if (found)
        {
            Console.WriteLine($"Элемент {find} найден в случайно сгенерированном массиве");
        }
        else
        {
            Console.WriteLine($"Элемент {find} не найден в случайно сгенерированном массиве");
        }
    }
}


