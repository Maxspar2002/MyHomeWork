// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Задайте число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void ShowNumber(int num1, int num2)
{
   if (num1 < num2)
      ShowNumber(num1,num2-1);
   Console.Write(num2+" ");
}
ShowNumber(N,M);
Console.WriteLine(" ");

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// Домашнее задание к семинару № 8
//
// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
/*
Console.WriteLine("Задайте размер массива: ");
Console.Write("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array_number = CreateRandomArray(rows, columns, 0, 100); 

Console.WriteLine("Изначальный массив:");
OutputArray(array_number);

OrderLinesInArray(array_number);

Console.WriteLine("Отсортированный массив:");
OutputArray(array_number);

int[,] OrderLinesInArray(int[,] array)
{
   int maxNumber;
   int indexMaxNumber;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1)-1; j++)
      {
         maxNumber = array[i,j];
         indexMaxNumber = j;
         for (int k = j; k < array.GetLength(1); k++)
         {
            if (array[i,k] > maxNumber)  
            {
               maxNumber = array[i,k];
               indexMaxNumber = k;
            }
         }
         array[i,indexMaxNumber] = array[i,j];
         array[i,j] = maxNumber;
      }
   }
   return array;
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
         // if (j < columns - 1) Console.Write(", ");
      }
   Console.WriteLine("");
   }
   Console.WriteLine("");
}


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задайте размер массива: ");
Console.Write("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array_number = CreateRandomArray(rows, columns, 0, 10); 
OutputArray(array_number);

int summa_i = 0;
int indexMin = 0;
int minSumma = SummaElementsInLinesArray(array_number,0);

for (int i=1; i < rows; i++)
{
   summa_i = SummaElementsInLinesArray(array_number,i);
   if (summa_i < minSumma)
   {
      minSumma = summa_i;
      indexMin = i;
   }
}

Console.WriteLine($"Строка {indexMin+1} - строкa с наименьшей суммой ({minSumma}) элементов");

int SummaElementsInLinesArray(int[,] array, int row)
{
   int summa = 0;
   for (int j = 0; j < array.GetLength(1); j++)
      summa = summa + array[row,j];
   return summa;
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
         // if (j < columns - 1) Console.Write(", ");
      }
   Console.WriteLine("");
   }
   Console.WriteLine("");
}


// Задача 62: Заполните спирально массив m на n.
// 1 2 3 4 5
// 16 17 18 19 6
// 15 24 25 20 7
// 14 23 22 21 8
// 13 12 11 10 9

Console.WriteLine("Задайте размер массива: ");
Console.Write("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array_number = CreateArrayOnSpiral(rows, columns);
OutputArray(array_number);

int[,] CreateArrayOnSpiral(int rows, int columns)
{
   int number = 1;
   int num_cycle = rows / 2; // количество проходов по 4-м линиям прямоугольника при заполнении массива
   if (columns < rows) num_cycle = columns / 2; // берем по минимальному значению размерности массива (строк или колонок)

   int[,] array = new int[rows, columns];

   for (int k = 0; k < num_cycle; k++)
   {
      for (int j = k; j < columns-k; j++)
      {   
         array[k,j] = number;
         number = number + 1;
      }
      for (int i = k+1; i < rows-1-k; i++)
      {
         array[i,columns-1-k] = number;
         number = number + 1;
      }
      for (int j = columns-1-k; j >= k; j--)
      {   
         array[rows-1-k,j] = number;
         number = number + 1;
      }
      for (int i = rows-2-k; i > k; i--)
      {
         array[i,k] = number;
         number = number + 1;
      }
   }
   // Если количество строк или стоблцов массива - нечетное, дозаполняем оставшуюся центральную линию (часть) массива
   if (rows % 2 == 1 && rows < columns)
   {
      for (int j = num_cycle; j < columns-num_cycle; j++)
      {
         array[num_cycle,j] = number;
         number = number + 1;
      } 
   }
   if (columns % 2 == 1 && columns < rows)
   {
      for (int i = num_cycle; i < rows-num_cycle; i++)
      {
         array[i,num_cycle] = number;
         number = number + 1;
      } 
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
*/