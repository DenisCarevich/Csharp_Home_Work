﻿/*
    Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ackermann(m, n));

int ackermann(int m, int n) {
    if (m == 0) 
        return n + 1;
    else if (n == 0)
        return ackermann(m - 1, 1);
    else return ackermann(m - 1, ackermann(m, n - 1));
}