// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array.GetLength(0); j++) 
   {
   array[i, j] = new Random().Next(-10, 11);
   Console.Write(array[i, j] + " ");
}
}