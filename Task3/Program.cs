// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array.GetLength(1); j++) 
   {
   array[i, j] = new Random().Next(2, 7);
   Console.Write(array[i, j] + " ");
}
}

void Viever (int[,] array; int arrayMean)
{
    int sum = 0;
    int count = 0;
    
   
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array.GetLength(1); j++) 
      {
         sum += array[i, j];
         count++;
         double arrayMean = sum/count;
         
    }
    Console.Write($" Среднее арифметическое{array} - {arreyMean}");
}        
}

Console.WriteLine();
Viever(array, frrayMean);