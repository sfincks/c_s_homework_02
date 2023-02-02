// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.WriteLine("Введите цифру соответствующую дню недели");
start:
int numb = Convert.ToInt32(Console.ReadLine());

if (numb <= 0 || numb > 7)
{
    System.Console.WriteLine("Введите число от 1 до 7");
    goto start;
}
else if (numb > 0 && numb <= 5)
{
    System.Console.WriteLine("Это не выходной");
}
else
{
    System.Console.WriteLine("Это выходной!");
}