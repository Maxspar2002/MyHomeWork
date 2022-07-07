// Домашнее задание к семинару №3
//
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

string number;

Console.Write("Введите целое пятизначное число: ");
number = Console.ReadLine();

CheckNumber (number);

void CheckNumber (string num)
{
   if (num[0] == num[4] && num[1] == num[3])
      Console.WriteLine("Введенное число - паллиндром");
   else
      Console.WriteLine("Введенное число - НЕ паллиндром");
}  



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
