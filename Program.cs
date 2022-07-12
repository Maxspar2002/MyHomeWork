// Домашнее задание к семинару № 5
//
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int quantity;

Console.WriteLine("Задайте размер массива: ");
int size_array = Convert.ToInt32(Console.ReadLine());

int[] array_number = CreateRandomArray(size_array,100,999);
OutputArray(array_number);

quantity = QuantPositiveNumber(array_number);
Console.WriteLine("Количество четных чисел в массиве: " + quantity);

int QuantPositiveNumber(int[] array)
{
   int quant = 0;   
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0) quant = quant + 1;
   }
   return quant;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];

   for (int i = 0; i < size; i++)
      array[i] = new Random().Next(minValue, maxValue);
   return array;
}

void OutputArray (int[] array)
{
   int size_array = array.Length;

   Console.Write("[");

   for (int i = 0; i < size_array; i++)
   {
      Console.Write(array[i]);
      if (i < size_array - 1) 
         Console.Write(", ");
   }
   
   Console.Write("]");
   Console.WriteLine("");
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int summa;

Console.WriteLine("Задайте размер массива: ");
int size_array = Convert.ToInt32(Console.ReadLine());

int[] array_number = CreateRandomArray(size_array,-100,100);
OutputArray(array_number);

summa = SummaElementov(array_number);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях в массиве: " + summa);

int SummaElementov(int[] array)
{
   int rezult = 0;   
   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 == 1) rezult = rezult + array[i];
   }
   return rezult;
}

int[] CreateRandomArray(int size_array,int minValue,int maxValue)
{
   int[] array = new int[size_array];
   for (int i = 0; i < size_array; i++)
   {
      array[i] = new Random().Next(minValue,maxValue);
   }
   return array;
}

void OutputArray (int[] array)
{
   int size_array = array.Length;

   Console.Write("[");

   for (int i = 0; i < size_array; i++)
   {
      Console.Write(array[i]);
      if (i < size_array - 1) 
         Console.Write(", ");
   }
   
   Console.Write("]");
   Console.WriteLine("");
}

*/
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте размер массива: ");
int size_array = Convert.ToInt32(Console.ReadLine());

int[] array_number = InputArray(size_array);

int minNumber = MinNumberInArray(array_number);
int maxNumber = MaxNumberInArray(array_number);
int decision = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами: {decision}");

int MinNumberInArray(int[] array)
{
   int min = array[0];   
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] < min) min = array[i];
   }
   return min;
}

int MaxNumberInArray(int[] array)
{
   int max = array[0];   
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] > max) max = array[i];
   }
   return max;
}

int[] InputArray(int size_array)
{
   int[] array = new int[size_array];
   for (int i = 0; i < size_array; i++)
   {
      array[i] = Convert.ToInt32(Console.ReadLine());
   }
   return array;
}
