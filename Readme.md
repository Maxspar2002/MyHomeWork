# Описание решения задачи

## Задача: 
## Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
## длина которых меньше, либо равна 3 символам. 
## Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
## Например:
## [“Hello”, “2”, “world”, “:-)”]  →  [“2”, “:-)”]

# Решение задачи

1 Задаем размер массива строк (вводим с клавиатуры количество строк)
2 Заполняем массив данными (вводим с клавиатуры каждую строку отдельно)
3 Создаем новый пустой массив с тем же количеством элементов - как у исходного 
4 Запускаем цикл для прохода по всем элементам (строкам) исходного массива 
5 На каждом шаге цикла проверяем длину элемента массива (строки) и если она меньше, либо равна 3 
  символам, то присваиваем соответствующему элементу нового массива значение этой строки.
7 После окончания цикла - выводим на экран новый массив 