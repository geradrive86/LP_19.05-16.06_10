/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int[] m = new int[8]; 
void RandomArray(int[] array)
{
    for (int i = 0; i < m.Length; i++)
    {
        array[i]=new Random().Next(1, 2); 
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine($"Массив из 8 единиц = ");
RandomArray(m);