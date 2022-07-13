// Домашнее задание к семинару № 6
//
// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Задайте количество M вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array_number = InputArray(M);

int k_number = 0;

for (int i = 0; i < M; i++)
   if (array_number[i] > 0) k_number = k_number + 1;

Console.WriteLine("Количество положительных чисел: " + k_number);

int[] InputArray(int size_array)
{
   int[] array = new int[size_array];
   for (int i = 0; i < size_array; i++)
   {
      Console.Write($"Введите число {i+1}: ");
      array[i] = Convert.ToInt32(Console.ReadLine());
   }
   return array;
}


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] array_number = InputArray(2,2);
double[] array_crosspoint = CrossPoint(array_number);
PrintRezult(array_number,array_crosspoint);

double[] CrossPoint(double[,] array)
{
   double[] array_xy = new double[2];
   array_xy[0] = (array[1,1] - array[0,1])/(array[0,0] - array[1,0]); // x = (b2 - b1)/(k1 - k2)
   array_xy[1] = array[0,0] * array_xy[0] + array[0,1]; // y = k1 * x + b1
   // Console.WriteLine("Координата x: " + array_xy[0]);
   return array_xy;
}

void PrintRezult(double[,] array, double[] array_xy)
{
   if (array[0,0] == array[1,0] && array[0,1] == array[1,1])
      Console.WriteLine($"\nПрямые полностью совпадают");
   else
      if (array[0,0] == array[1,0])
         Console.WriteLine($"\nПрямые НЕ ПЕРЕСЕКАЮТСЯ !");
      else
         Console.WriteLine("Координаты точки пересечения прямых: ("+ array_xy[0] + "; " +array_xy[1]+")");
}

double[,] InputArray(int size_array1, int size_array2)
{
   double[,] array = new double[size_array1, size_array2];
   for (int i = 0; i < size_array1; i++)
   {
      Console.WriteLine($"Введите параметры для {i+1}-го уравнения (y = k * x + b):");
      
      Console.Write($"Введите параметр k{i+1}: ");
      array[i,0] = Convert.ToDouble(Console.ReadLine());
      
      Console.Write($"Введите параметр b{i+1}: ");
      array[i,1] = Convert.ToDouble(Console.ReadLine());
   }   
   return array;
}
