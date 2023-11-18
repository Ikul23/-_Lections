// Создание массива с помощью метода генератора случайных чисел и нахождение индекса массива
using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];

        // Заполнение массива
        FillArray(array);

        // Вывод содержимого массива
        PrintArray(array);
    }

    // Метод для заполнения массива случайными числами
    static void FillArray(int[] arr)
    {
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(100); // Пример заполнения случайными числами от 0 до 99
        }
    }

    // Метод для вывода содержимого массива
    static void PrintArray(int[] arr)
    {
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine(); // Добавляем перевод строки после вывода массива
    }
}
