/* 
Задача 10: Напишите программу, которая 
принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
*/

Console.Write("Введите целое трехзначное  число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = number/ 10 % 10;
    Console.WriteLine($"{secondDigit} является второй цифрой числа {number}.");
}
else
{
    Console.WriteLine("Неверное число.");
}


//эталонное решение
/*int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"Введенное число '{number}'"); 
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}'");
*/