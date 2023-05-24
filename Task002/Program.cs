// Задача 2: Напишите программу, которая 
//1.на вход gринимает два числа
//2.выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"{num1} больше {num2}");
}
else
if(num1 < num2)
{
    Console.WriteLine($"{num1} меньше {num2}");
}
else
if(num1 == num2)
{
    Console.WriteLine($" данные числа не подходят под условия, так как они равны)");
}