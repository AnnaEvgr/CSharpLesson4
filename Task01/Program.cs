/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Не использовать Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

System.Console.WriteLine("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Number(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int fakt = Number(numberA, numberB);


System.Console.WriteLine($"Число {numberA} возведенное в степень {numberB} = {fakt}");