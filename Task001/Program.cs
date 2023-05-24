//1. Напишите программу, которая на вход принимает два числа 
//2.проверяет, является ли первое число квадратом второго.

// numA = 25, numB = 5 -> да
// numA = 2, numB = 10 -> нет
// numA = 9, numB = -3 -> да
// numA = -3 numB = 9 -> нет

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"Да, {num1} является квадратом числа {num2}");
}
else
{
    Console.WriteLine($"Нет, {num1} не является квадратом числа {num2}");
}
