// Задача: найти позицию минимального элемента в неотсортированной части массива 
//и отсортировать массив по возрастанию

// Создание и заполнение массива случайными числами
    int newarr = 100;

        int[] arr = new int[newarr];
        Random random = new Random();
        for (int i = 0; i < newarr; i++)
        {
            arr[i] = random.Next(1, newarr);
        }
void PrintArray(int[] array)
{
    int count = array.Length; // определение количества элементов массива
    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(" ");
}

void SelectionSort(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        int minPosition = i;

        for (int j=i+1; j<array.Length; j++) //поиск максимального элемента массива
        {
            if(array[j] < array[minPosition]) minPosition =j;
        }

        int temporaryPosition = array[i]; //начало сортировки массива по возрастанию
        array[i] = array[minPosition];
        array[minPosition] = temporaryPosition; //конец сортировки массива по возрастанию
    }
}
Console.WriteLine ("Неотсортированный массив:");
PrintArray(arr);
SelectionSort(arr);
Console.WriteLine ("Отсортированный массив:");
PrintArray(arr);