// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine($"Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());

int startN = 1;


while(startN <= n)
    {
 if(startN % 2 ==0)
 
 Console.Write(startN + ", ");
 startN ++;
    }
