/*Задача 2: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg} : ");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int a = Prompt("Введите число ");
int s = 0;
while (a > 0)
{

    s = s + a % 10;
    a = a / 10;

}

Console.WriteLine($"Сумма числа = {s}");
