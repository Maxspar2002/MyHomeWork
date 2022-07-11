// Домашнее задание к семинару №4
//
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number;

Console.WriteLine("Введите целое число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма всех цифр числа: " + SummaDigInNumber(number));

int SummaDigInNumber (int num)
{
   int rezult = 0;
   int lnum = LenghtNumber(num);
   
   for (int i = 1; i <= lnum; i++)
   {
      rezult = rezult + num % 10;
      num = num / 10;
      //Console.WriteLine(num[i]+" "+dig_num+" "+rezult);
   }
   return rezult;   
}

int LenghtNumber (int num)
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



/*

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N, number_i, cube;

Console.Write("Введите целое число: ");
N = Convert.ToInt32(Console.ReadLine());

cube = 1;
number_i = 1;

while (number_i <= N)
{
   cube = DegreeNumber(number_i,3);
   Console.Write(cube + ", ");
   number_i = number_i + 1;
}
Console.WriteLine("");

int DegreeNumber(int num, int i)
{
   int rezult = num;
   
   if (i == 0) rezult = 1;

   while (i > 1)
   {
      rezult = rezult * num;
      i = i - 1;
   }
   return rezult;
}
*/