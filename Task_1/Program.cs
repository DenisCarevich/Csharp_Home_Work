/*
    Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

ViewRangeIntegers(m, n);

void ViewRangeIntegers(int m, int n) {
    if (m > n) return;

    Console.Write($"{m}" + $"{(m != n ? ", " : " ")}");

    ViewRangeIntegers(m + 1, n);
}
