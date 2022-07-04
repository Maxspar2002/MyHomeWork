// Домашнее задание к семинару №2
//
// Задача 10

int number, num2;

Console.Write("Введите целое трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

num2 = DigNumber2(number);
Console.WriteLine("Вторая цифра введеннного числа - " + num2);

int DigNumber2 (int num)
{
   int num1, num2;
   num1 = num : 100;
   num2 = (num : 10) - num1 * 10
   return num2;
}


// Задача 4
//

// Задача 8
/*
int N, i;

Console.Write("Введите целое число: ");
N = Convert.ToInt32(Console.ReadLine());

if (number != 0)
{
   num2 = number;
   Console.WriteLine("Вторая цифра введеннного числа - " + num2);
}
else
{
   Console.WriteLine("Введенное число равно 0 или не является числом!");
}    


// Задача 4
//

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