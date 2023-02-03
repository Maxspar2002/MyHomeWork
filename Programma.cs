
// Итоговое задание к блоку обучения на программе Разработчик
//
// Задача: Задайте двумерный массив. 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Например:
// [“Hello”, “2”, “world”, “:-)”]  →  [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”]  →  []


Console.Write("Задайте размер массива: ");
int size_array = Convert.ToInt32(Console.ReadLine());

string[] array = InputArray(size_array);
string[] arrayNew = new string[size_array];

int index_new = 0;
for (int index = 0; index < size_array; index++)
 {
    if (array[index].Length <= 3)
    {
        arrayNew[index_new] = array[index];
        index_new = index_new + 1;
    }          
 }

if (index_new == 0)
    Console.Write("В заданном массиве нет ни одной строки, длина которой меньше, либо равна 3 символам !");
else
{
    Console.Write("Новый массив:");
    OutputArray(arrayNew, index_new);
}


string[] InputArray(int size_array)
{
   string[] array = new string[size_array];
   
   for (int i = 0; i < size_array; i++)
   {
      array[i] = Console.ReadLine();
    //  Console.Write(", ");
   }
   return array;
}

void OutputArray (string[] array, int size_array)
{
   // int size_array = array.Length;
   Console.Write("[");

   for (int i = 0; i < size_array; i++)
   {
      Console.Write("'" + array[i] + "'");
      if (i < size_array - 1) 
         Console.Write(", ");
   }
   
   Console.Write("]");
   Console.WriteLine("");
}   