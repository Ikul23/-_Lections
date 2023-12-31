﻿// Работа с двумерными массивами

string [,] table = new string [2, 5];
// String.Empty - инициализация строк
// table [0, 0] table [0, 1] table [0, 2] table [0, 3] table [0, 4]
// table [1, 0] table [1, 1] table [1, 2] table [1, 3] table [1, 4]
// table [1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows,colums]}-");
//     }
// }

void PrintArray(int [,] matr)
{
for (int rows = 0; rows < matr.GetLength(0); rows++)
{
    for (int colums = 0; colums < matr.GetLength(1); colums++)
    {
        Console.Write($"{matr[rows,colums]} ");
    }
    Console.WriteLine(); // конструкция позволяет вывести двумерный массив в виде матрицы
}
}
void FillArray(int [,] matr)  //метод, заполняющий матрицу
{
  for (int rows = 0; rows < matr.GetLength(0); rows++)
{
    for (int colums = 0; colums < matr.GetLength(1); colums++)
    {
        matr [rows,colums] = new Random().Next(1,10); // генератор случайных числе от 1 до 9
    }
}  
}
int [,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);