// Задача 2: Напишите программу, которая 
//1.на вход gринимает два числа
//2.выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число {a} - большее, число {b} - меньшее");
}

else

    if (a < b)
{
    Console.WriteLine($"Число {b} - большее, число {a} - меньшее");
}
else
if (a == b)
{
    Console.WriteLine($" Данные числа > {a} < и > {b} < не подходят под условия, так как они равны)");
} 