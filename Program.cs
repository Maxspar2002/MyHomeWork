// Домашнее задание к семинару №1
//
// Задача 2

int num1, num2;
Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
   Console.WriteLine("Большее число - " + num1);
   Console.WriteLine("Меньшее число - " + num2);
}
else
{
    if (num1 < num2)
    {
        Console.WriteLine("Большее число - " + num2);
        Console.WriteLine("Меньшее число - " + num1);
    }
    else
        Console.WriteLine("Введенные числа - равны");
}    


// Задача 4
//
int num1, num2, num3, max_number;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

max_number = num1;

if (num2 > num1)
    max_number = num2;

if (num3 > max_number)
    max_number = num3;

Console.WriteLine("Максимальное число - " + max_number);


// Задача 6
//
int num1;

Console.Write("Введите целое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
    Console.WriteLine("Число " + num1 + " - четное");
else
    Console.WriteLine("Число " + num1 + " - нечетное");



// Задача 8
//
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

