// Домашнее задание к семинару №1
//
// Задача 2

/*
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
*/

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
