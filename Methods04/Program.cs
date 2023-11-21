// Задача: найти позицию минимального элемента в неотсортированной части массива 
//и отсортировать массив по возрастанию

int [] arr = {1, 4, 6, 9, 1, 5, 9, 8 };
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

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);