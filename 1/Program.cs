﻿/*Задача 1: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
int[] CreatArray(string message) // ф-ция создания массива с заданным пользователем размером
{
    System.Console.WriteLine(message + "-->");
    int sizeMassiv= Convert.ToInt32(Console.ReadLine());
    int[]massiv=new int [sizeMassiv];
    return massiv;
}
int[] FillingArray(int[]baseArray,string message) // Ф-ция заполнения массива пользователем
{
    for(int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine(message + $"-->");
        baseArray[i]= Convert.ToInt32(Console.ReadLine());
    }
    return baseArray;
}
void DisplayElements(int[] baseArray) // Процедура вывовда индекса и присвоенного эл-та
{
    System.Console.WriteLine("Введенные числа: ");
    for (int i= 0; i< baseArray.Length; i++)
    {
        System.Console.WriteLine($"{baseArray[i]}");

    }
}
void FindNum(int[ ] baseArray) // Процедура проверки условия задачи и вывод результата
{
    int count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i]>0)
        {
            count++;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"Количество чисел со значением  больше нуля составляет --> {count}");
    Console.ResetColor();
}

int[]baseArray=CreatArray("Введите количество чисел для ввода");
string message = $"Введите число";
FillingArray(baseArray,message);
DisplayElements(baseArray);
FindNum(baseArray);
