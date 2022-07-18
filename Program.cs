// Домашнее задание к семинару № 7
//
// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте размер массива: ");
Console.Write("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array_number = CreateRandomArray(rows, columns, -10, 10); 
OutputArrayDouble(array_number);

double[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
   double[,] array = new double[rows, columns];

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
         array[i,j] = new Random().Next(minValue*100, maxValue*100) / 100d;
   }
   return array;
}

void OutputArrayDouble (double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {   
      for (int j = 0; j < array.GetLength(1); j++)
      {   
         Console.Write(array[i,j] + " ");
         // if (j < columns - 1) Console.Write(", ");
      }
   Console.WriteLine("");
   }
   Console.WriteLine("");
}


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задайте позиции искомого элемента массива: ");
Console.Write("Задайте номер строки элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте номер колонки элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

// double[,] array_number = CreateRandomArray(4, 4, -10, 10); 
SearchElementInArray(array_number, row, column);

void SearchElementInArray(double[,] array, int row, int col)
{
   if (row > array.GetLength(0) || col > array.GetLength(1))
      Console.WriteLine("Такого элемента в массиве нет");
   else
      Console.WriteLine("Искомый элемент массива: "+ array[row-1,column-1]);
}


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Задайте размер массива: ");
Console.Write("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array_number = CreateRandomArray(rows, columns, 0, 100);
OutputArray(array_number);
ArithmeticMeanInArray(array_number);

void ArithmeticMeanInArray(int[,] array)
{
   double sum;
   double arithmeticMean;
   for (int j = 0; j < array.GetLength(1); j++)
   {
      sum = 0;
      for (int i = 0; i < array.GetLength(0); i++)
         sum = sum + Convert.ToDouble(array[i,j]);
      arithmeticMean = Math.Round(sum / array.GetLength(0),2);
      Console.WriteLine($"Среднее арифметическое столбца N{j+1}:" + arithmeticMean);
   }
}

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
         array[i,j] = new Random().Next(minValue, maxValue);
   }
   return array;
}

void OutputArray (int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {   
      for (int j = 0; j < array.GetLength(1); j++)
      {   
         Console.Write(array[i,j] + " ");
      }
   Console.WriteLine("");
   }
   Console.WriteLine("");
}