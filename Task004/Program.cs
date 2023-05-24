// Задача 4: Напишите программу, которая 
// 1.принимает на вход три числа 
// 2.выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2  && num1 > num3)
{
    Console.WriteLine($" {num1} - максимальное ");
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