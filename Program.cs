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

