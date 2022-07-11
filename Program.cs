// Домашнее задание к семинару №4
//
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int number;

Console.WriteLine("Введите целое число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма всех цифр числа: " + SummaDigInNumber(number));

int SummaDigInNumber (int num)
{
   int rezult = 0;
   int lnum = LengthNumber(num);
   
   for (int i = 1; i <= lnum; i++)
   {
      rezult = rezult + num % 10;
      num = num / 10;
      //Console.WriteLine(num[i]+" "+dig_num+" "+rezult);
   }
   return rezult;   
}

int LengthNumber (int num)
{
   int l_num = 0;

   if (num == 0) l_num = 1;

   while (num != 0)
      {
         num = num / 10;
         l_num = l_num + 1;
      }
   return l_num;
}


*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array_number;

Console.WriteLine("Введите ряд из 8 чисел: ");

int[] array_number = InputArray(8);
OutputArray(array_number);

int[] InputArray(int size_array)
{
   int[] array = new int[size_array];
   
   for (int i = 0; i < size_array; i++)
   {
      array[i] = Convert.ToInt32(Console.Read());
      Console.Write(", ");
   }
   return array;
}

void OutputArray (int[] array)
{
   int size_array = array.Length;

   Console.Write("[");

   for (int i = 0; i < size_array; i++)
      Console.Write(array[i]+ ", ");

   Console.Write("]");
}
