// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if ((number <= 99 || number > 999)&&(number >= -99 || number < -999))
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    System.Console.WriteLine(Math.Abs(number % 100) / 10);
}