﻿// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNum()
{
    Console.WriteLine("Введите кол-во символов в массиве: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[] ArrayRand(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,999);
    }
    return array;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}
int length = InputNum();
int[] array = ArrayRand(length);
PrintArr(array);