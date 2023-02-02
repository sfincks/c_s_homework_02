
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
start:
int num = Convert.ToInt32(Console.ReadLine());

int result = -1;
if (num < 100)
{
    System.Console.WriteLine("Введите больше число 100");
    goto start;
}
else if (num >= 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
}
System.Console.WriteLine(result);
