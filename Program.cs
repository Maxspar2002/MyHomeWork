// Домашнее задание к семинару №2
//
// Задача 10
/*
int number, num2;

Console.Write("Введите целое трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

num2 = DigNumber2(number);
Console.WriteLine("Вторая цифра введеннного числа - " + num2);

int DigNumber2 (int num)
{
   int num1, num2;
   num1 = num / 100;
   num2 = (num / 10) - num1 * 10;
   return num2;
}
*/

// Задача 13
//

int Number, num2, num3, lenght_number;

Console.Write("Введите целое трехзначное число: ");
Number = Convert.ToInt32(Console.ReadLine());

if (Number > 100)
{
   lenght_number = LenghtNumber(Number);
   num2 = Number / (DegreeNumber(10,lenght_number-2));
   num3 = (Number / DegreeNumber(10,lenght_number-3)) - num2 * 10;
   Console.WriteLine("Третья цифра введеннного числа - " + num3);
}
else
{
   Console.WriteLine("Третьей цифры в введенном числе - нет!");
}    

int LenghtNumber(int num)
{
   int lenght_n = 0;

   while (num != 0)
   {
      num = num / 10;
      lenght_n = lenght_n + 1;
   }
   return lenght_n;
}

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

// Задача 8
/*
int N, i;

Console.Write("Введите целое число: ");
N = Convert.ToInt32(Console.ReadLine());

i = 1;

while (i <= N)
{
   if (i % 2 == 0)
   {
      Console.Write(i + " ");
   }
   i = i + 1;
}

*/