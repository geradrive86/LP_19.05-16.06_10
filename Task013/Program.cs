/*
Задача 13: Напишите программу, которая 
1. выводит третью цифру заданного числа 
2. или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {

// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет! ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }

int Prompt(string message)
{
        Console.Write(message);
    string value = Console.ReadLine(); 
    int result = Convert.ToInt32(value); 
    return result;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
    number /= 10;
    }
return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
        return true;
}
int number = Prompt("Введите число > "); 
if (ValidateNumber(number)) 
{
    Console.WriteLine(GetThirdRank(number));
}